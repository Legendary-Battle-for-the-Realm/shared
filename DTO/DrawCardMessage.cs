using System;

namespace Shared.DTOs
{
    public class DrawCardMessage
    {
        public string Action { get; set; } = "draw_card";
        public string PlayerId { get; set; }
    }
}
