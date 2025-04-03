using System.ComponentModel.DataAnnotations;

public class Skill
{
    [Key]
    public required int Id { get; set; } 

    public required string Name { get; set; }
    public required string Ref { get; set; }

    public required int Cost { get; set; } 
}
