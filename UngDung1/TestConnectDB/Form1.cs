using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConnectDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            ConnectDB cdb = new ConnectDB();
            string sql = string.Format("insert into tblSinhVien(MaSV, TenSV, DiaChi, SDT, NgaySinh, GioiTinh) Values('{0}', N'{1}', N'{2}', '{3}', '{4}', {5})", "SV001" + rand.Next(1, 10000).ToString(), "Tiis Nguyeenx", "HCM", "0946226876", new DateTime(2000, 1, 2).ToString(),1);
            cdb.InsertQuery(sql);

            this.tblSinhVienTableAdapter.Fill(this.testDataSet.tblSinhVien);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.tblSinhVien' table. You can move, or remove it, as needed.
            this.tblSinhVienTableAdapter.Fill(this.testDataSet.tblSinhVien);

        }
    }
}
