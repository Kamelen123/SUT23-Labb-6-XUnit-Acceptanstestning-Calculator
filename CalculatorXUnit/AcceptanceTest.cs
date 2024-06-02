using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorXUnit
{
    public class AcceptanceTest
    {
        [Fact]
        public void User_AcceptenceTest()
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
    }
}
