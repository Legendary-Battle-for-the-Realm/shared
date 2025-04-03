using System;
using System.Collections.Generic;

namespace Shared.DTOs
{
    public class InitMatchMessage
    {
        public string Action { get; set; } = "init_match";
        public required InitMatchData Data { get; set; }
    }

    public class InitMatchData
    {
        public required List<string> Players { get; set; }
    }
}
