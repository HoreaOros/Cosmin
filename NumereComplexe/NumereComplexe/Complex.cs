using System;

namespace NumereComplexe
{
    internal class Complex
    {
        private int re;
        private int im;

        public Complex(int v1, int v2)
        {
            re = v1;
            im = v2;
        }

        public Complex()
        {
            re = im = 0;
        }
        public override string ToString()
        {
            return re.ToString() + ((im > 0)?"+":"") + im.ToString() + "i";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Complex))
                return false;
            if (re == ((Complex)obj).re && im == ((Complex)obj).im)
                return true;
            else
                return false;

        }

        public Complex Add(Complex c2)
        {
            Complex c = new Complex();
            c.re = re + c2.re;
            c.im = im + c2.im;
            return c;
        }

        public Complex Subtract(Complex c2)
        {
            Complex c = new Complex();
            c.re = re - c2.re;
            c.im = im - c2.im;
            return c;
        }

        public Complex Multiply(Complex c2)
        {
            Complex c = new Complex();
            c.re = re * c2.re - im * c2.im;
            c.im = re * c2.im + im * c2.re;
            return c;
        }
    }
}