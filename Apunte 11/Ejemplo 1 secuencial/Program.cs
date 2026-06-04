using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1_secuencial
{
    

    internal class Program
    { static Random azar = new Random();
        static int[] vector = new int[100];
        static int contador = 0;

        static int BusquedaSecuencial ( int valor)
        {
            int idxBus = -1, idx = 0;
            while (idxBus == -1 && idx < contador)
            {
                if (valor == vector[idx])
                {
                    idxBus = idx;
                }
                else
                { idx++; }
            }
            return idx;
            }


        static void Main(string[] args)
        {
            int valorBuscado = 14;
            for (int n = 0; n < 60; n++)
            {
                int valor = azar.Next(23);
                vector[contador] = valor;
                contador++;
            }
            int idxBuscado= BusquedaSecuencial(valorBuscado);
            if (idxBuscado != -1)
            {
                Console.WriteLine($"Lo encontro: {vector[idxBuscado]}");
            }
            else
            { 
               Console.WriteLine("No lo encontro ");
            }
            Console.ReadKey();
                    
        }
    }
}
