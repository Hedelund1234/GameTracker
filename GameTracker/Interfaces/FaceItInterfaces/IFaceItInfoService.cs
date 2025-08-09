using GameTracker.Models.FaceItModels;
using System.Numerics;

namespace GameTracker.Interfaces.FaceItInterfaces
{
    public interface IFaceItInfoService
    {
        Task<Player> GetPlayerInfoAsync(string name);
    }
}
