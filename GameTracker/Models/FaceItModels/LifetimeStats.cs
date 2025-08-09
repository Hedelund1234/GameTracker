using System.Text.Json.Serialization;

namespace GameTracker.Models.FaceItModels
{
    public class LifetimeStats
    {
        [JsonPropertyName("Average K/D Ratio")]
        public string AverageKDRatio { get; set; } = "";

        [JsonPropertyName("ADR")]
        public string ADR { get; set; } = "";

        [JsonPropertyName("Average Headshots %")]
        public string AverageHeadshot { get; set; } = "";

        [JsonPropertyName("Win Rate %")]
        public string WinRate { get; set; } = "";

        [JsonPropertyName("Recent Results")]
        public List<int> Last5Games { get; set; } = new();

        [JsonPropertyName("Total Matches")]
        public string TotalMatches { get; set; } = "";

        [JsonPropertyName("Total Kills with extended stats")]
        public string TotalKills { get; set; } = "";

        [JsonIgnore]
        public double AverageKills =>
            double.TryParse(TotalMatches, out var matches) && matches > 0 &&
            double.TryParse(TotalKills, out var kills)
                ? kills / matches
                : 0;
    }
}
