using System.ComponentModel.DataAnnotations;

namespace Proyecto.DTOs.Moves
{
    public class MoveRequest
    {
        [Required]
        public int GameId { get; set; }
    }
}