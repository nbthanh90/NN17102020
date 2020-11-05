using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XacDinhChanLe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int a;
            string KetQua;
            Console.WriteLine("Nhập số nguyên a");
            a = int.Parse(Console.ReadLine());
            KetQua = (a % 2 == 0) ? "Số chẵn!" : "Số lẻ!";
            Console.WriteLine("{0} là {1}", a, KetQua);
            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("So chan");
            //}
            //else {
            //    Console.WriteLine("So le");
            //}
            //if (a%2 ==0)
            //    Console.WriteLine("So chan");
            //else
            //    Console.WriteLine("So Le");

            //double diem;
            //Console.WriteLine("nhap diem");
            //diem = double.Parse(Console.ReadLine());
            //if (diem < 4)
            //{
            //    Console.WriteLine("yeu");
            //}
            //else if (diem < 6.5)
            //{
            //    Console.WriteLine("Tb");
            //}
            //else if (diem < 7.5)
            //{
            //    Console.WriteLine("Kha");
            //}
            //else {
            //    Console.WriteLine("Gioi");
            //}
            
        }
    }
}
