using System;

namespace Shared.DTOs
{
    public class ConnectMessage
    {
        public string Action { get; set; } = "connect";
        public required PlayerDTO Player { get; set; }
    }

    public class PlayerDTO
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        // Các trường bổ sung nếu cần, ví dụ: avatar, level, v.v.
    }
}
