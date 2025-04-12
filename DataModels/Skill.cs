namespace Shared.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public string Name { get; set; } = null!;
        public string Ref { get; set; } = null!;
        public int Cost { get; set; }
        // Thuộc tính bổ sung từ skill.json (nếu cần lưu vào database)
        public required string Desc { get; set; }
        public required string Effect { get; set; }
    }
}