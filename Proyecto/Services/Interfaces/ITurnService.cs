using Proyecto.Models;

namespace Proyecto.Services.Interfaces
{
    public interface ITurnService
    {
        bool IsPlayerTurn(Game game, int playerId);
        void AdvanceTurn(Game game);
        Player GetCurrentPlayer(Game game);
    }
} 