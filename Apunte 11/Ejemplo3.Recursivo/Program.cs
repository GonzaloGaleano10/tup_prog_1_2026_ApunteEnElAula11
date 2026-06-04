using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3.Recursivo
{
    internal class Program
    {
        static void imprimirM( int m )
        { 
            if ( m > 0)
            {
                imprimirM(m - 1);

            }
            else
            {
                Console.WriteLine(m);

            }
        }
        static void Main(string[] args)
        {
            int m = 30;
            imprimirM(m);
        }
    }
}
