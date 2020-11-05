using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTaiKhoan.Text == "")
                {
                    throw new Exception("Chưa Nhập Tài Khoản");
                }
                if (txtMatkhau.Text == "")
                {
                    throw new Exception("Chưa Nhập Mật Khẩu");
                }
                // kiem tra dang nhap
                if (txtTaiKhoan.Text == "admin" && txtMatkhau.Text == "123456")
                {
                    //dang nhap thanh cong
                    this.DialogResult = DialogResult.OK;
                }
                else {
                    // không thanh cong
                    throw new Exception("Mật Khẩu/Tài Khoản Không Hợp Lệ");
                }

            }
            catch (Exception ex)
            {
                lblThongBao.Text = ex.Message;
            }
            
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
