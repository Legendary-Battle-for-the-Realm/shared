using System;
using System.Collections.Generic;

namespace Shared.DTOs
{
    public class MatchStartedMessage
    {
        public string Action { get; set; } = "match_started";
        public required MatchStartedData Data { get; set; }
    }

    public class MatchStartedData
    {
        public required List<PlayerDTO> Players { get; set; }
        public required List<string> Order { get; set; }
        public required List<CharacterCardDTO> CharacterCards { get; set; }
    }

    public class CharacterCardDTO
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Desc { get; set; }
        public required int Atk { get; set; }
        public required string Faction { get; set; }
        public required List<SkillDTO> Skill { get; set; }
    }

    public class SkillDTO
    {
        public required string Name { get; set; }
        public required string Ref { get; set; }
    }
}
