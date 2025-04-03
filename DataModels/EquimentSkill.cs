using System.ComponentModel.DataAnnotations;

public class EquipmentSkill
{
    [Key] 
    public required int Id { get; set; } 

    public required string Name { get; set; }
    public required string Ref { get; set; }
}
