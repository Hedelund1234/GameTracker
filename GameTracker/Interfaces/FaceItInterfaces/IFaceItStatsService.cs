using GameTracker.Models.FaceItModels;

namespace GameTracker.Interfaces.FaceItInterfaces
{
    public interface IFaceItStatsService
    {
        Task<FaceItStats> GetPlayerStatsAsync(string playerId);
    }
}
