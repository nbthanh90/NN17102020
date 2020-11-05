using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungBien
{
    class Program
    {
        static void Main(string[] args)
        {

            //string hoTen;
            //int tuoi;
            //DateTime ngaySinh;
            //double diem;
            ////Boolean 
            //bool gioiTinh;
            //char ma;
            int a, b,c;
            string banPhim;
            Console.WriteLine("Nhap So Nguyen a:");
            banPhim = Console.ReadLine();
            a = int.Parse(banPhim);
             
            Console.WriteLine("Nhap So Nguyen b:");
            banPhim = Console.ReadLine();
            b = int.Parse(banPhim);
            Console.WriteLine("Gia Tri a | b La {0} | {1}", a, b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Gia Tri a | b La {0} | {1}", a, b);


        }
    }
}
