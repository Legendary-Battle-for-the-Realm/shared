using System;
using System.Collections.Generic;

namespace Server.GameLogic
{
    public class MatchState
    {
        public int MatchId { get; set; }
        public List<string> PlayerOrder { get; set; } = new List<string>();
        public string CurrentPlayerId { get; set; } = string.Empty;

        /// <summary>
        /// Số thứ tự lượt hiện tại.
        /// </summary>
        public int TurnIndex { get; set; }

        /// <summary>
        /// Số vòng (round) hiện tại của trận đấu.
        /// </summary>
        public int RoundNumber { get; set; }

        /// <summary>
        /// Lưu trạng thái các hành động đã được sử dụng của mỗi người chơi trong lượt hiện tại.
        /// Ví dụ: key: PlayerId, value: Tuple<bool, bool> (ActionCardUsed, SkillUsed)
        /// </summary>
        public Dictionary<string, (bool ActionCardUsed, bool SkillUsed)> ActionUsage { get; set; } = new Dictionary<string, (bool, bool)>();

        /// <summary>
        /// Các thông tin cập nhật khác của trận đấu (ví dụ: trạng thái nhân vật, HP, qi, các buff/debuff).
        /// </summary>
        public Dictionary<string, object> AdditionalState { get; set; } = new Dictionary<string, object>();

        /// <summary>
        /// Thời gian cập nhật cuối cùng.
        /// </summary>
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
}
