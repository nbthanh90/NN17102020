using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConnectDB;

namespace QuanLySinhVien
{
    class SinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public static List<SinhVien> DanhSachSinhVien;
        private static SinhVien ThongTinSinhVienSua;
        /// <summary>
        /// tìm sinh viên theo mã
        /// </summary>
        /// <param name="maSV"></param>
        /// <returns></returns>
        public static SinhVien SinhVienById(string maSV)
        {
            string sql = @"SELECT * FROM tblSinhVien WHERE MaSV = '{0}'";
            ConnectDB cdb = new ConnectDB();
            SqlDataReader res = cdb.SelectQuery(string.Format(sql, maSV));
            res.Read();
            string tenSV = res.GetValue(1).ToString().Trim();
            string diaChi = res.GetValue(2).ToString().Trim();
            string sDT = res.GetValue(3).ToString().Trim();
            string ngaySinh = res.GetValue(4).ToString().Trim();
            string gioiTinh = res.GetValue(5).ToString().Trim();
            SinhVien sv = new SinhVien(maSV, tenSV, sDT, diaChi, DateTime.Parse(ngaySinh), Boolean.Parse(gioiTinh));
            return sv;
            // var thay cho SinhVien
            //foreach (var sv in DanhSachSinhVien)
            //{
            //    if (sv.MaSV == maSV)
            //        return sv;
            //}

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
        public SinhVien(string maSV, string tenSV, string diaChi, string sDT, DateTime ngaySinh, bool gioiTinh)
        {
            MaSV = maSV;
            TenSV = tenSV;
            DiaChi = diaChi;
            SDT = sDT;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
        }

        public static List<SinhVien> GetDanhSachSinhVien()
        {
            ConnectDB cdb = new ConnectDB();
            SqlDataReader res = cdb.SelectQuery("SELECT * FROM tblSinhVien");
            List<SinhVien> lsv = new List<SinhVien>();
            while (res.Read())
            {
                string maSV = res.GetValue(0).ToString().Trim();
                string tenSV = res.GetValue(1).ToString().Trim();
                string diaChi = res.GetValue(2).ToString().Trim();
                string sDT = res.GetValue(3).ToString().Trim();
                string ngaySinh = res.GetValue(4).ToString().Trim();
                string gioiTinh = res.GetValue(5).ToString().Trim();
                SinhVien sv = new SinhVien(maSV, tenSV, sDT, diaChi, DateTime.Parse(ngaySinh), Boolean.Parse(gioiTinh));
                lsv.Add(sv);
            }
            return lsv;

            //if (DanhSachSinhVien == null)
            //    return new List<SinhVien>();
            //return DanhSachSinhVien;
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
            return string.Format("{0},{1},{2},{3},{4},{5}", MaSV, TenSV, DiaChi, SDT, NgaySinh, GioiTinh);
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

            string sql = string.Format("INSERT INTO tblSinhVien(MaSV, TenSV, DiaChi, SDT, NgaySinh, GioiTinh) Values('{0}', N'{1}', N'{2}', '{3}', '{4}', {5})", this.MaSV, this.TenSV, this.DiaChi, this.SDT, this.NgaySinh, this.GioiTinh);
            ConnectDB ConDB = new ConnectDB();
            ConDB.InsertQuery(sql);
        }
        public static void Them(SinhVien sv)
        {
            string sql = string.Format("INSERT INTO tblSinhVien(MaSV, TenSV, DiaChi, SDT, NgaySinh, GioiTinh) Values('{0}', N'{1}', N'{2}', '{3}', '{4}', {5})", sv.MaSV, sv.TenSV, sv.DiaChi, sv.SDT, sv.NgaySinh, sv.GioiTinh == true ? 1 : 0);
            ConnectDB ConDB = new ConnectDB();
            ConDB.InsertQuery(sql);
        }
        public static void Xoa(string maSV)
        {
            //DanhSachSinhVien.RemoveAll(sv => sv.MaSV == maSV);

            string sql = string.Format("DELETE FROM tblSinhVien WHERE MaSV = '{0}'", maSV);
            ConnectDB ConDB = new ConnectDB();
            ConDB.InsertQuery(sql);
        }
        /// <summary>
        /// sửa thông tin sinh viên
        /// </summary>
        /// <param name="sinhVien"></param>
        public static void Sua(SinhVien sv)
        {
            string sql = string.Format(@"UPDATE tblSinhVien SET TenSV = '{0}', SDT = '{2}', DiaChi = '{1}', GioiTInh = '{4}', NgaySinh = '{3}'WHERE MaSV = '{5}'", sv.TenSV, sv.DiaChi, sv.SDT, sv.NgaySinh, sv.GioiTinh == true ? 1 : 0, sv.MaSV);
            ConnectDB ConDB = new ConnectDB();
            ConDB.InsertQuery(sql);
        }
    }
}
