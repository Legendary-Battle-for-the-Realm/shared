public class Weapon {
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string Atk { get; set; }   // Dạng phần trăm
    public required string Desc { get; set; }
    public int OwnerId { get; set; }
    public required string CultivationRequired { get; set; }
    public required EquipmentSkill Skill { get; set; }
}
