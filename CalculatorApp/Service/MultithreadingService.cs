using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Service
{
    public class MultithreadingService
    {
        public async Task WriteEvenNumbers(string threadName, int lastNumber)
        {
            for (int i = 0; i < lastNumber; i++)
            {
                if (i % 2 == 0)
                {
                    await Task.Run(() => Console.WriteLine($"Thread name:{threadName}, i:{i}"));
                }
            }
        }
    }
}
