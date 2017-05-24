using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Service
{
    public static class CalculatorService
    {
        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Pow(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
