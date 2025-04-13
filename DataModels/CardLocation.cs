namespace Shared.Models
{
    public class CardLocation
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }

        public int? RoomId { get; set; } 
        public Room Room { get; set; }

        public int? PlayerId { get; set; } 
        public Player Player { get; set; }

        public string LocationType { get; set; } 
    }
}