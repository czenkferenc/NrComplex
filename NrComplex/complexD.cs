using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrComplex
{
    class complexD: complex
    {
        public double distance(complex a, complex[] b)
        {
            double distance = double.MaxValue; ;
            for (int i = 0; i < b.Length; i++)
            {
                double temp = (a.Real * a.Real - b[i].Real * b[i].Real) + (a.Imaginary * a.Imaginary - b[i].Imaginary * b[i].Imaginary);
                if (temp < 0) temp *= -1;
                temp = Math.Sqrt(temp);
                if (temp < distance )
                {
                    distance = temp;
                    Console.WriteLine("a");
                }
            }
            return distance;
        }

        public override complex power(complex x,int n)
        {
            x = x ^ n;
            double r = Math.Sqrt(x.Real * x.Real + x.Imaginary * x.Imaginary);
            double teta = Math.Atan2(x.Imaginary, x.Real);
            complex nr = x;
            complexTrigForm t = new complexTrigForm(r, teta);
            nr.setTrigForm(t);
            return nr;
        }
    }
}
