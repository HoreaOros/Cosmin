using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars
{
    class Program
    {
        static void Main(string[] args)
        {
            HorzBar h = new HorzBar(4);
            VertBar v = new VertBar(3);
            Frame f = new Frame(3, 2);
            Ladder d = new Ladder(10, 2, 3);
            
            Console.WriteLine("lungimea lui h este {0}", h.Length);
        }
    }
}
