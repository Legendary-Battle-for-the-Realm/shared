using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Shared.Models
{
    [Serializable]
    public class Room
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int MaxPlayers { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public bool IsGameStarted { get; set; }
        public int CurrentTurnPlayerId { get; set; }
        public List<int> TurnOrder { get; set; } = new List<int>();
    }
}