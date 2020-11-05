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
    public partial class FormThemLopHoc : Form
    {
        public FormThemLopHoc()
        {
            InitializeComponent();
        }
        /// <summary>
        /// them lop hoc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                LopHoc lh = GetInputForm();
                lh.ThemLopHoc();
                //MessageBox.Show(lh.LopHoc2String());
                //Form fDanhSach = new FormDanhSachLopHoc();
                //fDanhSach.Show();
                DialogResult = DialogResult.OK;
                //Close();
                //SetInputForm(new LopHoc());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
       /// <summary>
       /// gán thông tin cho form
       /// </summary>
       /// <param name="lopHoc">obj lop hoc</param>
        private void SetInputForm(LopHoc lopHoc)
        {
            txtMaLop.Text = lopHoc.MaLop;
            txtTenLop.Text = lopHoc.TenLop;
            txtDiaChi.Text = lopHoc.DiaChi;
        }
        /// <summary>
        /// Lấy thông tin từ form
        /// </summary>
        /// <returns></returns>
        private LopHoc GetInputForm()
        {
            if (txtMaLop.Text == "") {
                throw new Exception("Vui Lòng Mã Nhóm.");
            }
            if (txtTenLop.Text == "")
            {
                throw new Exception("Vui Lòng Tên Lớp.");
            }
            if (txtDiaChi.Text == "")
            {
                throw new Exception("Vui Lòng Địa Chỉ.");
            }
            return new LopHoc(
                txtMaLop.Text,
                txtTenLop.Text,
                txtDiaChi.Text);
        }
    }
}
