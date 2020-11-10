using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class GioiTinh
    {
        const bool Nam = true;
        const bool Nu = false;

        public bool Id { get; set; }
        public string Name { get; set; }
        public static List<GioiTinh> Get()
        {
            List<GioiTinh> lgt = new List<GioiTinh>();
            // giới tính là Nam
            GioiTinh gtNam = new GioiTinh();
            gtNam.Id = Nam;
            gtNam.Name = "Nam";
            lgt.Add(gtNam);
            // giới tính là Nữ
            GioiTinh gtNu = new GioiTinh();
            gtNu.Id = Nu;
            gtNu.Name = "Nữ";
            lgt.Add(gtNu);
            return lgt;
        }
    }
}
