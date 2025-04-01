using System;
using System.Collections.Generic;

namespace Shared.DTOs
{
    public class ConnectAckMessage
    {
        public string Action { get; set; } = "connect_ack";
        public ConnectAckData Data { get; set; }
    }

    public class ConnectAckData
    {
        public string Message { get; set; }
        public LobbyDTO Lobby { get; set; }
    }

    public class LobbyDTO
    {
        public List<PlayerDTO> Players { get; set; }
    }
}
