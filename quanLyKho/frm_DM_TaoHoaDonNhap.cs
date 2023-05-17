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
        public static string connectionString =
            "data source = Data Source=DESKTOP-A5FUL33\\SQLEXPRESS;Initial Catalog=quanLyKho; User ID = sa; Password = 1";
        public frm_DM_TaoHoaDonNhap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dinhDangluoi()
        {
            dgvMain.Columns[0].HeaderText = "Mã hàng hóa";
            dgvMain.Columns[0].Width = 150;
            dgvMain.Columns[0].HeaderText = "Tên hàng hóa";
            dgvMain.Columns[0].Width = 170;
            dgvMain.Columns[0].HeaderText = "Tên loại";
            dgvMain.Columns[0].Width = 170;
            dgvMain.Columns[0].HeaderText = "Đơn vị tính";
            dgvMain.Columns[0].Width = 170;
            dgvMain.Columns[0].HeaderText = "Xuất xứ";
            dgvMain.Columns[0].Width = 150;
        }
        private void LoadDuLieuLenLuoi()
        {
            string query = "Select * from phieuNhap";
            // string query = "select hh.id, hh.tenHangHoa, lh.tenLoai, hh.donViTinh, hh.XuatXu from hangHoa as hh, loaiHang as lh where hh.idLoai";
            DataTable data = DataProvider.Instance.executeQuery(query);
            dgvMain.DataSource = data;
            dinhDangluoi();
        }

        private void frm_DM_TaoHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadDuLieuLenLuoi();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {

        }
    }
}
