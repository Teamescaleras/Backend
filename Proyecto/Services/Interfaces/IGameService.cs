using Proyecto.DTOs.Games;
using Proyecto.DTOs.Moves;
using Proyecto.DTOs.Lobby;
using Proyecto.Models;

namespace Proyecto.Services.Interfaces
{
    public interface IGameService
    {
        // LOBBY
        Task<RoomSummaryDto> GetRoomSummaryAsync(int roomId);

        // GAME
        Task<Game> CreateGameAsync(int roomId);
        Task<GameStateDto> GetGameStateAsync(int gameId);
        Task<MoveResultDto> RollDiceAndMoveAsync(int gameId, int userId);
        Task SurrenderAsync(int gameId, int userId);

        // PROFESOR
        Task<ProfesorQuestionDto?> GetProfesorQuestionAsync(int gameId, int userId);
        Task<MoveResultDto> AnswerProfesorQuestionAsync(int gameId, int userId, string answer);
    }
}