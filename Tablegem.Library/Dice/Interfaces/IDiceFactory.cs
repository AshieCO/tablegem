using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablegem.Library.Dice.Interfaces
{
    public interface IDiceFactory
    {
        public Die CreateDie(int numberOfFaces);
    }
}
