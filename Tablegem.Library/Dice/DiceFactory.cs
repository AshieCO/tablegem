using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tablegem.Library.Dice.Interfaces;

namespace Tablegem.Library.Dice
{
    public class DiceFactory : IDiceFactory
    {
        public Die CreateDie(int numberOfFaces)
        {
            throw new NotImplementedException("also implement configuration and/or validation?");
        }
    }
}
