using Proyecto.Services.Interfaces;

namespace Proyecto.Services
{
    public class DiceService : IDiceService
    {
        private readonly Random _random;

        public DiceService()
        {
            _random = new Random();
        }

        public int RollDice()
        {
            return _random.Next(1, 7); // 1-6
        }

        public bool ValidateRoll(int value)
        {
            return value >= 1 && value <= 6;
        }
    }
}