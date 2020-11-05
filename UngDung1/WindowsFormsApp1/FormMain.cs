using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.formPhuongTrinh;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            Form dangNhap = new FormDangNhap();
            //dangNhap.Show();
            var isOk= dangNhap.ShowDialog();
            if (isOk != DialogResult.OK)
            {
                Close();
            }
            InitializeComponent();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            formPhepTru formPhepTru = new formPhepTru();
            formPhepTru.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            formPhepCong formPhepTru = new formPhepCong();
            formPhepTru.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (hoi != DialogResult.Yes) {
                e.Cancel = true;
            }

        }

        private void cộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPhepCong PC = new formPhepCong();
            PC.Show();
        }

        private void trừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PC = new formPhepTru();
            PC.Show();
        }

        private void nhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PC = new formPhepNhan();
            PC.Show();
        }

        private void chiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PC = new formPhepChia();
            PC.Show();
        }

        private void phươngTrìnhBâc1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PC = new formPhuongTrinhBac1();
            PC.Show();
        }

        private void phươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PC = new formPhuongTrinhBac2();
            PC.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tinhNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
