using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            //lay 1 so ngau nhien 0 - 9
            Console.WriteLine(a.Next(0, 9));
            Console.WriteLine("Nhap 1 So bat ky");
            int kq = a.Next(0, 9);
            Console.WriteLine(kq);
            // nhap du doan
            int duDoan = int.Parse(Console.ReadLine());
            // so sanh
            if (duDoan == kq)
            {
                Console.WriteLine("Bna da doan Dung");
            }
            else {
                Console.WriteLine("Bna da doan Sai");
            }
        }
    }
}
