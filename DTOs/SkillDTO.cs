namespace Shared.DTOs
{
    public class SkillDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Ref { get; set; }
        public int Cost { get; set; }
    }
}