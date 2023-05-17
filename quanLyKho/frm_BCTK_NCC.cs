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
    public partial class frm_BCTK_NCC : Form
    {
        public frm_BCTK_NCC()
        {
            InitializeComponent();
        }
        private void dinhDangLuoi()
        {
            dgv_BCTK_NCC.Columns[0].HeaderText = "Mã Nhà cung cấp";
            dgv_BCTK_NCC.Columns[0].Width = 150;
            dgv_BCTK_NCC.Columns[1].HeaderText = "Tên Nhà cung cấp";
            dgv_BCTK_NCC.Columns[1].Width = 170;
            dgv_BCTK_NCC.Columns[2].HeaderText = "Địa chỉ";
            dgv_BCTK_NCC.Columns[2].Width = 170;
            dgv_BCTK_NCC.Columns[3].HeaderText = "Số điện thoại";
            dgv_BCTK_NCC.Columns[3].Width = 150;
        }

        private void loadDuLieuLenLuoi()
        {
            string query = "select ";
            DataTable data = DataProvider.Instance.executeQuery(query);
            dgv_BCTK_NCC.DataSource = data;
            dinhDangLuoi();
        }

        private void dgv_BCTK_NCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_BCTK_NCC_Load(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
        }
    }
}
