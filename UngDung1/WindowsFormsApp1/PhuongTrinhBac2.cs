using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PhuongTrinhBac2
    {
        public PhuongTrinhBac2(double soa, double sob, double soc)
        {
            this.a = soa;
            this.b = sob;
            this.c = soc;
        }

        public double a { get; set; }

        public double b { get; set; }
        public double c { get; set; }
        public double x1 { get; set; }
        public double x2 { get; set; }

        public void Giai()
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
                throw new Exception("Pt Vo Nghiem");
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);

        }

    }
}
