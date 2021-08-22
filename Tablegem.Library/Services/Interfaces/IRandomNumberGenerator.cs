using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablegem.Library.Services.Interfaces
{
    public interface IRandomNumberGenerator
    {
        public int RandomNumber(int minimumValue, int maximumValue);
    }
}
