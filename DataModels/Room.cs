using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Room
    {
        public int Id { get; set; }
        public required string Name { get; set; } 
        public int MaxPlayers { get; set; } 
        public List<Player> Players { get; set; } = new List<Player>(); 
        public bool IsGameStarted { get; set; } 
        public int CurrentTurnPlayerId { get; set; } 
        public List<Card> Deck { get; set; } = new List<Card>(); 
        public List<Card> DiscardPile { get; set; } = new List<Card>();
        public List<int> TurnOrder { get; set; } = new List<int>(); 
    }
}