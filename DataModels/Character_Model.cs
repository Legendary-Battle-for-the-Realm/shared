using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Character
    {
        [Key]
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Desc { get; set; }
        public required int Atk { get; set; }
        public required string Faction { get; set; }
        public required string Cultivation { get; set; }
        public required int HP { get; set; } = 100;
        public required int Qi { get; set; } = 0;
        public required List<Skill> Skills { get; set; } = new List<Skill>();
        public required int UserId { get; set; }
    }
}