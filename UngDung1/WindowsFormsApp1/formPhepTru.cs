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

namespace WindowsFormsApp1
{
    public partial class formPhepTru : Form
    {
        public formPhepTru()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                if(int.TryParse(txtSoA.Text,out a)==false)
                {
                    txtSoA.SelectAll();
                    txtSoA.Focus();
                    throw new Exception("Du Lieu Nhap Khong Hop le");
                }
                if (int.TryParse(txtSoB.Text, out b) == false)
                {
                    txtSoB.SelectAll();
                    txtSoB.Focus();
                    throw new Exception("Du Lieu Nhap Khong Hop le");
                }
                PhuongTrinh pt = new PhuongTrinh();
                // luoi khong dat ten txtHieu
                txtTong.Text = pt.Hieu(a, b).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi"
                    , MessageBoxButtons.OKCancel
                    ,MessageBoxIcon.Error);
            }


        }

        private void txtSoA_KeyUp(object sender, KeyEventArgs e)
        {
            int b;
            if (int.TryParse(txtSoA.Text, out b) == false)
            {
                txtSoA.Text = "";
            }

        }

        private void txtSoB_KeyUp(object sender, KeyEventArgs e)
        {
            int b;
            if (int.TryParse(txtSoB.Text, out b) == false)
            {
                txtSoB.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void formPhepTru_FormClosing(object sender, FormClosingEventArgs e)
        {
            var isOk = MessageBox.Show("Ban co muon thoat khong?",
               "Thong Bao", MessageBoxButtons.OKCancel
               , MessageBoxIcon.Warning);

            if (isOk != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
