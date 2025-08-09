using System.Text.Json.Serialization;

namespace GameTracker.Models.FaceItModels
{
    public class FaceItStats
    {
        [JsonPropertyName("player_id")]
        public string PlayerId { get; set; } = "";

        [JsonPropertyName("lifetime")]
        public LifetimeStats Lifetime { get; set; } = new();
    }
}
