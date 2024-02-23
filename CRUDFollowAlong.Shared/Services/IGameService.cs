using CRUDFollowAlong.Shared.Entities;

namespace CRUDFollowAlong.Shared.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
        Task<Game> GetGameById(int id);
        Task<Game> AddGame(Game game);
        Task<Game> EditGame(int id, Game game);
        Task<bool> DeleteGame(int id);
    }
}
