namespace Proyecto.Services.Interfaces
{
    public interface IDiceService
    {
        int RollDice();
        bool ValidateRoll(int value); 
    }
} 