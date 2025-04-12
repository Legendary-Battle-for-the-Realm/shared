namespace Shared.Models
{
    public class Player
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public int RoomId { get; set; } 
        public List<Card> Hand { get; set; } = new List<Card>(); 
        public List<Character> Characters { get; set; } = new List<Character>();
        public int HP { get; set; } 
        public List<Armor> EquippedArmors { get; set; } = new List<Armor>(); 
        public List<Weapon> EquippedWeapons { get; set; } = new List<Weapon>(); 
    }
}