using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;

namespace MiniSocialMedia
{
    class Program
    {
        // STATIC DATA MEMBERS
        private static Repository<User> _users = new();
        private static User? _currentUser = null;
        private static readonly string _dataFile = "social-data.json";

        static void Main()
        {
            Console.Title = "MiniSocial - Console Edition";
            Console.WriteLine("=== MiniSocial ===");

            LoadData();

            while (true)
            {
                try
                {
                    if (_currentUser == null)
                        ShowLoginMenu();
                    else
                        ShowMainMenu();
                }
                catch (SocialException ex)
                {
                    ConsoleColorWrite(ConsoleColor.Red, $"Error: {ex.Message}");
                    if (ex.InnerException != null)
                        Console.WriteLine(" → " + ex.InnerException.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred.");
                    Console.WriteLine(ex);
                    LogError(ex);
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // LOGIN MENU 
        static void ShowLoginMenu()
        {
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.Write("Choice: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Register();
                    break;
                case "2":
                    Login();
                    break;
                case "3":
                    SaveData();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        // REGISTER 
        static void Register()
        {
            Console.Write("Username: ");
            string? username = Console.ReadLine();

            Console.Write("Email: ");
            string? email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email))
                throw new SocialException("Username and Email are required");

            if (_users.Find(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)) != null)
                throw new SocialException("Username already exists");

            var user = new User(username, email);
            _users.Add(user);

            Console.WriteLine("Registration successful!");
        }

        //  LOGIN 
        static void Login()
        {
            Console.Write("Username: ");
            string? username = Console.ReadLine();

            var user = _users.Find(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
                throw new SocialException("User not found");

            _currentUser = user;

            // Subscribe to post notification
            foreach (var u in _users.GetAll())
            {
                u.OnNewPost += post =>
                {
                    if (_currentUser != null &&
                        _currentUser.IsFollowing(post.Author.Username))
                    {
                        ConsoleColorWrite(ConsoleColor.Cyan,
                            $"New post from {post.Author}");
                    }
                };
            }

            Console.WriteLine($"Logged in as {_currentUser.Username}");
        }

        // MAIN MENU 
        static void ShowMainMenu()
        {
            Console.WriteLine($"Logged in as {_currentUser}");
            Console.WriteLine("1. Post message");
            Console.WriteLine("2. View my posts");
            Console.WriteLine("3. View timeline");
            Console.WriteLine("4. Follow user");
            Console.WriteLine("5. List users");
            Console.WriteLine("6. Logout");
            Console.WriteLine("7. Exit and Save");
            Console.Write("Choice: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PostMessage();
                    break;
                case "2":
                    ShowPosts(_currentUser!.GetPosts());
                    break;
                case "3":
                    ShowTimeline();
                    break;
                case "4":
                    FollowUser();
                    break;
                case "5":
                    ListUsers();
                    break;
                case "6":
                    _currentUser = null;
                    break;
                case "7":
                    SaveData();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        // POST MESSAGE
        static void PostMessage()
        {
            Console.Write("Enter post (empty to cancel): ");
            string? content = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(content))
                return;

            _currentUser!.AddPost(content);
            Console.WriteLine("Post added successfully");
        }

        // TIMELINE 
        static void ShowTimeline()
        {
            var timelinePosts = _users.GetAll()
                .Where(u => u.Username == _currentUser!.Username
                         || _currentUser.IsFollowing(u.Username))
                .SelectMany(u => u.GetPosts())
                .OrderByDescending(p => p.CreatedAt)
                .ToList();

            ShowPosts(timelinePosts);
        }

        // SHOW POSTS 
        static void ShowPosts(IEnumerable<Post> posts)
        {
            var list = posts.Take(10).ToList();

            if (!list.Any())
            {
                Console.WriteLine("No posts to display");
                return;
            }

            foreach (var post in list)
            {
                Console.WriteLine(post);
                Console.WriteLine(post.CreatedAt.FormatTimeAgo());
                Console.WriteLine("---------------------------");
            }
        }

        // FOLLOW USER 
        static void FollowUser()
        {
            Console.Write("Username to follow (empty to cancel): ");
            string? username = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(username))
                return;

            var target = _users.Find(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (target == null)
                throw new SocialException("User does not exist");

            _currentUser!.Follow(username);
            Console.WriteLine($"You are now following {username}");
        }

        // LIST USERS 
        static void ListUsers()
        {
            foreach (var user in _users.GetAll().OrderBy(u => u))
            {
                Console.WriteLine(user.GetDisplayName());
            }
        }

        // SAVE DATA 
        static void SaveData()
        {
            try
            {
                var json = JsonSerializer.Serialize(_users.GetAll());
                File.WriteAllText(_dataFile, json);
                Console.WriteLine("Data saved successfully");
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        // LOAD DATA 
        static void LoadData()
        {
            try
            {
                if (!File.Exists(_dataFile))
                    return;

                var json = File.ReadAllText(_dataFile);
                var users = JsonSerializer.Deserialize<List<User>>(json);

                if (users != null)
                {
                    foreach (var user in users)
                        _users.Add(user);
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        // LOG ERROR 
        static void LogError(Exception ex)
        {
            try
            {
                File.AppendAllText("error.log",
                    $"{DateTime.Now}\n{ex.Message}\n{ex.StackTrace}\n\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //  CONSOLE COLOR WRITE 
        static void ConsoleColorWrite(ConsoleColor color, string message)
        {
            var old = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = old;
        }
    }
}
