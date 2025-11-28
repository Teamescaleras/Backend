using Proyecto.Models;

namespace Proyecto.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}