using System.ComponentModel.DataAnnotations;

public class Cultivation
{
    [Key]
    public required int Id { get; set; }

    public required string Name { get; set; }
    public required int RequiredQi { get; set; }
}
