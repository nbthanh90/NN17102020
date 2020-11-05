using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PTB2");
            Console.WriteLine("Nhap a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c");
            double c = double.Parse(Console.ReadLine());
           // cach 1
            double d = b * b - 4 * a * c;
            // cach 2
            d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("PTVN");
            }
            else {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Nghiem La : x1={0} x2 ={1} ",x1,x2);
            }

        }
    }
}
