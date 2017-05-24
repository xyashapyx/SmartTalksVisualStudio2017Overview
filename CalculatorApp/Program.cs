using CalculatorApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var multithreadingService = new MultithreadingService();
            Task.Run(()=>multithreadingService.WriteEvenNumbers("First",100));
            Task.Run(() => multithreadingService.WriteEvenNumbers("Second",100));
            Console.Read();
        }
    }
}
