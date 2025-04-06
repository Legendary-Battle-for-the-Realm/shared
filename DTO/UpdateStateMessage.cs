using System;
using System.Collections.Generic;

namespace Shared.DTOs
{
    public class UpdateStateMessage
    {
        public string Action { get; set; } = "update_state";
        public required UpdateStateData Data { get; set; }
    }

    public class UpdateStateData
    {
        public required string PlayerId { get; set; }
        public required int Hp { get; set; }
        public required List<BuffDTO> Buffs { get; set; }
    }

    public class BuffDTO
    {
        public required string Name { get; set; }
        public required string Ref { get; set; }
    }
}
