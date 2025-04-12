using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Armor
    {
        [Key]
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Atk { get; set; } 
        public required string Def { get; set; } 
        public required string Desc { get; set; }
        public required int UserId { get; set; }
        public required string CultivationRequired { get; set; }

        public int SkillId { get; set; } 
        public required EquipmentSkill Skill { get; set; } 
    }
}