using System;
using System.Collections.Generic;

namespace Shared.DTOs
{
    public class InitMatchMessage
    {
        public string Action { get; set; } = "init_match";
        public InitMatchData Data { get; set; }
    }

    public class InitMatchData
    {
        public List<string> Players { get; set; }
    }
}
