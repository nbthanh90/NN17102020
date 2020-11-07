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
    public partial class FormDanhSachLopHoc : Form
    {
        public FormDanhSachLopHoc()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDanhSachLopHoc_Load(object sender, EventArgs e)
        {
            ResetDanhSach();

        }

        private void ResetDanhSach()
        {
            if (LopHoc.DanhSachLopHoc != null)
                dgvDanhSachLopHoc.DataSource = LopHoc.DanhSachLopHoc.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fThem = new FormThemLopHoc();
            // var isOk = fThem.ShowDialog();
            DialogResult isOk = fThem.ShowDialog();
            if (isOk == DialogResult.OK) {
                ResetDanhSach();
            }
        }

        private void dgvDanhSachLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy mã lớp học khi chọn
            string maLopHoc = dgvDanhSachLopHoc.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show(maLopHoc);
            Form fSuaLopHoc = new FormSuaLopHoc();
            fSuaLopHoc.ShowDialog();
        }

        private void dgvDanhSachLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
