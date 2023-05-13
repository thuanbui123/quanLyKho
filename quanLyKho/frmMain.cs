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
        public string userName;
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string userName)
        {
            InitializeComponent();
            btnThongTinTaiKhoan.Text = userName;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            formManager fm = formManager.GetInstance(this);

            frmDoiMatKhau f = new frmDoiMatKhau(btnThongTinTaiKhoan.Text);

            fm.showForm(pnlContainer, f);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.resetControl();
            this.Hide();
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            formManager fm = formManager.GetInstance(this);
            frmThongTinTaiKhoan frm = new frmThongTinTaiKhoan(btnThongTinTaiKhoan.Text);
            fm.showForm(pnlContainer,frm);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            frmTrangChu frm = new frmTrangChu();
            formManager fm = formManager.GetInstance(this);
            fm.showForm(pnlContainer, frm);
        }
    }
}
