using System.Text.Json.Serialization;

namespace GameTracker.Models.FaceItModels
{
    public class Game
    {
        [JsonPropertyName("region")]
        public string Region { get; set; } = "";

        [JsonPropertyName("skill_level")]
        public int SkillLevel { get; set; }

        [JsonPropertyName("faceit_elo")]
        public int Elo { get; set; }
    }
}
