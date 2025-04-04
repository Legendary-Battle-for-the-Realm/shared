using System.ComponentModel.DataAnnotations;

public class Weapon
{
    [Key]
    public required int Id { get; set; } 

    public required string Name { get; set; }
    public required string Atk { get; set; }   // Dạng phần trăm
    public required string Desc { get; set; }

    public required int UserId { get; set; }
    public required string CultivationRequired { get; set; }
    public required EquipmentSkill Skill { get; set; }
}
