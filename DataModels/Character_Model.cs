using System.Collections.Generic;

public class Skill
{
    public required string Name { get; set; }
    public required string Ref { get; set; }
}

public class Character
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Desc { get; set; }
    public required int Atk { get; set; }
    public required string Faction { get; set; }
    public required List<Skill> Skill { get; set; }
}
