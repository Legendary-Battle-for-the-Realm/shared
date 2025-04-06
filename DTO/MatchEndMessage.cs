using System;

namespace Shared.DTOs
{
    public class MatchEndMessage
    {
        public string Action { get; set; } = "match_end";
        public required MatchEndData Data { get; set; }
    }

    public class MatchEndData
    {
        public required string WinnerPlayerId { get; set; }
    }
}
