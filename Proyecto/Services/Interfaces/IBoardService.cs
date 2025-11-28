using Proyecto.Models;
using Proyecto.DTOs.Moves;

namespace Proyecto.Services.Interfaces
{
    public interface IBoardService
    {
        Board GenerateBoard(int gameId, int size = 100);
        bool ValidatePosition(int position, int boardSize);
        int? GetSnakeDestination(Board board, int position);
        int? GetLadderDestination(Board board, int position);

        ProfesorQuestionDto? GetProfesorQuestion(int position);
        bool ValidateProfesorAnswer(int position, string answer);
    }
}