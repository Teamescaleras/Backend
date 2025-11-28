using Microsoft.EntityFrameworkCore; 
using Proyecto.Infrastructure.Data;  
using Proyecto.Models;

namespace Proyecto.Infrastructure.Repositories
{
    public interface IGameRepository
    {
        Task<Game?> GetByIdAsync(int id);
        Task<Game?> GetByIdWithDetailsAsync(int id);
        Task<Game> CreateAsync(Game game);
        Task<Game> UpdateAsync(Game game);
        Task<List<Game>> GetGamesByUserIdAsync(int userId);
        Task<Game?> GetByRoomIdAsync(int roomId);
    }
}