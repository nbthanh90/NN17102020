using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungHam
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //XinChao();
            //XinChao("Nguyen Van Teo");
            try
            {
                PhuongTrinh pt = new PhuongTrinh();
                pt.TimSoLonNhat(2, 4, 8);
                
                Menu();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        private static void Menu()
        {
            Console.WriteLine("Chon Chuong Trinh");
            Console.WriteLine("1. Giai Phuong Trinh Bac 1");
            Console.WriteLine("2. Tinh N!");
            Console.WriteLine("3. Tinh Tong Hai So Nguyen");
            Console.WriteLine("4. Giai Phuong Trinh Bac 2");

            Console.WriteLine("Chon: ");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    PhuongTrinhBac1();
                    break;
                case "2":
                    TinhGiaiThua();
                    break;
                case "3":
                    TinhTong();
                    break;
                case "4":
                    PhuongTrinhBac2();
                    break;
                case "exit":
                    return; 
            }
            // 
            Menu();
        }

        private static void PhuongTrinhBac2()
        {
            double a, b,c;
            Console.WriteLine("Nhap a");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Nhap b");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Nhap c");
            double.TryParse(Console.ReadLine(), out c);
            PhuongTrinh pt = new PhuongTrinh();

            double[] kq = pt.PhuongTrinhBac2(a, b, c);
            Console.WriteLine("Kq x1={0}, x2={1}", kq[0], kq[1]);
        }

        private static void TinhTong()
        {
            int a, b;
            Console.WriteLine("Nhap a");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Nhap b");
            int.TryParse(Console.ReadLine(), out b);

            PhuongTrinh pt = new PhuongTrinh();
            int kq = pt.Tong(a, b);
            Console
           .WriteLine("Tong {0} + {1} = {2}", a, b, kq);
        }

        private static void TinhGiaiThua()
        {
            int N;
            Console.WriteLine("Nhap N");
            int.TryParse(Console.ReadLine(), out N);
            int kq = GiaiThua(N);
            Console.WriteLine("KQ La: {0}", kq);
        }

        private static int GiaiThua(int n)
        {
            if (n == 1)
                return 1;
            return n * GiaiThua(n - 1);
        }

        private static void PhuongTrinhBac1()
        {
            double a, b;
            Console.WriteLine("Nhap a");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Nhap b");
            double.TryParse(Console.ReadLine(), out b);
            PhuongTrinh pt = new PhuongTrinh();
            double kq =  pt.PhuongTrinhBac1(a, b); 
            Console.WriteLine("Ket Qua La:{0}",kq);

        }

        private static double PhuongTrinhBac1
            (double a, double b)
        {
            if (a == 0)
                if (b == 0)
             throw new Exception("Phuong Trinh Vo So Nghiem");
                else
             throw new Exception("Phuong Trinh Vo Nghiem"); 
            return -b / a; 
        }

        private static void XinChao(string v)
        {
            Console.WriteLine("Xin chao! {0}",v);
        }

        private static void XinChao()
        {
            Console.WriteLine("Xin Chao");
        }
    }
}
