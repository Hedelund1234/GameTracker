using GameTracker.Interfaces.FaceItInterfaces;
using GameTracker.Models.FaceItModels;
using System.Net.Http.Json;

namespace GameTracker.Services.FaceItServices
{
    public class FaceItStatsService : IFaceItStatsService
    {
        private readonly HttpClient _httpClient;
        public FaceItStatsService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("FaceitClient");
        }
        public async Task<FaceItStats> GetPlayerStatsAsync(string playerId)
        {
            var url = $"players/{playerId}/stats/cs2";

            var stats = await _httpClient.GetFromJsonAsync<FaceItStats>(url);

            return stats ?? new FaceItStats();
        }
    }
}
