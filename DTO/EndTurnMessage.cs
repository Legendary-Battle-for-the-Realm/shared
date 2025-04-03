using System;

namespace Shared.DTOs
{
    public class EndTurnMessage
    {
        public string Action { get; set; } = "end_turn";
        public required EndTurnData Data { get; set; }
    }

    public class EndTurnData
    {
        public required string PlayerId { get; set; }
    }
}
