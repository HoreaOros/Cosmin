using System;
namespace Bars
{
    internal class HorzBar
    {
        private int v;

        public HorzBar(int v)
        {
            this.v = v;
            Console.Write("+");
            for (int i = 0; i < v; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

        public int Length
        {
            get
            {
                return v;
            }
            //set
            //{
            //    v = value;
            //}
        }
    }
}