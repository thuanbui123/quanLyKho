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
            lblUser.Text = userName;
        }



        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            formManager fm = formManager.GetInstance(this);

            frmDoiMatKhau f = new frmDoiMatKhau(lblUser.Text);

            fm.showForm(pnlContainer ,f);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
        }
    }
}
