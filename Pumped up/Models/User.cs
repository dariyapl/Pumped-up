namespace PumpedUp.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Username { get; set; }
        public string Email { get; set; }
        private string PasswordHash { get; set; }  // приватний, недоступний зовні
        public string Role { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        protected double TargetWeight { get; set; } // доступний у похідних класах

        public User(int id, string username, string email, string passwordHash, string role, double height, double weight, double targetWeight)
        {
            Id = id;
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            Role = role;
            Height = height;
            Weight = weight;
            TargetWeight = targetWeight;
        }
    }
}
