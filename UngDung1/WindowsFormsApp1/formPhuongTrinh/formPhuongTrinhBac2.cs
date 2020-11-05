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
    public partial class formPhuongTrinhBac2 : Form
    {
        public formPhuongTrinhBac2()
        {
            InitializeComponent();
        }

        private void formPhuongTrinhBac2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c;
                if (double.TryParse(txtSoA.Text,out a)==false)
                {
                    txtSoA.SelectAll();
                    txtSoA.Focus();
                    throw new Exception("Lỗi Số A");
                }
                if (double.TryParse(txtSoB.Text, out b) == false)
                {
                    txtSoB.SelectAll();
                    txtSoB.Focus();
                    throw new Exception("Lỗi Số A");
                }
                if (double.TryParse(txtSoC.Text, out c) == false)
                {
                    txtSoC.SelectAll();
                    txtSoC.Focus();
                    throw new Exception("Lỗi Số C");
                }
                PhuongTrinh pt = new PhuongTrinh();
                PhuongTrinhBac2 ptb2 = new PhuongTrinhBac2(a,b,c);
                ptb2.Giai();

                double[] nghiem = pt.PhuongTrinhBac2(a, b, c);
                txtNghiem1.Text =
                    string.Format("{0:F2}", ptb2.x1);
                txtNghiem2.Text =
                    string.Format("{0:F2}", ptb2.x2);
                //txtNghiem1.Text =
                //    string.Format("{0:F2}", nghiem[0]);
                //txtNghiem2.Text = 
                //    string.Format("{0:F2}", nghiem[1]);
            }
            catch (Exception ex )
            {
                // log
                MessageBox.Show(ex.Message, "Thông Báo"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
