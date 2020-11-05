using SuDungHam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.formPhuongTrinh
{
    public partial class formPhuongTrinhBac1 : Form
    {
        public formPhuongTrinhBac1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {
                if (double.TryParse(txtSoA.Text, out a) == false){
                    txtSoA.SelectAll();
                    txtSoA.Focus();
                    throw new Exception("Số A Nhập Không Hợp Lệ");
                }
                if (double.TryParse(txtSoB.Text, out b) == false)
                {
                    txtSoB.SelectAll();
                    txtSoB.Focus();
                    throw new Exception("Số B Nhập Không Hợp Lệ");
                }
                PhuongTrinh pt = new PhuongTrinh();
                PhuongTrinhBac1 ptb1 = new PhuongTrinhBac1();
                ptb1.a = a;
                ptb1.b = b;
                ptb1.Giai();
                txtTong.Text = ptb1.x.ToString();
                //txtTong.Text = 
                //    pt.PhuongTrinhBac1(a, b).ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
