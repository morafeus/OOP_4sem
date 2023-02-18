using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public static class Calculator
    {
        public static Stack<int> memory = new Stack<int>(3);

        public static int Sum(int first, int second)
        {
            return first + second;
        }

        public static int Minus(int first, int second)
        {
            return first - second;
        }

        public static int Mult(int first, int second)
        {
            return first * second;
        }

        public static int MainDiv(int first, int second)
        {
            double buf = first / second - first % second * 0.1;
            return System.Convert.ToInt32(buf);
        }

        public static int Residual(int first, int second)
        {
            return first % second;
        }
    }
}
