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
    public partial class FormThemBangDiem : Form
    {
        // 1 là THÊM
        // 0 là SỬA
        private int IsThem = 1;
        const int Sua = 0;
        const int Them = 1;
        
        public FormThemBangDiem()
        {
            InitializeComponent();
        }

        private void btnThoatBangDiem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuuBangDiem_Click(object sender, EventArgs e)
        {
            try
            {
                BangDiem bd = GetInputForm();
                if (IsThem == 1)
                {
                    // thêm
                    BangDiem.Them(bd);
                    // reset data
                    ResetData();
                }
                else
                {
                    // sửa
                    BangDiem.Sua(bd);
                    IsThem = Them;
                    // reset
                    ResetData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ResetData()
        {
            dgvBangDiem.DataSource = BangDiem.GetDanhSachBangDiem().ToList();
        }

        private BangDiem GetInputForm()
        {
            if (txtToan.Text == "")
            {
                txtToan.SelectAll();
                txtToan.Focus();
                throw new Exception("Bạn chưa nhập điểm Toán!");
            }
            if (txtLy.Text == "")
            {
                txtLy.SelectAll();
                txtLy.Focus();
                throw new Exception("Bạn chưa nhập điểm Lý!");
            }
            if (txtLy.Text == "")
            {
                txtHoa.SelectAll();
                txtHoa.Focus();
                throw new Exception("Bạn chưa nhập điểm Hóa!");
            }
            double toan, ly, hoa;
            #region Kiểm tra điểm Toán
            if (double.TryParse(txtToan.Text, out toan) == true)
            {
                if (toan > 10 || toan < 0)
                {
                    txtToan.SelectAll();
                    txtToan.Focus();
                    throw new Exception("Điểm Toán chưa hợp lệ!");
                }
            }
            else
            {
                txtToan.SelectAll();
                txtToan.Focus();
                throw new Exception("Điểm Toán chưa hợp lệ!");
            }
            #endregion
            #region Kiểm tra điểm Lý
            if (double.TryParse(txtLy.Text, out ly) == true)
            {
                if (ly > 10 || ly < 0)
                {
                    txtLy.SelectAll();
                    txtLy.Focus();
                    throw new Exception("Điểm Lý chưa hợp lệ!");
                }
            }
            else
            {
                txtLy.SelectAll();
                txtLy.Focus();
                throw new Exception("Điểm Lý chưa hợp lệ!");
            }
            #endregion
            #region Kiểm tra điểm Hóa
            if (double.TryParse(txtHoa.Text, out hoa) == true)
            {
                if (hoa > 10 || hoa < 0)
                {
                    txtHoa.SelectAll();
                    txtHoa.Focus();
                    throw new Exception("Điểm Hóa chưa hợp lệ!");
                }
            }
            else
            {
                txtHoa.SelectAll();
                txtHoa.Focus();
                throw new Exception("Điểm Hóa chưa hợp lệ!");
            }
            #endregion

            SinhVien itemSV = (SinhVien)cbbSinhVien.SelectedItem;
            LopHoc itemLH = (LopHoc)cbbLopHoc.SelectedItem;

            return new BangDiem(
                itemSV.MaSV,
                itemLH.MaLop,
                toan,
                ly,
                hoa
                );
        }

        private void FormThemBangDiem_Load(object sender, EventArgs e)
        {
            cbbLopHoc.DataSource = LopHoc.GetDanhSachLopHoc().ToList();
            // DisplayMember -> người dùng thấy
            cbbLopHoc.DisplayMember = "TenLop";
            // ValueMember -> lập trình thấy
            cbbLopHoc.ValueMember = "MaLop";
            cbbSinhVien.DataSource = SinhVien.GetDanhSachSinhVien().ToList();
            cbbSinhVien.DisplayMember = "TenSV";
            cbbSinhVien.ValueMember = "MaSV";
        }

        private void dgvBangDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IsThem = Sua;
            string MaSV = dgvBangDiem.Rows[e.RowIndex].Cells[0].Value.ToString();
            string MaLop = dgvBangDiem.Rows[e.RowIndex].Cells[1].Value.ToString();
                // lấy thông tin dòng cần sửa
            BangDiem bdSua = BangDiem.BangDiemByMaSVMaLop(MaSV, MaLop);
            // gán thông tin dòng thông tin cần sửa
            SetInputForm(bdSua);
        }

        private void SetInputForm(BangDiem bdSua)
        {
            txtToan.Text = bdSua.MonToan.ToString();
            txtLy.Text = bdSua.MonLy.ToString();
            txtHoa.Text = bdSua.MonHoa.ToString();
            cbbLopHoc.SelectedValue = bdSua.MaLop;
            cbbSinhVien.SelectedValue = bdSua.MaSV;
        }

        private void btnXoaBangDiem_Click(object sender, EventArgs e)
        {
            var isOk = MessageBox.Show("Bạn có muốn xóa?", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            if (isOk != DialogResult.OK)
                return;
            BangDiem bdSua = GetInputForm();
            BangDiem.Xoa(bdSua.MaLop, bdSua.MaSV);
            ResetData();
        }
    }
}
