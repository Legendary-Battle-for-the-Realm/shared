using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Shared.Models
{
    [Serializable]
    public class Player
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int RoomId { get; set; }
        public int HP { get; set; }
        [JsonIgnore]
        public Room Room { get; set; }
    }
}