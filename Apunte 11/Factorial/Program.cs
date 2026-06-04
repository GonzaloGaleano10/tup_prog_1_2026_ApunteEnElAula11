using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    { static int factorial ( int M)
        {
             int m  = 1;
            if (M > 0)
            {
                m = M * factorial(M - 1);
            }
            return m;

        }
        static void Main(string[] args)
        {
            int m = 3;
            int mf =factorial(m);
            Console.WriteLine($"{m}! = {mf}");
            Console.ReadKey();
        }
    }
}
