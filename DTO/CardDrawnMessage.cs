using System;
using System.Collections.Generic;

namespace Shared.DTOs
{
    public class CardDrawnMessage
    {
        public string Action { get; set; } = "card_drawn";
        public required string PlayerId { get; set; }
        public required CardDrawnData Data { get; set; }
    }

    public class CardDrawnData
    {
        public required List<CardDTO> Cards { get; set; }
    }

    public class CardDTO
    {
        public required int Value { get; set; }  // Ví dụ: 1 cho Át, 13 cho King
        public required string Suit { get; set; }  // "Spades", "Clubs", "Diamonds", "Hearts"
    }
}
