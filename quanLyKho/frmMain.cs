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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            dgvHangTrongKho.DataSource = getList();
        }

        private void tsmiBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang f = new frmBanHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private DataTable getList ()
        {
            DataTable dt = new DataTable();

            string query = "Select * from MatHang";
            dt = DataProvider.Instance.executeQuery(query);

            return dt;
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            formManager fm = formManager.GetInstance(this);

            frmDoiMatKhau f = new frmDoiMatKhau();

            fm.showForm(pnlContainer ,f);
        }
    }
}
