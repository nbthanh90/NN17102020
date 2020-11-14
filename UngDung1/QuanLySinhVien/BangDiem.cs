using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    // class BangDiem : SinhVien -> class BangDiem thừa kế từ class SinhVien
    class BangDiem
    {
        public string MaSV { get; set; }
        public string MaLop { get; set; }
        public double MonToan { get; set; }
        public double MonLy { get; set; }
        public double MonHoa { get; set; }
        public static List<BangDiem> DanhSachBangDiem { get; set; }

        public BangDiem(string maSV, string maLop, double monToan, double monLy, double monHoa)
        {
            MaSV = maSV;
            MaLop = maLop;
            MonToan = monToan;
            MonLy = monLy;
            MonHoa = monHoa;
        }

        public BangDiem()
        {
        }

        public static void Them(BangDiem bd)
        {
            if (DanhSachBangDiem == null)
                DanhSachBangDiem = new List<BangDiem>();
            DanhSachBangDiem.Add(bd);
        }
        public static void Sua(BangDiem bd)
        {
            Xoa(bd.MaLop, bd.MaSV);
            Them(bd);
        }
        public static void Xoa(string maLop, string maSinhVien)
        {
            // item là obj đại diện cho dòng
            DanhSachBangDiem.RemoveAll(item => item.MaSV == maSinhVien && item.MaLop == maLop);
        }
        /// <summary>
        /// lấy danh sách bảng điểm
        /// </summary>
        /// <returns></returns>
        public static List<BangDiem> GetDanhSachBangDiem()
        {
            if (DanhSachBangDiem == null)
                return new List<BangDiem>();
            return DanhSachBangDiem;
        }

        public static BangDiem BangDiemByMaSVMaLop(string maSV, string maLop)
        {
            foreach (var item in DanhSachBangDiem)
            {
                if (item.MaLop == maLop && item.MaSV == maSV)
                {
                    return item;
                }
            }
            return new BangDiem();
        }
    }
}
