using System;
using System.Collections.Generic;

namespace Shared.DTOs
{
    public class ConnectAckMessage
    {
        public string Action { get; set; } = "connect_ack";
        public required ConnectAckData Data { get; set; }
    }

    public class ConnectAckData
    {
        public required string Message { get; set; }
        public required LobbyDTO Lobby { get; set; }
    }

    public class LobbyDTO
    {
        public required List<PlayerDTO> Players { get; set; }
    }
}
