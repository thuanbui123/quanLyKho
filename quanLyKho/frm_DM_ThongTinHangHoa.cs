using quanLyKho.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyKho
{
    public partial class frm_DM_ThongTinHangHoa : Form
    {
        public frm_DM_ThongTinHangHoa()
        {
            InitializeComponent();
        }

        private void dinhDangLuoi()
        {
            dgvMain.Columns[0].HeaderText = "Mã hàng hóa";
            dgvMain.Columns[0].Width = 150;
            dgvMain.Columns[1].HeaderText = "Tên hàng hóa";
            dgvMain.Columns[1].Width = 170;
            dgvMain.Columns[2].HeaderText = "Tên loại";
            dgvMain.Columns[2].Width = 170;
            dgvMain.Columns[3].HeaderText = "Đơn vị tính";
            dgvMain.Columns[3].Width = 170;
            dgvMain.Columns[4].HeaderText = "Xuất xứ";
            dgvMain.Columns[4].Width = 150;
        }

        private void loadLoaiHang()
        {
            string query = "Select lh.id, lh.tenLoai from loaiHang as lh";
            DataTable data = DataProvider.Instance.executeQuery(query);
            cboMaLoai.DataSource = data;
            cboMaLoai.ValueMember = "id";
            cboMaLoai.DisplayMember = "tenLoai";
        }

        private void loadDuLieuLenLuoi()
        {
            string query = "Select hh.id, hh.tenHangHoa, lh.tenLoai, hh.donViTinh, hh.XuatXu from hangHoa as hh, loaiHang as lh where hh.idLoaiHang = lh.id";
            DataTable data = DataProvider.Instance.executeQuery(query);
            dgvMain.DataSource = data;
            dinhDangLuoi();
        }

        private void getDongThuI (int i)
        {
            try
            {
                string tenLoai = dgvMain.Rows[i].Cells[2].Value.ToString();
                Object data = DataProvider.Instance.executeScalar("Select * from loaiHang where tenLoai = N'" + tenLoai + "'");
                cboMaLoai.SelectedValue = data;
                txtMaHangHoa.Text = dgvMain.Rows[i].Cells[0].Value.ToString();
                txtTenHangHoa.Text = dgvMain.Rows[i].Cells[1].Value.ToString();
                txtDonViTinh.Text = dgvMain.Rows[i].Cells[3].Value.ToString();
                txtXuatXu.Text = dgvMain.Rows[i].Cells[4].Value.ToString();
            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void frm_DM_ThongTinHangHoa_Load(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
            loadLoaiHang();
            getDongThuI(0);
            txtMaHangHoa.Enabled = false;
            txtTenHangHoa.Enabled = false;
            txtDonViTinh.Enabled = false;
            txtXuatXu.Enabled = false;
            cboMaLoai.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private bool kiemTraDuLieu()
        {
            bool status = true;
            if (txtMaHangHoa.Text.Length == 0)
            {
                errorProvider1.SetError(txtMaHangHoa, "Chưa nhập mã hàng hóa!");
                status = false;
            }

            if (txtTenHangHoa.Text.Length == 0)
            {
                errorProvider1.SetError(txtTenHangHoa, "Chưa nhập tên hàng hóa!");
                status = false;
            }

            if (txtDonViTinh.Text.Length == 0)
            {
                errorProvider1.SetError(txtDonViTinh, "Chưa nhập đơn vị tính!");
                status = false;
            }

            if (txtXuatXu.Text.Length == 0)
            {
                errorProvider1.SetError(txtXuatXu, "Chưa nhập xuất xứ!");
                status = false;
            }

            return status;
        }

        private void dgvMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvMain.CurrentCell.RowIndex;
            getDongThuI(i);
        }
    }
}
