using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorXUnit
{
    public class UserInputOutputTest
    {
        [Theory]
        [InlineData("123", 123)]
        [InlineData("0", 0)]
        [InlineData("-456", -456)]
        public void Input_ShouldReturnValidNumber(string input, int expected)
        {
            
            var inputReader = new StringReader(input);
            Console.SetIn(inputReader);

            var result = UserInputOutput.Input();

            Assert.Equal(expected, result);
        }
    }
}
