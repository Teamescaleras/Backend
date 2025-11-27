using System.ComponentModel.DataAnnotations;

namespace Proyecto.DTOs.Moves
{
    public class SurrenderRequest
    {
        [Required]
        public int GameId { get; set; }
    }
}