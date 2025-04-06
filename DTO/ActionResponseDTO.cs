namespace Shared.DTO
{
    public class ActionResponseDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public MatchStateDTO? UpdatedState { get; set; }
    }
}
