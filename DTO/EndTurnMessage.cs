using System;

namespace Shared.DTOs
{
    public class EndTurnMessage
    {
        public string Action { get; set; } = "end_turn";
        public EndTurnData Data { get; set; }
    }

    public class EndTurnData
    {
        public string PlayerId { get; set; }
    }
}
