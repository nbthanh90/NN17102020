using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XacDinhNgayCuaThang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Thang");
            int thang = int.Parse(Console.ReadLine());
            if (thang == 2)
            {
                // la thang 2
                Console.WriteLine("Nhap Nam");
                int nam = int.Parse(Console.ReadLine());
                if (nam % 4 == 0 && nam % 100 > 0)
                {
                    Console.WriteLine("29");
                }
                else
                {
                    Console.WriteLine("28");
                }

            }
            else {
                // các thang con lai
                switch (thang)
                {
                    case 1: Console.WriteLine(31);
                        break;
                    case 3:
                        Console.WriteLine(31);
                        break;
                    case 4:
                        Console.WriteLine(30);
                        break;
                    case 5:
                        Console.WriteLine(31);
                        break;
                    case 6:
                        Console.WriteLine(30);
                        break;
                    case 7:
                        Console.WriteLine(31);
                        break;
                    case 8:
                        Console.WriteLine(31);
                        break;
                    case 9:
                        Console.WriteLine(30);
                        break;
                    case 10:
                        Console.WriteLine(31);
                        break;
                    case 11:
                        Console.WriteLine(30);
                        break;
                    case 12:
                        Console.WriteLine(31);
                        break;
                    default:
                        Console.WriteLine("khong Phai Thang");
                        break;

                }

            } 
            // Xac Dinh Mua Cua Thang
            switch (thang)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Xuan");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Ha");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Thu");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Dong");
                    break;
            }





        }
    }
}
