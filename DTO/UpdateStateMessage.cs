using System;
using System.Collections.Generic;

namespace Shared.DTOs
{
    public class UpdateStateMessage
    {
        public string Action { get; set; } = "update_state";
        public UpdateStateData Data { get; set; }
    }

    public class UpdateStateData
    {
        public string PlayerId { get; set; }
        public int Hp { get; set; }
        public List<BuffDTO> Buffs { get; set; }
    }

    public class BuffDTO
    {
        public string Name { get; set; }
        public string Ref { get; set; }
    }
}
