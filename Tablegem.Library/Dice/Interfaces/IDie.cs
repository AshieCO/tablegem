using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablegem.Library.Dice.Interfaces
{
    public interface IDie
    {
        public int MinimumValue { get; }
        public int MaximumValue { get; }

        /// <summary>
        /// Roll the die.
        /// </summary>
        /// <returns></returns>
        public int Roll();
    }
}
