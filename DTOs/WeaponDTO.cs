namespace Shared.DTOs
{
    public class WeaponDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Atk { get; set; }
        public string Desc { get; set; }
        public int UserId { get; set; }
        public string CultivationRequired { get; set; }
        public EquipmentSkillDTO Skill { get; set; }
    }
}