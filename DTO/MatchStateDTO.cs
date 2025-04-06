namespace Shared.DTO
{
    public class MatchStateDTO
    {
        public int MatchId { get; set; }
        public List<string> PlayerOrder { get; set; } = new List<string>();
        public string CurrentPlayerId { get; set; } = string.Empty;
        public int TurnIndex { get; set; }
        public int RoundNumber { get; set; }
        public bool YourTurn { get; set; }
        public Dictionary<string, bool> AvailableActions { get; set; } = new Dictionary<string, bool>();
        public object? AdditionalState { get; set; }
    }
}
