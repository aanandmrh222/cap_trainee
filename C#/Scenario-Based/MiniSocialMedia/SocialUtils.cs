using System;

namespace MiniSocialMedia
{
    public static class SocialUtils
    {
        public static string FormatTimeAgo(this DateTime time)
        {
            var diff = DateTime.UtcNow - time;

            if (diff.TotalSeconds < 60) return "just now";
            if (diff.TotalMinutes < 60) return $"{diff.Minutes} min ago";
            if (diff.TotalHours < 24) return $"{diff.Hours} h ago";

            return time.ToString("MMM dd");
        }
    }
}
