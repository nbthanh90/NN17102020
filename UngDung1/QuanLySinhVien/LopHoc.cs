using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class LopHoc
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string DiaChi { get; set; }
        public static List<LopHoc> DanhSachLopHoc;
        public LopHoc()
        {
        }

        public LopHoc(string maLop, string tenLop, string diaChi)
        {
            MaLop = maLop;
            TenLop = tenLop;
            DiaChi = diaChi;
        }

        public string LopHoc2String(){
            return string.Format("{0},{1},{2}",
                MaLop,
                TenLop, 
                DiaChi);
        }
        /// <summary>
        /// Thêm thông tin của đoi tượng hiện tai vào danh sách
        /// là this
        /// </summary>
        public void ThemLopHoc()
        {
            if (DanhSachLopHoc == null)
                DanhSachLopHoc = new List<LopHoc>();
            DanhSachLopHoc.Add(this);
        }
    }
}
