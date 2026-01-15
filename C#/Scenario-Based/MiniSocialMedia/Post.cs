using System;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;

namespace MiniSocialMedia
{
    public class Post
    {
        public User Author { get; init; }
        public string Content { get; init; }
        public DateTime CreatedAt {get; init; } = DateTime.UtcNow;

        public Post(User author, string content)
        {
            if(author == null)
            {
                throw new ArgumentException("Author");
            }

            Author = author;
            Content = content;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("");

            sb.AppendLine($"{Author}, {CreatedAt: MMM dd HH:mm}");
            sb.AppendLine(Content);

            var hashtags = Regex.Matches(Content, @"#[A-Za-z]+");
            if(hashtags.Count > 0)
            {
                sb.Append("Tags: ");
                sb.AppendJoin(", ", hashtags.Cast<Match>().Select(m => m.Value));
            }

            return sb.ToString().TrimEnd();
        }
        
    }
}