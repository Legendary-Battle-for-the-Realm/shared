using System;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    [Serializable]
    public class EquipmentSkill
    {
        [Key]
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Ref { get; set; }
    }
}