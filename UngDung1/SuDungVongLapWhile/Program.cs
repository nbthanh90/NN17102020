using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungVongLapWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UCLN
            //// nhap a 
            //int a;
            //Console.WriteLine("Nhap A");
            //int.TryParse(Console.ReadLine(), out a);
            //// nhap b
            //int b;
            //Console.WriteLine("Nhap B");
            //int.TryParse(Console.ReadLine(), out b);
            //// cả hai so khong có so nào bằng 0
            //while (a*b > 0)
            //{
            //    Console.WriteLine("a= {0} b = {1}", a, b);
            //    if (a > b)
            //        a = a % b;
            //    else
            //        b = b % a;

            //}
            //Console.WriteLine("UCLN la: {0}",a+b);
            #endregion
            #region Xac Dinh So Nguyen To
            // nhap a
            //Console.WriteLine("nhap So nguyen Duong");
            //int n;
            //int.TryParse(Console.ReadLine(), out n);
            //int i = 2;
            //while (i <= n) {
            //    if (n%i==0)
            //    {
            //        if (n == i)
            //            Console.WriteLine("La NT");
            //        else
            //            Console.WriteLine("Khong Phai La NT");
            //        break;
            //    }
            //    i++;
            //}


            #endregion

            #region Do-while
            int b;
            bool kt;
            do
            {
                Console.WriteLine("Nhap So Nguyen Duong");
                 kt = int.TryParse(Console.ReadLine(), out b);
                // kt da la so nguyen
                if (kt == true)
                {
                    if (b <= 0)
                        kt = false;
                }
                 
            } while (kt==false);


            #endregion

        }

    }
}
