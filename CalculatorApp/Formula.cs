using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{

    public delegate double GetAnswer(double x, double y);

    class Formula
    {
        public static double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double GetQuotient(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
