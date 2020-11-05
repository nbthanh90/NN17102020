using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PTB1");
            Console.WriteLine("Nhap So a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap So b");
            double b = double.Parse(Console.ReadLine());
            // voi a = 0 
            if (a == 0)
            {
                // kiem tra b = 0?
                if (b == 0)
                {
                    //b==0
                    Console.WriteLine("PTVSN");
                }
                else
                {
                    // b != 0
                    Console.WriteLine("PTVSN");
                }

            }
            else
            {
                // voi a != 0
                Console.WriteLine("X = {0}", -b / a);


            }



        }
    }
}
