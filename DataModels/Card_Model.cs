using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Shared.Enums;

namespace Shared.Models
{
    [Serializable]
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public string Ref { get; set; } = string.Empty;
        public CardType Type { get; set; }
        public int? EffectId { get; set; }
        [JsonIgnore]
        public Effect? Effect { get; set; }
        public int Quantity { get; set; }
    }
}