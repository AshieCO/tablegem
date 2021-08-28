using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tablegem.Library.Dice;
using Tablegem.Library.Services;
using Xunit;

namespace Tablegem.UnitTests
{
    public class DiceFactoryTests
    {
        [Fact]
        public void DiceFactory_ThrowsArgumentException_WhenAttemptingInvalidDieCreation()
        {
            var appSettingsJson = "{ \"UseValidPolyhedralDice\": true, \"ValidPolyhedralDiceFaceNumbers\": [ 4, 6, 8, 10, 12, 20, 100 ] }";
            var configuration = MockConfiguration(appSettingsJson);
            var randomNumberGenerator = new RandomNumberGenerator();

            var diceFactory = new DiceFactory(configuration, randomNumberGenerator);

            Assert.Throws<ArgumentException>(() => diceFactory.CreateDie(5));
        }

        [Fact]
        public void DiceFactory_CreatesDie_WhenAttemptingValidDieCreation()
        {
            var appSettingsJson = "{ \"UseValidPolyhedralDice\": true, \"ValidPolyhedralDiceFaceNumbers\": [ 4, 6, 8, 10, 12, 20, 100 ] }";
            var configuration = MockConfiguration(appSettingsJson);
            var randomNumberGenerator = new RandomNumberGenerator();

            var diceFactory = new DiceFactory(configuration, randomNumberGenerator);

            Assert.NotNull(diceFactory.CreateDie(6));
        }

        [Fact]
        public void DiceFactory_DoesNotThrowArgumentException_WhenValidDiceFalseWhileAttemptingOddDieCreation()
        {
            var appSettingsJson = "{ \"UseValidPolyhedralDice\": false, \"ValidPolyhedralDiceFaceNumbers\": [ 4, 6, 8, 10, 12, 20, 100 ] }";
            var configuration = MockConfiguration(appSettingsJson);
            var randomNumberGenerator = new RandomNumberGenerator();

            var diceFactory = new DiceFactory(configuration, randomNumberGenerator);

            Assert.NotNull(diceFactory.CreateDie(7));
        }

        private IConfiguration MockConfiguration(string mockJsonFile)
        {
            return new ConfigurationBuilder().AddJsonStream(new MemoryStream(Encoding.ASCII.GetBytes(mockJsonFile))).Build();
        }
    }
}
