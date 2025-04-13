using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Player
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int RoomId { get; set; }
        public int HP { get; set; }
        public Room Room { get; set; } 
    }
}