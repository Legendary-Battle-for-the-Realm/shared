using Shared.Enums;

namespace Shared.DTOs
{
    public class CardDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Desc { get; set; }
        public required string Ref { get; set; }
        public CardType Type { get; set; }
        public int? EffectId { get; set; }
        public int? Quantity { get; set; }
    }
}