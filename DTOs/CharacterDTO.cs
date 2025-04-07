using System.Collections.Generic;

namespace Shared.DTOs
{
    public class CharacterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Atk { get; set; }
        public string Faction { get; set; }
        public string Cultivation { get; set; }
        public int HP { get; set; }
        public int Qi { get; set; }
        public List<SkillDTO> Skills { get; set; }
        public int UserId { get; set; }
    }
}