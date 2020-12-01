using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungLinq
{
    public partial class FormLoai : Form
    {
        // khai báo biến _Estore20Db
        static Estore20DataContext _Estore20Db = new Estore20DataContext();
        public FormLoai()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenTimKiem = txtTimKiem.Text.Trim();
            dgvLoai.DataSource = _Estore20Db.Loais.Where(ll => ll.TenLoai.Contains(tenTimKiem) || ll.MaLoai.ToString().Contains(tenTimKiem)).ToList();
        }

        private void FormLoai_Load(object sender, EventArgs e)
        {
            dgvLoai.DataSource = _Estore20Db.Loais.ToList();
        }

        private void dgvLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maLoai = dgvLoai.Rows[e.RowIndex].Cells[0].Value.ToString();
            Loai chonLoai = _Estore20Db.Loais.Where(ll => ll.MaLoai.ToString().Equals(maLoai)).FirstOrDefault();

            SetInputForm(chonLoai);
        }

        private void SetInputForm(Loai chonLoai)
        {
            txtMaLoai.Text = chonLoai.MaLoai.ToString();
            txtTenLoai.Text = chonLoai.TenLoai;
            txtMota.Text = chonLoai.MoTa;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tenTimKiem = txtTimKiem.Text.Trim();
            dgvLoai.DataSource = _Estore20Db.Loais.Where(ll => ll.TenLoai.Contains(tenTimKiem) || ll.MaLoai.ToString().Contains(tenTimKiem)).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Loai suaLoai = GetInputForm();
        }

        private Loai GetInputForm()
        {
            int maLoai = int.Parse(txtMaLoai.Text);
            string tenLoai = txtTenLoai.Text;
            string moTa = txtMota.Text;
            return new Loai()
            {
                MaLoai = maLoai,
                TenLoai = tenLoai,
                MoTa = moTa
            };
        }
    }
}
