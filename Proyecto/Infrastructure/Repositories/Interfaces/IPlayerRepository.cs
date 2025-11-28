using Proyecto.Models;

namespace Proyecto.Infrastructure.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        Task<Player?> GetByIdAsync(int id);
        Task<Player?> GetByGameAndUserAsync(int gameId, int userId);
        Task<List<Player>> GetByGameIdAsync(int gameId);
        Task<Player> CreateAsync(Player player);
        Task<Player> UpdateAsync(Player player);
    }
}  