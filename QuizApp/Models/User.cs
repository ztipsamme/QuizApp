namespace QuizApp.Models
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string Tagline { get; set; } = string.Empty;
        public int Xp { get; set; } = 0;
        public int Matches { get; set; } = 0;
        public int Wins { get; set; } = 0;
        public int Friends { get; set; } = 0;

        public User(string username, string displayName, string tagline)
        {
            Username = username;
            DisplayName = displayName;
            Tagline = tagline;
        }
    }
}