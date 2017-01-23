using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Complex
    {
        int a, b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(0,0);
            c3.a = c1.a + c2.a;
            c3.b = c1.b + c2.b;
            return c3;
        }

        public override string ToString()
        {
            return string.Format("{0}+{1}i", a, b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(5, 6);
            Complex c2 = new Complex(8, 1);

            Console.WriteLine(c1 + c2);
        }
    }
}
