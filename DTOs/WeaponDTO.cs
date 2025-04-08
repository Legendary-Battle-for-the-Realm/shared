namespace Shared.DTOs
{
    public class WeaponDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Atk { get; set; }
        public required string Desc { get; set; }
        public int UserId { get; set; }
        public required string CultivationRequired { get; set; }
        public required EquipmentSkillDTO Skill { get; set; }
    }
}