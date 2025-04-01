using System;

namespace Shared.DTOs
{
    public class MatchEndMessage
    {
        public string Action { get; set; } = "match_end";
        public MatchEndData Data { get; set; }
    }

    public class MatchEndData
    {
        public string WinnerPlayerId { get; set; }
    }
}
