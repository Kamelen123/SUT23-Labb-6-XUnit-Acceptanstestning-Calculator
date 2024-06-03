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
        [Fact]
        public void User_ShouldBeAbleToPerformSubtractionAndViewLogs()
        {
            
            var inputReader = new StringReader("2\n30\n15\n5\n7\n");
            var outputWriter = new StringWriter();
            Console.SetIn(inputReader);
            Console.SetOut(outputWriter);
            
            UserInputOutput.Menu();
            
            var output = outputWriter.ToString();
            Assert.Contains("30 - 15 = 15", output);
            Assert.Contains("Logs:", output);
            Assert.Contains("30 - 15 = 15", output);
        }
        [Fact]
        public void User_ShouldBeAbleToExit()
        {
            
            var inputReader = new StringReader("7\n");
            var outputWriter = new StringWriter();
            Console.SetIn(inputReader);
            Console.SetOut(outputWriter);

            UserInputOutput.Menu();

            var output = outputWriter.ToString();
            Assert.DoesNotContain("Enter a valid number 1-7", output);
        }
        [Fact]
        public void User_ShouldBeAbleToViewLogs()
        {
            
            var inputReader = new StringReader("1\n10\n20\n5\n7\n");
            var outputWriter = new StringWriter();
            Console.SetIn(inputReader);
            Console.SetOut(outputWriter);
            
            UserInputOutput.Menu();
            
            var output = outputWriter.ToString();
            Assert.Contains("Logs:", output);
            Assert.Contains("10 + 20 = 30", output);
        }
    }
}
