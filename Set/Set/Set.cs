using System;

namespace SetN
{
    internal class Set
    {
        private int[] v;
        private int capacity = 16;
        private int count = 0;
        

        public Set()
        {
            v = new int[capacity];
        }

        public Set(int v1)
        {
            this.capacity = v1;
            v = new int[capacity];
        }

        public Set(int[] s)
        {
            v = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                Add(s[i]);
            }
        }

        public void Add(int item)
        {
            for (int i = 0; i < count; i++)
            {
                if (v[i] == item)
                    return;
            }

            if (count == capacity)
                resize(capacity * 2);
            v[count++] = item;
        }

        public Set Intersect(Set s3)
        {
            Set s = new Set();
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < s3.Size; j++)
                {
                    if (v[i] == s3.v[j])
                    {
                        s.Add(v[i]);
                        break;
                    }
                }
            }
            return s;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0} ", v[i]);
            }
            Console.WriteLine();
        }

        private void resize(int n)
        {
            int[] aux = new int[n];
            for (int i = 0; i < v.Length; i++)
            {
                aux[i] = v[i];
            }
            v = aux;
        }
        public int Size
        {
            get
            {
                return count;
            }
        }
    }
}