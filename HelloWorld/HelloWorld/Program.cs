using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("Hello World");

            int a, b;
            string line;

            line = Console.ReadLine();
            a = int.Parse(line);

            line = Console.ReadLine();
            b = int.Parse(line);

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);

            ProcesareNumere();

            Console.ReadKey(true);
        }

        private static void ProcesareNumere()
        {
            Console.WriteLine("Introduceti numarul de numere ");
            string line;
            int n;
            line = Console.ReadLine();
            n = int.Parse(line);

            int[] numere = new int[n];

            Console.WriteLine("Introduceti numerele ");
            for (int i = 0; i < numere.Length; i++)
            {
                line = Console.ReadLine();
                numere[i] = int.Parse(line);
            }
            int suma = 0;
            foreach (int item in numere)
            {
                suma += item;
            }
            Console.WriteLine("Suma numerelor introduse este {0}", suma);
        }
    }
}
