using System.Text.Json.Serialization;

namespace GameTracker.Models.FaceItModels
{
    public class Player
    {
        [JsonPropertyName("player_id")]
        public string PlayerId { get; set; } = "";

        [JsonPropertyName("nickname")]
        public string Nickname { get; set; } = "";

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; } = "";

        [JsonPropertyName("games")]
        public Games Games { get; set; } = new();
    }
}
