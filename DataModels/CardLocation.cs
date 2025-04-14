using System;
using Newtonsoft.Json;

namespace Shared.Models
{
    [Serializable]
    public class CardLocation
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        [JsonIgnore]
        public Card? Card { get; set; } 

        public int? RoomId { get; set; }
        [JsonIgnore]
        public Room? Room { get; set; } 

        public int? PlayerId { get; set; }
        [JsonIgnore]
        public Player? Player { get; set; } 

        public string? LocationType { get; set; } 
    }
}