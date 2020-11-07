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
    public partial class FormDanhSachSinhVien : Form
    {
        public FormDanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void dgvDanhSachSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            ResetDanhSachSinhVien();
        }
        /// <summary>
        /// tải lại danh sach sinh viên
        /// </summary>
        private void ResetDanhSachSinhVien()
        {
            if (SinhVien.DanhSachSinhVien != null)
                dgvDanhSachSinhVien.DataSource = SinhVien.DanhSachSinhVien;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form fThemSinhVien = new FormThemSinhVien();
            // mở form thêm sinh viên
            var isOk = fThemSinhVien.ShowDialog();
            // nếu mà có thêm
            if (isOk == DialogResult.OK)
                // cập nhật danh sách sinh viên
                ResetDanhSachSinhVien();
        }
    }
}
