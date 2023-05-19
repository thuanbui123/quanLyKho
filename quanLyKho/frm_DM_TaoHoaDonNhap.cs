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
    public partial class frm_DM_TaoHoaDonNhap : Form
    {
        public frm_DM_TaoHoaDonNhap()
        {
            InitializeComponent();
        }

        private void dinhDangluoi()
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
        private void LoadDuLieuLenLuoi()
        {
            string query = "select hh.id, hh.tenHangHoa, lh.tenLoai, hh.donViTinh, hh.XuatXu from hangHoa as hh, loaiHang as lh where hh.idLoaiHang = lh.id";
            DataTable data = DataProvider.Instance.executeQuery(query);
            dgvMain.DataSource = data;
            dinhDangluoi();
        }

        private void btnNhapHang_Click_1(object sender, EventArgs e)
        {
            frm_DM_ChiTietHoaDonNhap f = new frm_DM_ChiTietHoaDonNhap();
            f.ShowDialog();
        }

        private void frm_DM_TaoHoaDonNhap_Load_1(object sender, EventArgs e)
        {
            LoadDuLieuLenLuoi();
        }
    }
}
