using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorXUnit
{
    public class HistoryTest
    {
        [Fact]
        public void Log_ShouldAddEntryToLogs()
        {
            
            History.logs.Clear();

            int a = 10;
            string x = "+";
            int b = 20;
            int c = 30;
            
            History.Log(a, x, b, c);

            Assert.Single(History.logs);
            var log = History.logs[0];
            Assert.Equal((a, x, b, c), log);
        }
    }
}
