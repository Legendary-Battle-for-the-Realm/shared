namespace Shared.DTOs
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public int? HealthPoints { get; set; }
    }
}