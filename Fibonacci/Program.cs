using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val;
            Console.WriteLine("Intoduce el valor");
            val = int.Parse(Console.ReadLine());

            int[] arreglo = new int[val];
            arreglo[0] = 0;
            arreglo[1] = 1;

            for (int i = 2; i < val; i++)
            {
                arreglo[i] = arreglo[i - 1] + arreglo[i - 2];
            }
            Console.WriteLine(string.Join(",",arreglo));
            Console.ReadKey();

        }
    }
}
