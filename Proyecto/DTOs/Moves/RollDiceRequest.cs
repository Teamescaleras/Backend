using System.ComponentModel.DataAnnotations;

namespace Proyecto.DTOs.Moves
{
    public class RollDiceRequest
    {
        [Required]
        public int GameId { get; set; }
    }
}