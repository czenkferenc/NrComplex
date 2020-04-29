using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrComplex
{
    class complexTrigForm
    {
        protected double r;
        protected double teta; 
        
        public complexTrigForm() : base()
        {
            this.r = 0;
            this.teta = 0;
        }
        
        public complexTrigForm(complex c)
        {
            this.r = Math.Sqrt(c.Real * c.Real + c.Imaginary * c.Imaginary);
            this.teta = Math.Atan2(c.Imaginary, c.Real);
        }

        public complexTrigForm(double r, double teta)
        {
            this.r = r;
            this.teta = teta;
        }

        public double R
        {
            get { return r; }
            set { r = value; }
        }

        public double Teta
        {
            get { return teta; }
            set { teta = value; }
        }

        
    }
}
