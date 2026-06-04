using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2.iterative
{
    internal class Program
    {
        static void imprimir(int M)
        {
            for (int n = 0; n < M; n++)
            {
                Console.WriteLine(n);
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor ");
            int m = Convert.ToInt32(Console.ReadLine());
            imprimir(m);
        }
    }
}
