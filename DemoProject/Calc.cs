using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class Calc
    {

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }

        public int[] FibonacciArray(int n)
        {
            if (n == 0)
            {
                return new int[0];
            }
            int number = n - 1;
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }

            return Fib;
        }


    }
}
