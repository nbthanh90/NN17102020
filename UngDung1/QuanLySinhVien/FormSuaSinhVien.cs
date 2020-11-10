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
    public partial class FormSuaSinhVien : Form
    {
        public FormSuaSinhVien()
        {
            // khởi tạo các đối tượng Form - label, textbox, button...
            InitializeComponent();

            // khởi tạo danh sách giới tính
            List<GioiTinh> lgt = GioiTinh.Get();
            cbbGioiTinh.DataSource = lgt;
            cbbGioiTinh.DisplayMember = "Name";
            cbbGioiTinh.ValueMember = "Id";

            SetInputForm(SinhVien.GetSinhVienSua());
        }

        private void SetInputForm(SinhVien sv)
        {
            txtMaSV.Text = sv.MaSV;
            txtTenSV.Text = sv.TenSV;
            txtDiaChi.Text = sv.DiaChi;
            txtSDT.Text = sv.SDT;
            dtpNgaySinh.Value = sv.NgaySinh;
            cbbGioiTinh.SelectedValue = sv.GioiTinh;
        }
        private void btnSuaSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien svSua = GetInputForm();
                SinhVien.Sua(svSua);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private SinhVien GetInputForm()
        {
            
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
            GioiTinh gt = (GioiTinh)cbbGioiTinh.SelectedItem;

            return new SinhVien(
                txtMaSV.Text,
                txtTenSV.Text,
                txtSDT.Text,
                txtDiaChi.Text,
                gt.Id,
                dtpNgaySinh.Value
                );
        }
        private void btnXoaSinhVien_Click(object sender, EventArgs e)
        {
            var isXoa = MessageBox.Show("Bạn muốn xóa sinh viên không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (isXoa != DialogResult.OK)
                return;
            SinhVien.Xoa(SinhVien.GetSinhVienSua().MaSV);
            DialogResult = DialogResult.OK;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
