using System;

namespace Shared.DTOs
{
    public class DrawCardMessage
    {
        public required string Action { get; set; } = "draw_card";
        public required string PlayerId { get; set; }
    }
}
