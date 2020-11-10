using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class SinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public static List<SinhVien> DanhSachSinhVien;
        private static SinhVien ThongTinSinhVienSua;
        /// <summary>
        /// tìm sinh viên theo mã
        /// </summary>
        /// <param name="maSV"></param>
        /// <returns></returns>
        public static SinhVien SinhVienById(string maSV)
        {
            // var thay cho SinhVien
            foreach (var sv in DanhSachSinhVien)
            {
                if (sv.MaSV == maSV)
                    return sv;
            }
            return new SinhVien();
        }
        // gán thông tin sinh viên cần sửa
        public static void SetSinhVienSua(SinhVien svSua)
        {
            ThongTinSinhVienSua = svSua;
        }
        public static SinhVien GetSinhVienSua()
        {
            if (ThongTinSinhVienSua == null)
                return new SinhVien();
            return ThongTinSinhVienSua;
        }

        /// <summary>
        /// khởi tạo constractor SinhVien
        /// </summary>
        /// <param name="maSV"></param>
        /// <param name="tenSV"></param>
        /// <param name="sDT"></param>
        /// <param name="diaChi"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="ngaySinh"></param>
        public SinhVien(string maSV, string tenSV, string sDT, string diaChi, bool gioiTinh, DateTime ngaySinh)
        {
            MaSV = maSV;
            TenSV = tenSV;
            SDT = sDT;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
        }

        public static List<SinhVien> GetDanhSachSinhVien()
        {
            return DanhSachSinhVien;
        }

        public SinhVien()
        {
        }

        /// <summary>
        /// tuổi của sinh viên hiện tại
        /// </summary>
        /// <returns></returns>
        public int Tuoi()
        {
            // Hàm lấy năm hiện tại
            int namHienTai = DateTime.Now.Year;
            // Đây là năm sinh của sinh viên
            int namSinh = this.NgaySinh.Year;
            return namHienTai - namSinh;
        }
        public string SinhVien2String()
        {
            return string.Format(@"{0},{1},{2},{3},{4},{5}", MaSV, TenSV, SDT, DiaChi, GioiTinh, NgaySinh);
        }
        /// <summary>
        /// thêm sinh viên hiện tại vào danh sách
        /// </summary>
        public void Them()
        {
            if (DanhSachSinhVien == null)
                DanhSachSinhVien = new List<SinhVien>();
            // Cách 1 - không static - static không chơi với this
            DanhSachSinhVien.Add(this);
        }
        public static void Them(SinhVien sv)
        {
            if (DanhSachSinhVien == null)
                DanhSachSinhVien = new List<SinhVien>();
            // Cách 2 - có static
            DanhSachSinhVien.Add(sv);
        }
        public static void Xoa(string maSV)
        {
            DanhSachSinhVien.RemoveAll(sv => sv.MaSV == maSV);
        }
        /// <summary>
        /// sửa thông tin sinh viên
        /// </summary>
        /// <param name="sinhVien"></param>
        public static void Sua(SinhVien sinhVien)
        {
            Xoa(sinhVien.MaSV);
            Them(sinhVien);
        }
    }
}
