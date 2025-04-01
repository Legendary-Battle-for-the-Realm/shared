using System;
using System.Collections.Generic;

namespace Shared.DTOs
{
    public class MatchStartedMessage
    {
        public string Action { get; set; } = "match_started";
        public MatchStartedData Data { get; set; }
    }

    public class MatchStartedData
    {
        public List<PlayerDTO> Players { get; set; }
        public List<string> Order { get; set; }
        public List<CharacterCardDTO> CharacterCards { get; set; }
    }

    public class CharacterCardDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Atk { get; set; }
        public string Faction { get; set; }
        public List<SkillDTO> Skill { get; set; }
    }

    public class SkillDTO
    {
        public string Name { get; set; }
        public string Ref { get; set; }
    }
}
