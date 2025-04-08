using System.Collections.Generic;

namespace Shared.DTOs
{
    public class CharacterDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Desc { get; set; }
        public int Atk { get; set; }
        public required string Faction { get; set; }
        public required string Cultivation { get; set; }
        public int HP { get; set; }
        public int Qi { get; set; }
        public required List<SkillDTO> Skills { get; set; }
        public int UserId { get; set; }
    }
}