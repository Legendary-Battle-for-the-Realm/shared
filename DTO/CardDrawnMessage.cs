using System;
using System.Collections.Generic;

namespace Shared.DTOs
{
    public class CardDrawnMessage
    {
        public string Action { get; set; } = "card_drawn";
        public string PlayerId { get; set; }
        public CardDrawnData Data { get; set; }
    }

    public class CardDrawnData
    {
        public List<CardDTO> Cards { get; set; }
    }

    public class CardDTO
    {
        public int Value { get; set; }  // Ví dụ: 1 cho Át, 13 cho King
        public string Suit { get; set; }  // "Spades", "Clubs", "Diamonds", "Hearts"
    }
}
