using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungHam
{
    class PhuongTrinh
    {
        /// <summary>
        /// tinh tong hai so nguyen
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Tong(int a, int b) {
            return a + b;
        }

        public int TimSoLonNhat(int v1, int v2, int v3)
        {
            int max = v1;
            if (max < v2)
                max = v2;
            if (max < v3)
                max = v3;
            return max;
        }

        public int Hieu(int a, int b)
        {
            return a - b;
        }
        public int Tich(int a, int b)
        {
            return a * b;
        }
        public double Thuong(int a, int b)
        {
            return a / b;
        }

        public double PhuongTrinhBac1(double a, double b)
        {
            if (a == 0)
                if (b == 0)
                    throw new Exception("Phuong Trinh Vo So Nghiem");
                else
                    throw new Exception("Phuong Trinh Vo Nghiem");
            return -b / a;
        }

      public double[] PhuongTrinhBac2(double a, double b, double c)
        {
            if (a == 0)
                throw new Exception("Khong Phai Phuong Bac 2");
            double d = Math.Pow(b, 2) - 4 * a * c;
            if(d<0)
                throw new Exception("Phuong Trinh Vo nghiem");
            double[] nghiem = new double[2];
            nghiem[0] = (-b + Math.Sqrt(d)) / (2 * a);
            nghiem[1] = (-b - Math.Sqrt(d)) / (2 * a);
            return nghiem;
        }
    }
}
