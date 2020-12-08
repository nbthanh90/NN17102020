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
            Loai themLoai = GetInputForm();
            _Estore20Db.Loais.InsertOnSubmit(themLoai);
            _Estore20Db.SubmitChanges();
            // cập nhật danh sách
            dgvLoai.DataSource = _Estore20Db.Loais.ToList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // lấy thông tin loại trên form
            Loai suaLoai = GetInputForm();
            // tìm loại muốn xóa
            Loai chiTietLoai = _Estore20Db.Loais.FirstOrDefault(item => item.MaLoai == suaLoai.MaLoai);
            chiTietLoai.TenLoai = suaLoai.TenLoai;
            chiTietLoai.MoTa = suaLoai.MoTa;
            _Estore20Db.SubmitChanges();
            // cập nhật danh sách
            dgvLoai.DataSource = _Estore20Db.Loais.ToList();
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

        private void dgvLoai_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string maLoai = dgvLoai.Rows[e.RowIndex].Cells[0].Value.ToString();
            string tenLoai = dgvLoai.Rows[e.RowIndex].Cells[1].Value.ToString();
            string moTa = "";
            if (dgvLoai.Rows[e.RowIndex].Cells[2]
                .Value != null)
                moTa = dgvLoai.Rows[e.RowIndex].Cells[2]
                    .Value.ToString();


            Loai suaLoai = new Loai()
            {
                MaLoai = int.Parse(maLoai),
                MoTa = moTa,
                TenLoai = tenLoai
            };
            Loai chiTietLoai = _Estore20Db.Loais.FirstOrDefault(item => item.MaLoai == suaLoai.MaLoai);
            chiTietLoai.TenLoai = suaLoai.TenLoai;
            chiTietLoai.MoTa = suaLoai.MoTa;
            _Estore20Db.SubmitChanges();
            // cập nhật danh sách
            dgvLoai.DataSource = _Estore20Db.Loais.ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maLoai = int.Parse(txtMaLoai.Text);
            Loai chiTietLoai = _Estore20Db.Loais.FirstOrDefault(i => i.MaLoai == maLoai);
            _Estore20Db.Loais.DeleteOnSubmit(chiTietLoai);
            _Estore20Db.SubmitChanges();
            // cập nhật danh sách
            dgvLoai.DataSource = _Estore20Db.Loais.ToList();
        }
    }
}
