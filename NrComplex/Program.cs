using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            complex c1 = new complex();
            complex c2 = new complex(2,3);
            complex c3 = new complex(4,5);
            complex c4 = new complex(0,-2);
            complex c5 = new complex(2);

            //testa afisare
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());
            Console.WriteLine(c4.ToString());
            Console.WriteLine(c5.ToString());
            Console.WriteLine();

            //test calcule 
            c1 = c2 + c3;
            Console.WriteLine(c1.ToString());
            c1 = c2 - c3;
            Console.WriteLine(c1.ToString());
            c1 = c2 * c3;
            Console.WriteLine(c1.ToString());
            c1 = c3 ^ 3;
            Console.WriteLine(c1.ToString());
            Console.WriteLine();

            Console.WriteLine(c1.trigForm()); // forma trigonometrica
            Console.WriteLine(c3.trigForm(3)); // forma trigonometrica x^n
            Console.WriteLine(c3.trigForm(3, false)); // forma trigonometrica x^n calculata cu sau fara schimbarea valorii
            Console.WriteLine(c3.ToString());
            Console.WriteLine(c3.trigForm(3, true)); // forma trigonometrica x^n calculata cu sau fara schimbarea valorii
            Console.WriteLine(c3.ToString());
            Console.WriteLine();
           
        }
    }
}
