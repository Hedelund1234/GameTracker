using Blazored.LocalStorage;
using GameTracker.Interfaces.FaceItInterfaces;
using GameTracker.Models.FaceItModels;
using System.Net.Http;
using System.Net.Http.Json;
using System.Numerics;

namespace GameTracker.Services.FaceItServices
{
    public class FaceItInfoService : IFaceItInfoService
    {
        private readonly HttpClient _httpClient;
        public FaceItInfoService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("FaceitClient");
        }
        public async Task<Player> GetPlayerInfoAsync(string name)
        {
            var url = $"players?nickname={name}";

            var player = await _httpClient.GetFromJsonAsync<Player>(url);

            return player ?? new Player();
        }
    }
}
