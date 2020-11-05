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

        private void thôngKeBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        }

        private void thêmLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThemLop = new FormThemLopHoc();
            fThemLop.ShowDialog();

        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThemLop = new FormDanhSachLopHoc();
            fThemLop.MdiParent = this;
            fThemLop.Show();
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThemLop = new FormThemSinhVien();
            fThemLop.MdiParent = this;
            fThemLop.Show();
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThemLop = new FormThemSinhVien();
            fThemLop.MdiParent = this;
            fThemLop.Show();
        }

        private void sinhViênTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThemLop = new FormBaoCaoSinhVienTheoLop();
            fThemLop.MdiParent = this;
            fThemLop.Show();
        }

        private void sinhViênHocLaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThemLop = new FormBaoCaoSinhVienHocLai();
            fThemLop.MdiParent = this;
            fThemLop.Show();

        }

        private void điểmTheoiLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fThemLop = new FormBaoCaoDiemTheoLop();
            fThemLop.MdiParent = this;
            fThemLop.Show();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
