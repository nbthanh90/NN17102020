using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] DSMaSinhVien = { 1, 2, 3, 3, 4, 5, 56, 67, 9 };
            string[] DSTenSinhVien = new string[9];
            for (int i = 0; i < DSMaSinhVien.Length; i++)
            {
                Console.WriteLine("Phan tu Thu {0} la {1} ", i, DSMaSinhVien[i]);
            }

            for (int i = 0; i < DSTenSinhVien.Length; i++)
            {
                Console.WriteLine("Nhap Ten SV Thu {0}", i + 1);
                DSTenSinhVien[i] = Console.ReadLine();
            }

            for (int i = 0; i < DSTenSinhVien.Length; i++)
            {
                Console.WriteLine("Nhap Ten SV Thu {0} La : {1}"
                    , i + 1
                    , DSTenSinhVien[i]
                    );
            }
            Array.Sort(DSMaSinhVien);


        }
    }
}
