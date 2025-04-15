using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Shared.Models
{
    [Serializable]
    public class Armor
    {
        [Key]
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required int Atk { get; set; }
        public required int Def { get; set; }
        public required string Desc { get; set; }
        public int? UserId { get; set; }
        public required string CultivationRequired { get; set; }

        public int? SkillId { get; set; }
        [JsonIgnore] 
        public EquipmentSkill? Skill { get; set; }
        public string ImageUrl { get; set; }
    }
}