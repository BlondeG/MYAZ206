using Xunit;

namespace TheLimitOfDataTypes
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            byte minValue;
            byte maxValue;

            //Act
            minValue = 0;
            maxValue = 255;

            //Assert
            Assert.Equal(minValue, byte.MaxValue);
            Assert.Equal(maxValue, byte.MinValue);


        }
    }
}