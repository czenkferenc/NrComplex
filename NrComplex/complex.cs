using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrComplex
{
    class complex
    {
        protected double a, b;
        protected complexTrigForm t = new complexTrigForm();

        public complex() : base()
        {
            a = 0; b = 0;
        }

        public complex(double a)
        {
            this.a = a;
        }

        public complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Real
        {
            get { return a; }
        }

        public double Imaginary
        {
            get { return b; }
        }

        public complexTrigForm TrigForm
        {
            get { return t; }
        }

        public static complex operator + (complex x, complex y)
        {
            complex s = new complex();
            s.a = x.a + y.a;
            s.b = x.b + y.b;
            return s;
        }

        public static complex operator - (complex x, complex y)
        {
            complex s = new complex();
            s.a = x.a - y.a;
            s.b = x.b - y.b;
            return s;
        }

        public static complex operator * (complex x, complex y)
        {
            complex p = new complex();
            p.a = x.a * y.a - x.b * y.b;
            p.b = x.a * y.b + x.b * y.a;
            return p;
        }

        public static complex operator ^ (complex x, int pow)
        {
            complex p = new complex();
            p = x;
            for (int i = 1; i < pow; i++)
            {
                p *= x;
            }
            return p;
        }

        public override string ToString()
        {
            string nr;
            if (a != 0 || b != 0)
            {
                if (a != 0) nr = a.ToString();
                else nr = "";
                if (b > 0 && a != 0) nr = nr + "+" + b.ToString() + "i";
                else if (b > 0 && a == 0) nr = b.ToString() + "i";
                else if (b < 0) nr = nr + b.ToString() + "i";
                else nr = nr + "";
                if(t.R != 0)
                {
                    nr = nr + "\n" + t.R.ToString() + "(cos(" + t.Teta.ToString() + ") + i*sin(" + t.Teta.ToString() + "))";
                }
            }
            else nr = "0";

            return nr;
        }

        public virtual complex power(complex x, int pow)
        {
            complex p = new complex();
            p = x;
            for (int i = 1; i < pow; i++)
            {
                p *= x;
            }
            return p;
        }

        public void setTrigForm(complexTrigForm t)
        {
            this.t.R = t.R;
            this.t.Teta = t.Teta;
        }

        public string trigForm() // forma trigonometrica
        {
            string nr;
            double r = Math.Sqrt(a * a + b * b);
            double teta = Math.Atan2(b, a);
            nr = r.ToString() + "(cos(" + teta.ToString() + ") + i*sin(" + teta.ToString() + "))";
            return nr;
        }

        public string trigForm(int n) // forma trigonometrica x^n
        {
            string nr;
            double r = Math.Sqrt(a * a + b * b);
            double teta = Math.Atan2(b, a);
            nr =n.ToString() + "*" + r.ToString() + "("+ n.ToString() + "*" + "cos(" + teta.ToString() + ")"+ n.ToString() + "*" + " i*sin(" + teta.ToString() + "))";
            return nr;
        }

        public string trigForm(int n, bool calculate) // forma trigonometrica x^n calculata cu sau fara schimbarea valorii 
        {
            if (calculate == false)
            {
                //nu schimba valorea 
                double ta = a;
                double tb = b;
                complex c = new complex(a, b);
                c = c ^ n;
                a = c.Real;
                b = c.Imaginary;
                string nr;
                double r = Math.Sqrt(a * a + b * b);
                double teta = Math.Atan2(b, a);
                nr = r.ToString() + "(cos(" + teta.ToString() + ") + i*sin(" + teta.ToString() + "))";
                a = ta;
                b = tb;
                return nr;
            }
            else
            {
                //schimba valoarea
                double ta = a;
                double tb = b;
                complex c = new complex(a, b);
                c = c ^ n;
                a = c.Real;
                b = c.Imaginary;
                string nr;
                double r = Math.Sqrt(a * a + b * b);
                double teta = Math.Atan2(b, a);
                nr = r.ToString() + "(cos(" + teta.ToString() + ") + i*sin(" + teta.ToString() + "))";
                return nr;
            }
        }
    }
}
