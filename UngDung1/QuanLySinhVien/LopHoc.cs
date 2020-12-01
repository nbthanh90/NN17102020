using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConnectDB;

namespace QuanLySinhVien
{
    class LopHoc
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string DiaChi { get; set; }
        private static LopHoc ThongTinSuaLopHoc;
        public LopHoc()
        {
        }
        public LopHoc(string maLop, string tenLop, string diaChi)
        {
            MaLop = maLop;
            TenLop = tenLop;
            DiaChi = diaChi;
        }

        public string LopHoc2String()
        {
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
            string sql = @"INSERT INTO tblLopHoc(MaLop, TenLop, DiaChi) VALUES('{0}', '{1}', '{2}')";
            ConnectDB cdb = new ConnectDB();
            cdb.InsertQuery(string.Format(sql, this.MaLop, this.TenLop, this.DiaChi));

        }
        /// <summary>
        /// xóa lớp học trong danh sách
        /// </summary>
        /// <param name="maLop"></param>
        public static void Xoa(string maLopHoc)
        {
            string sql = string.Format("DELETE FROM tblLopHoc WHERE MaLop = '{0}'", maLopHoc);
            ConnectDB cdb = new ConnectDB();
            cdb.InsertQuery(sql);
            // lamda expression
            //DanhSachLopHoc.RemoveAll(lh => lh.MaLop == maLop);
        }

        public static List<LopHoc> GetDanhSachLopHoc()
        {
            ConnectDB cdb = new ConnectDB();
            string sql = "SELECT * FROM tblLopHoc";
            SqlDataReader res = cdb.SelectQuery(sql);
            List<LopHoc> lLopHoc = new List<LopHoc>();
            while (res.Read())
            {
                string maLop = res.GetValue(0).ToString().Trim();
                string tenLop = res.GetValue(1).ToString().Trim();
                string diaChi = res.GetValue(2).ToString().Trim();
                LopHoc lh = new LopHoc(maLop, tenLop, diaChi);
                lLopHoc.Add(lh);
            }
            return lLopHoc;
            //if (DanhSachLopHoc == null)
            //    return new List<LopHoc>();
            //return DanhSachLopHoc;
        }

        public static void Sua(LopHoc lh)
        {
            string sql = string.Format("UPDATE tblLopHoc SET TenLop = '{0}', DiaChi = '{1}' WHERE MaLop = '{2}'", lh.TenLop, lh.DiaChi, lh.MaLop);
            ConnectDB cdb = new ConnectDB();
            cdb.InsertQuery(sql);
            //Xoa(lh.MaLop);
            //ThemLopHoc(lh);
        }

        private static void ThemLopHoc(LopHoc lh)
        {
            string sql = "INSERT INTO tblLopHoc(MaLop, TenLop, DiaChi) VALUES('{0}', '{1}', '{2}')";
            ConnectDB cdb = new ConnectDB();
            cdb.InsertQuery(string.Format(sql, lh.MaLop, lh.TenLop, lh.DiaChi));

            //if (DanhSachLopHoc == null)
            //    DanhSachLopHoc = new List<LopHoc>();
            //DanhSachLopHoc.Add(lh);

        }

        public static void SetThongTinSuaLopHoc(LopHoc lhSua)
        {
            ThongTinSuaLopHoc = lhSua;
        }
        public static LopHoc GetThongTinSuaLopHoc()
        {
            if (ThongTinSuaLopHoc != null)
                return ThongTinSuaLopHoc;
            return new LopHoc();
        }

        public static LopHoc LopHocById(string maLopHoc)
        {
            string sql = "SELECT * FROM tblLopHoc WHERE MaLop = '{0}'";
            ConnectDB cdb = new ConnectDB();
            var res = cdb.SelectQuery(string.Format(sql, maLopHoc));
            res.Read();
            string maLop = res.GetValue(0).ToString().Trim();
            string tenLop = res.GetValue(1).ToString().Trim();
            string diaChi = res.GetValue(2).ToString().Trim();
            return new LopHoc(maLop, tenLop, diaChi);

            //if (DanhSachLopHoc != null)
            //    foreach (var lopHoc in DanhSachLopHoc)
            //    {
            //        if (lopHoc.MaLop == maLopHoc)
            //            return lopHoc;
            //    }
            //return new LopHoc();
        }
    }
}
