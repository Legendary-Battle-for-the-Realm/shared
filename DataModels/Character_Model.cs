using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Shared.Models
{
    [Serializable]
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Desc { get; set; }
        public string Faction { get; set; } = string.Empty;
        public string Cultivation { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int HP { get; set; }
        public int Qi { get; set; }
        public int Atk { get; set; }
        public List<Skill> Skills { get; set; } = new List<Skill>();
    }
}