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
    public partial class frm_DM_NCC : Form
    {
        public frm_DM_NCC()
        {
            InitializeComponent();
        }

        private void dinhDangLuoi()
        {
            dgv_DM_NCC.Columns[0].HeaderText = "Mã Nhà cung cấp";
            dgv_DM_NCC.Columns[0].Width = 150;
            dgv_DM_NCC.Columns[1].HeaderText = "Tên Nhà cung cấp";
            dgv_DM_NCC.Columns[1].Width = 170;
            dgv_DM_NCC.Columns[2].HeaderText = "Địa chỉ";
            dgv_DM_NCC.Columns[2].Width = 170;
            dgv_DM_NCC.Columns[3].HeaderText = "Số điện thoại";
            dgv_DM_NCC.Columns[3].Width = 150;
        }

        private void loadDuLieuLenLuoi()
        {
            string query = "select ";
            DataTable data = DataProvider.Instance.executeQuery(query);
            dgv_DM_NCC.DataSource = data;
            dinhDangLuoi();
        }

        private void dgv_DM_NCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frm_DM_NCC_Load(object sender, EventArgs e)
        {
            loadDuLieuLenLuoi();
        }
    }
}
