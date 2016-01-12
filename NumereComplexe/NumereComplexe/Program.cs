using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumereComplexe
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(1, 2);
            Complex c3 = new Complex();

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Complex c4 = c1.Add(c2);
            Console.WriteLine(c4);

            Complex c5 = c2.Subtract(c1);
            Console.WriteLine(c5);

            Complex c6 = c1.Multiply(c2);
            Console.WriteLine(c6);

                      
            if(c1.Equals(c2))
                Console.WriteLine("c1 este egal cu c2");
            else
                Console.WriteLine("c1 nu este egal cu c2");

        }
    }
}
