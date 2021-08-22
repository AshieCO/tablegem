using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tablegem.Library.Services.Interfaces;

namespace Tablegem.Library.Services
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private Random _random;

        public RandomNumberGenerator()
        {
            _random = new Random();
        }

        public int RandomNumber(int minimumValue, int maximumValue)
        {
            return _random.Next(minimumValue, maximumValue + 1);
        }
    }
}
