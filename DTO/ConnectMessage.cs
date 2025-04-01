using System;

namespace Shared.DTOs
{
    public class ConnectMessage
    {
        public string Action { get; set; } = "connect";
        public PlayerDTO Player { get; set; }
    }

    public class PlayerDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        // Các trường bổ sung nếu cần, ví dụ: avatar, level, v.v.
    }
}
