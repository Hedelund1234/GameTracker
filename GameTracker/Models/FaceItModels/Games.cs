using System.Text.Json.Serialization;

namespace GameTracker.Models.FaceItModels
{
    public class Games
    {
        [JsonPropertyName("cs2")]
        public Game? CS2 { get; set; }
    }
}
