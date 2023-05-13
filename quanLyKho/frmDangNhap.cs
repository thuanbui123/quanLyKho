using quanLyKho.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyKho
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool status = true;
            errorProvider1.Clear();
            if (txtTenDangNhap.Text.Length == 0)
            {
                errorProvider1.SetError(txtTenDangNhap, "Chưa điền tên đăng nhập!");
                status = false;
            }

            if (txtMatKhau.Text.Length == 0)
            {
                errorProvider1.SetError(txtMatKhau, "Chưa nhập mật khẩu!");
                status = false;
            }


            if (status)
            {
                if (dangNhap(txtTenDangNhap.Text, txtMatKhau.Text))
                {
                    frmMain f = new frmMain(txtTenDangNhap.Text);
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool dangNhap (string userName, string password) 
        {
            string query = "exec USP_login @userName , @password";
            DataTable table = new DataTable();
            table = DataProvider.Instance.executeQuery(query, new object[] {userName, password });
            return table.Rows.Count > 0;
        }

        public void resetControl()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình!", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
