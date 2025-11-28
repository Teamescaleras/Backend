using Proyecto.Models;

namespace Proyecto.Infrastructure.Repositories.Interfaces
{
    public interface IRoomRepository
    {
        Task<Room?> GetByIdAsync(int id);
        Task<Room?> GetByIdWithPlayersAsync(int id);
        Task<List<Room>> GetAvailableRoomsAsync();
        Task<Room> CreateAsync(Room room);
        Task<Room> UpdateAsync(Room room);
    }
}