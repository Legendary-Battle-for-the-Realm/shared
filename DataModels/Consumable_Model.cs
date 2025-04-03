public class Effect {
    public required string Name { get; set; }
    public required string Ref { get; set; }
}

public class Consumable {
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Desc { get; set; }
    public required Effect Effect { get; set; }
}
