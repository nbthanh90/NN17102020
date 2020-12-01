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
    public partial class FormThemSinhVien : Form
    {
        public FormThemSinhVien()
        {
            InitializeComponent();
        }

        private void FormThemSinhVien_Load(object sender, EventArgs e)
        {
            // khởi tạo danh sách giới tính
            List<GioiTinh> lgt = GioiTinh.Get();
            cbbGioiTinh.DataSource = lgt;
            cbbGioiTinh.DisplayMember = "Name";
            cbbGioiTinh.ValueMember = "Id";
            // gán giá trị mặc định
            cbbGioiTinh.SelectedIndex = 1;
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = GetInputForm();
                SinhVien.Them(sv);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private SinhVien GetInputForm()
        {
            if (txtMaSV.Text == "")
            {
                txtMaSV.Focus();
                throw new Exception("Nhập mã Sinh Viên");
            }
            if (txtTenSV.Text == "")
            {
                txtTenSV.Focus();
                throw new Exception("Nhập tên Sinh Viên");
            }
            if (txtDiaChi.Text == "")
            {
                txtTenSV.Focus();
                throw new Exception("Nhập địa chỉ Sinh Viên");
            }
            GioiTinh gt = (GioiTinh)
                cbbGioiTinh.SelectedItem;
            return new SinhVien(
                txtMaSV.Text,
                txtTenSV.Text,
                txtSDT.Text,
                txtDiaChi.Text,
                dtpNgaySinh.Value,
                gt.Id
                );
        }
    }
}
