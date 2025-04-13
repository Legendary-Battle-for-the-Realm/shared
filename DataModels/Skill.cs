using System;
using Newtonsoft.Json;

namespace Shared.Models
{
    [Serializable]
    public class Skill
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        [JsonIgnore]
        public Character? Character { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Desc { get; set; }
        public string? Effect { get; set; }
        public int Cost { get; set; } = 0;
        public string Ref { get; set; } = string.Empty;
    }
}