using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungVongLapFor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Van lap can ban
            //i++  <=> i = i+1
            // cach 1
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Xin Chao");

            }
            //canh 2 ======
            for (int i = 0; i < 100; i++)
                if (i % 2 == 0)
                    Console.WriteLine("{0} Xin Chao {0}", i);
            //canh 2 ======
            #endregion

            #region Lap cac so tu 0 toi n
            Console.WriteLine("Nhap So Nguyen Duong N");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("So {0}", i);

            }
            for (int index = 0; index <= n; index++)
            {
                if (index % 2 == 0)
                    Console.WriteLine("So {0}", index);
            }
            #endregion
            #region Bang cuu chuong
            for (int i = 2; i <=9; i++)
            {
                Console.WriteLine("{0} x 2 = {1}", i, i * 2);
                Console.WriteLine("{0} x 3 = {1}", i, i * 3);
                Console.WriteLine("{0} x 4 = {1}", i, i * 4);
                Console.WriteLine("{0} x 5 = {1}", i, i * 5);
                Console.WriteLine("{0} x 6 = {1}", i, i * 6);
                Console.WriteLine("{0} x 7 = {1}", i, i * 7);
                Console.WriteLine("{0} x 8 = {1}", i, i * 8);
                Console.WriteLine("{0} x 9 = {1}", i, i * 9);
                Console.WriteLine("{0} x 10 = {1}", i, i * 10);
            }

            for (int i = 2; i <= 9; i++)
            {
                for (int j = 2; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {2} = {1}", i, i * j,j);
                }
            }

            #endregion


        }

    }
}
