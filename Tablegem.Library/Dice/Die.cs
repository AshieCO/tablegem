using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tablegem.Library.Dice.Interfaces;
using Tablegem.Library.Services.Interfaces;

namespace Tablegem.Library.Dice
{
    public class Die : IDie
    {
        private IRandomNumberGenerator _randomNumberGenerator;

        public int MinimumValue { get; private set; }
        public int MaximumValue { get; private set; }

        public Die(IRandomNumberGenerator randomNumberGenerator, int numberOfFaces)
        {
            _randomNumberGenerator = randomNumberGenerator;
            SetMinimumAndMaximumValues(numberOfFaces);
        }

        public int Roll()
        {
            return _randomNumberGenerator.RandomNumber(MinimumValue, MaximumValue);
        }

        private void SetMinimumAndMaximumValues(int numberOfFaces)
        {
            MinimumValue = 1;
            MaximumValue = numberOfFaces;
        }
    }
}
