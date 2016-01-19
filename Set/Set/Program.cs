using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetN
{
    class Program
    {
        static void Main(string[] args)
        {
            Set s = new Set();
            Set s2 = new Set(32);
            s.Add(1);
            s.Add(2);
            s.Add(1);
            s.Add(7);
            s.Add(10);
            Console.WriteLine("Multimea s contine {0} elemente", s.Size);

            int[] v = { 1, 3, 2, 5, 3 };
            Set s3 = new Set(v);
            Console.WriteLine("Multimea s3 contine {0} elemente", s3.Size);
            s3.Print();

            s = s.Intersect(s3);
            s.Print();
        }
    }
}
