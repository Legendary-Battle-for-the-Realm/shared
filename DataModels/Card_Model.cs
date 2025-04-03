using System.ComponentModel.DataAnnotations;

public enum CardType
{
    Action,
    Consumable
}

public class Card
{
    [Key]
    public required int Id { get; set; } // Khóa chính

    public required string Name { get; set; }
    public required string Desc { get; set; }
    public required string Ref { get; set; }

    public required CardType Type { get; set; } 

    public int? EffectId { get; set; } 
    public Effect? Effect { get; set; } 

    public int? Quantity { get; set; } 
}
