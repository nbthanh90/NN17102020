using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var hoi = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (hoi == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void thêmLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThemLop = new FormThemLopHoc();
            fThemLop.ShowDialog();
        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThemDanhSachLop = new FormDanhSachLopHoc();
            fThemDanhSachLop.MdiParent = this;
            fThemDanhSachLop.Show();
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThemSinhVien = new FormThemSinhVien();
            fThemSinhVien.MdiParent = this;
            fThemSinhVien.Show();
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThemLop = new FormDanhSachSinhVien();
            fThemLop.MdiParent = this;
            fThemLop.Show();
        }

        private void sinhViênTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fSinhVienTheoLop = new FormBaoCaoSinhVienTheoLop();
            fSinhVienTheoLop.MdiParent = this;
            fSinhVienTheoLop.Show();
        }

        private void sinhViênHocLaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fSinhVienHocLai = new FormBaoCaoSinhVienHocLai();
            fSinhVienHocLai.MdiParent = this;
            fSinhVienHocLai.Show();

        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngKeBáoCáoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void điểmTheoiLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fDiemTheoLop = new FormBaoCaoDiemTheoLop();
            fDiemTheoLop.MdiParent = this;
            fDiemTheoLop.Show();
        }
    }
}
