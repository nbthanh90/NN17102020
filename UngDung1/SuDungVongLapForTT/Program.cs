using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungVongLapForTT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Tin ton tu 1 den N");
            //Console.WriteLine("Nhap  N");
            //int n = int.Parse(Console.ReadLine());
            //int tong = 0;
            //int i = 0;
            //for (int j = 1; j <= n; j++)
            //{
            //    tong = tong + j;
            //}

            //Console.WriteLine("Tong Tu 1 Toi {1} La: {0}", tong, n);

            //Console.WriteLine("Tinh N!");
            //Console.WriteLine("Nhap  N");
            //n = int.Parse(Console.ReadLine());
            //int giaiThua = 1;
            //for ( i = 1; i <=n; i++)
            //{
            //    //giaiThua *= i;
            //    giaiThua = giaiThua * i;
            //}
            //Console.WriteLine("N! = {0}",giaiThua);
            //Console.WriteLine("Tinh 1/n");
            //Console.WriteLine("Nhap  N");
            //n = int.Parse(Console.ReadLine());
            //double tong1 = 0.0;
            //for (i = 1; i <= n; i++)
            //{
            //    //giaiThua *= i;
            //    Console.WriteLine(i);
            //    tong1  = tong1 + 1.0/i;
            //}
            //Console.WriteLine("Ting 1/n +++ = {0}", tong1);
            Console.WriteLine("Nhap so nguyen");
            int soNguyen;
            for (; ; )
            {
                bool kt = 
             int.TryParse(Console.ReadLine(),out soNguyen);
                if (kt==true) {
                    break;
                }
                Console.WriteLine("Nhap Lai So nguyen");
            }


        }
    }
}
