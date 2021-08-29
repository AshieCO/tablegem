using System;
using Tablegem.Library.Dice;
using Tablegem.Library.Services.Interfaces;
using Xunit;

namespace Tablegem.UnitTests
{
    public class DiceFactoryTests
    {
        [Fact]
        public void DiceFactory_ThrowsArgumentException_AttemptingInvalidPolyhedralDieCreation()
        {
            var testHelper = new TestHelper();
            var appSettingsJson = "{ \"UseValidPolyhedralDice\": true, \"ValidPolyhedralDiceFaceNumbers\": [ 4, 6, 8, 10, 12, 20, 100 ] }";
            var configuration = testHelper.MockConfiguration(appSettingsJson);
            IRandomNumberGenerator randomNumberGenerator = null;

            var diceFactory = new DiceFactory(configuration, randomNumberGenerator);

            Assert.Throws<ArgumentException>(() => diceFactory.CreateDie(5));
        }

        [Fact]
        public void DiceFactory_CreatesDie_AttemptingValidPolyhedralDieCreation()
        {
            var testHelper = new TestHelper();
            var appSettingsJson = "{ \"UseValidPolyhedralDice\": true, \"ValidPolyhedralDiceFaceNumbers\": [ 4, 6, 8, 10, 12, 20, 100 ] }";
            var configuration = testHelper.MockConfiguration(appSettingsJson);
            IRandomNumberGenerator randomNumberGenerator = null;

            var diceFactory = new DiceFactory(configuration, randomNumberGenerator);

            Assert.NotNull(diceFactory.CreateDie(6));
        }

        [Fact]
        public void DiceFactory_CreatesDie_AttemptingInvalidDieCreationAndValidationOff()
        {
            var testHelper = new TestHelper();
            var appSettingsJson = "{ \"UseValidPolyhedralDice\": false, \"ValidPolyhedralDiceFaceNumbers\": [ 4, 6, 8, 10, 12, 20, 100 ] }";
            var configuration = testHelper.MockConfiguration(appSettingsJson);
            IRandomNumberGenerator randomNumberGenerator = null;

            var diceFactory = new DiceFactory(configuration, randomNumberGenerator);

            Assert.NotNull(diceFactory.CreateDie(7));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-5)]
        [InlineData(-99)]
        public void DiceFactory_ThrowsArgumentException_GivenInputLessThanOneAndValidationOff(int number)
        {
            var testHelper = new TestHelper();
            var appSettingsJson = "{ \"UseValidPolyhedralDice\": false, \"ValidPolyhedralDiceFaceNumbers\": [ 4, 6, 8, 10, 12, 20, 100 ] }";
            var configuration = testHelper.MockConfiguration(appSettingsJson);
            IRandomNumberGenerator randomNumberGenerator = null;

            var diceFactory = new DiceFactory(configuration, randomNumberGenerator);

            Assert.Throws<ArgumentException>(() => diceFactory.CreateDie(number));
        }
    }
}
