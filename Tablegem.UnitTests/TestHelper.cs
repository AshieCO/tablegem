using Microsoft.Extensions.Configuration;
using System.IO;
using System.Text;

namespace Tablegem.UnitTests
{
    public class TestHelper
    {
        public IConfiguration MockConfiguration(string mockJsonFile)
        {
            return new ConfigurationBuilder().AddJsonStream(new MemoryStream(Encoding.ASCII.GetBytes(mockJsonFile))).Build();
        }
    }
}
