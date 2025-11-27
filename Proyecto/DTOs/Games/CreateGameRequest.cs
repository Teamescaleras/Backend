using System.ComponentModel.DataAnnotations;

namespace Proyecto.DTOs.Games
{
    public class CreateGameRequest
    {
        [Required]
        public int RoomId { get; set; }
    }
}