
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tablegem.Library.Dice.Interfaces;
using Tablegem.Library.Services.Interfaces;

namespace Tablegem.Library.Dice
{
    public class DiceFactory : IDiceFactory
    {
        private IConfiguration _config;
        private IRandomNumberGenerator _randomNumberGenerator;
        private bool _useValidPolyhedralDice;
        private List<int> _validPolyhedralDiceFaceNumbers;

        public DiceFactory(IConfiguration config, IRandomNumberGenerator randomNumberGenerator)
        {
            _config = config;
            _randomNumberGenerator = randomNumberGenerator;
            _useValidPolyhedralDice = _config.GetSection("UseValidPolyhedralDice").Get<bool>();
            _validPolyhedralDiceFaceNumbers = _config.GetSection("ValidPolyhedralDiceFaceNumbers").Get<List<int>>();
        }

        public Die CreateDie(int numberOfFaces)
        {
            if (InputIsValid(numberOfFaces))
            {
                return new Die(_randomNumberGenerator, numberOfFaces);
            }
            else
            {
                throw new ArgumentException($"The number of faces '{numberOfFaces}' is invalid for creating a new Die.");
            }
        }

        private bool InputIsValid(int numberOfFaces)
        {
            if (!_useValidPolyhedralDice)
            {
                return true;
            }
            else
            {
                if (_validPolyhedralDiceFaceNumbers.Contains(numberOfFaces))
                {
                    return true;
                }

                return false;
            }
        }
    }
}
