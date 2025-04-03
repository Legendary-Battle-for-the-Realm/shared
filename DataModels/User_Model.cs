using System.ComponentModel.DataAnnotations;
public class User
    {
        [Key]
        public required int UserId { get; set; } 
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public int? HealthPoints { get; set; }
    }