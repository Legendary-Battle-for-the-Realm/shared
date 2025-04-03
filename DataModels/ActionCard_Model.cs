public enum CardType {
    Attack,
    Defense
}

public class ActionCard {
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string Desc { get; set; }
    public required string Ref { get; set; }
}
