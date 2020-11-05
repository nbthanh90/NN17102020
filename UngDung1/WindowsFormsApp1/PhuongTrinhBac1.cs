using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PhuongTrinhBac1
    {
        public double a { get; set; }
        public double b { get; set; }
        public double x { get; set; }

        public double Giai()
        {
            if (a == 0)
                if (b == 0)
                    throw new Exception("Pt Vo So nghiem");
                else
                    throw new Exception("Pt Vo nghiem");
            x = -b / a;
            return -this.b / this.a;
        }
    }
}
