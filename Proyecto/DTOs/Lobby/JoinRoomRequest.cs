using System.ComponentModel.DataAnnotations;

namespace Proyecto.DTOs.Lobby
{
    public class JoinRoomRequest
    {
        [Required]
        public int RoomId { get; set; }
    }
}