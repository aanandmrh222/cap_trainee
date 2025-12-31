// using System;
// using System.Collections.Generic;

// namespace Security.Authentication
// {
//     // TASK 1: FacialFeatures Class (Value Object)
//     public sealed class FacialFeatures : IEquatable<FacialFeatures>
//     {
//         public string EyeColor { get; }
//         public decimal PhiltrumWidth { get; }

//         public FacialFeatures(string eyeColor, decimal philtrumWidth)
//         {
//             EyeColor = eyeColor;
//             PhiltrumWidth = philtrumWidth;
//         }

//         public override bool Equals(object obj)
//         {
//             if (ReferenceEquals(this, obj)) return true;

//             if (obj is FacialFeatures other) return Equals(other);

//             return false;
//         }

//         public bool Equals(FacialFeatures other)
//         {
//             if (other is null) return false;

//             return EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;
//         }

//         public override int GetHashCode()
//         {
//             return HashCode.Combine(EyeColor, PhiltrumWidth);
//         }
//     }

//     // TASK 2: Identity Class (Composite Value Equality)
//     public sealed class Identity : IEquatable<Identity>
//     {
//         public string Email { get; }
//         public FacialFeatures FacialFeatures { get; }

//         public Identity(string email, FacialFeatures facialFeatures)
//         {
//             Email = email;
//             FacialFeatures = facialFeatures;
//         }

//         public override bool Equals(object obj)
//         {
//             if (ReferenceEquals(this, obj)) return true;

//             if (obj is Identity other) return Equals(other);

//             return false;
//         }

//         public bool Equals(Identity other)
//         {
//             if (other is null) return false;

//             return Email == other.Email && FacialFeatures.Equals(other.FacialFeatures);
//         }

//         public override int GetHashCode()
//         {
//             return HashCode.Combine(Email, FacialFeatures);
//         }
//     }

//     // TASK 3: Authenticator Class (Business Logic)
//     public class Authenticator
//     {
//         private readonly HashSet<Identity> _registeredIdentities = new HashSet<Identity>();

//         private static readonly Identity _admin =
//             new Identity(
//                 "admin@exerc.ism",
//                 new FacialFeatures("green", 0.9m)
//             );

//         public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
//         {
//             if (faceA is null || faceB is null) return false;

//             return faceA.Equals(faceB);
//         }

//         public bool Register(Identity identity)
//         {
//             return _registeredIdentities.Add(identity);
//         }

//         public bool IsRegistered(Identity identity)
//         {
//             return _registeredIdentities.Contains(identity);
//         }

//         public bool IsAdmin(Identity identity)
//         {
//             return _admin.Equals(identity);
//         }

//         public static bool AreSameObject(Identity identityA, Identity identityB)
//         {
//             return ReferenceEquals(identityA, identityB);
//         }
//     }


//     public class FaceIDCaller
//     {
//         public static void FaceIDCallerMethod()
//         {
//             Authenticator authenticator = new Authenticator();

//             Console.WriteLine("=== FACE ID AUTHENTICATION DEMO ===");

//             // Face comparison
//             var face1 = new FacialFeatures("green", 0.9m);
//             var face2 = new FacialFeatures("green", 0.9m);
//             Console.WriteLine("Same face: " + Authenticator.AreSameFace(face1, face2));

//             // Admin authentication
//             var adminAttempt = new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));
//             Console.WriteLine("Is Admin: " + authenticator.IsAdmin(adminAttempt));

//             // Register user
//             var user = new Identity("tunde@thecompetition.com", new FacialFeatures("blue", 0.9m));

//             Console.WriteLine("Register user: " + authenticator.Register(user));

//             Console.WriteLine("Is Registered: " + authenticator.IsRegistered(
//                     new Identity("tunde@thecompetition.com",
//                     new FacialFeatures("blue", 0.9m))
//                 ));

//             // Reference vs value equality
//             var identityA = new Identity("alice@thecompetition.com", new FacialFeatures("blue", 0.9m));

//             var identityB = identityA;

//             var identityC = new Identity("alice@thecompetition.com", new FacialFeatures("blue", 0.9m));

//             Console.WriteLine("Same object (A,B): " + Authenticator.AreSameObject(identityA, identityB));

//             Console.WriteLine("Same object (A,C): " + Authenticator.AreSameObject(identityA, identityC));
//         }
//     }
// }