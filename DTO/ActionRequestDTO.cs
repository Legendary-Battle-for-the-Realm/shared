namespace Shared.DTO
{
    public enum ActionType
    {
        ActionCard,
        Skill,
        Consume
    }

    public class ActionRequestDTO
    {
        public int CharacterId { get; set; }

        public ActionType ActionType { get; set; }

        public int ActionId { get; set; }

        public int QiCost { get; set; }
    }
}
