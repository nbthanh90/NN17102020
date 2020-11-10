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
    public partial class FormSuaLopHoc : Form
    {
        public FormSuaLopHoc()
        {
            InitializeComponent();
            SetInputForm(LopHoc.GetThongTinSuaLopHoc());
        }
        private void SetInputForm(LopHoc lopHoc)
        {
            txtMaLop.Text = lopHoc.MaLop;
            txtTenLop.Text = lopHoc.TenLop;
            txtDiaChi.Text = lopHoc.DiaChi;
        }
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            try
            {
                LopHoc suaLopHoc = GetInputForm();
                LopHoc.Sua(suaLopHoc);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }
        private LopHoc GetInputForm()
        {
            if (txtTenLop.Text == "")
            {
                throw new Exception("Vui Lòng Nhập Tên Lớp.");
            }
            if (txtDiaChi.Text == "")
            {
                throw new Exception("Vui Lòng Nhập Địa Chỉ.");
            }
            return new LopHoc(
                txtMaLop.Text,
                txtTenLop.Text,
                txtDiaChi.Text
                );
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            var isXoa = MessageBox.Show("Bạn muốn xóa lớp học không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (isXoa != DialogResult.OK)
                return;
            LopHoc.Xoa(LopHoc.GetThongTinSuaLopHoc().MaLop);
            DialogResult = DialogResult.OK;
        }
    }
}
