using Calculator;
using Moq;

namespace CalculatorXUnit
{
    public class CalculatorFunctionsTest
    {
        
        [Fact]
        public void Add_50_And_50_Return_100()
        {
            
            var actual = CalculatorFunctions.Addition(50,50);

            var expected = 100;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50,20, 1000)]
        [InlineData(345,4, 1380)]
        [InlineData(0, 3, 0)]
        [InlineData(-2, 6, -12)]
        [InlineData(-10, -10, 100)]
        public void Multiply_Test(int value1, int value2, int expected)
        {
            var actual = CalculatorFunctions.Multiplication(value1, value2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50, 10, 5)]
        [InlineData(345, 5, 69)]
        [InlineData(7, 0, 0)]
        [InlineData(10, 2, 5)]
        [InlineData(-10, -5, 2)]
        public void Division_Test(int value1, int value2, int expected)
        {
            var actual = CalculatorFunctions.Division(value1, value2);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(50, 20, 30)]
        [InlineData(345, 4, 341)]
        [InlineData(0, 3, -3)]
        [InlineData(-2, 6, -8)]
        [InlineData(-10, -10, 0)]
        public void Subtraction_Test(int value1, int value2, int expected)
        {
            var actual = CalculatorFunctions.Subtraction(value1, value2);
            Assert.Equal(expected, actual);
        }
    }
}