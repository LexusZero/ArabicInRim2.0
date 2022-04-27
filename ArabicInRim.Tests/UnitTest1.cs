using Xunit;

namespace ArabicInRim.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(625, 2, 2)]
        [InlineData(12, 1, 2)]
        [InlineData(1324, 3, 3)]
        public void NumberInRazryadTest(int number, int razryad, int expectedResult)
        {
            var result = Utils.DigitInRazryad(number, razryad);
            Assert.Equal(expectedResult, result);
        }
    }
}