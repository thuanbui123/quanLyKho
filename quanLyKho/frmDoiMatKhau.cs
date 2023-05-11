﻿using System;
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
    public partial class frmDoiMatKhau : Form
    {
        public string value;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        public frmDoiMatKhau(string value)
        {
            InitializeComponent();
            txtUserName.Text = value;
        }

        private List<TextBox> textBoxList = new List<TextBox>();
        private List<Button> buttonList = new List<Button>();

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            txtMatKhauCu.Focus();
            //Thêm tất cả các textBox cần kiểm tra vào danh sách textBoxList
            textBoxList.Add(txtUserName);
            textBoxList.Add(txtMatKhauCu);
            textBoxList.Add(txtMatKhauMoi);
            textBoxList.Add(txtNhapLaiMatKhauMoi);

            //Thêm tất cả các Button cần kiểm tra vào danh sách buttonList
            buttonList.Add(btnCapNhat);

            DisableButtons();
        }

        private void CheckTextBoxes()
        {
            //Kiểm tra xem tất cả các textbox đã có sự thay đổi chưa
            bool allTextBoxChanged = true;
            foreach(TextBox textBox in textBoxList)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    allTextBoxChanged = false;
                    break;
                }
            }

            //Nếu tất cả các textBox đều có sự thay đổi thì enable các button
            if(allTextBoxChanged)
            {
                EnableButtons();
            } else
            {
                DisableButtons();
            }
        }

        private void EnableButtons()
        {
            foreach(Button button in buttonList)
            {
                button.Enabled = true;
            }
        }

        private void enableHuy ()
        {
            if (txtUserName.Text.Length != 0 || txtMatKhauMoi.Text.Length != 0 || txtMatKhauCu.Text.Length != 0 || txtNhapLaiMatKhauMoi.Text.Length != 0)
            {
                btnHuy.Enabled = true;
            } else
            {
                btnHuy.Enabled = false;
            }
        }

        private void DisableButtons()
        {
            foreach(Button button in buttonList)
            {
                button.Enabled = false;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            enableHuy();
            CheckTextBoxes();
        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {
            enableHuy();
            CheckTextBoxes();
        }

        private void txtNhapLaiMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            enableHuy();
            CheckTextBoxes();
        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            enableHuy();
            CheckTextBoxes();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.Text = "";
            txtMatKhauCu.Focus();
            txtMatKhauMoi.Text = "";
            txtNhapLaiMatKhauMoi.Text = "";
            btnHuy.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        public string userName;
        
        public void getValue (string value)
        {
            txtUserName.Text = value;
        }

        private bool kiemTraDuLieu ()
        {
            bool status = true;
            

            if (txtUserName.Text.Length == 0)
            {
                errorProvider1.SetError(txtUserName, "Bạn chưa điền tên đăng nhâp!");
                status = false;
            }

            if (txtUserName.Text != userName)
            {
                errorProvider1.SetError(txtUserName, "Tên đăng nhập không đúng");
                status = false;
            }

            if (txtMatKhauCu.Text.Length == 0)
            {
                errorProvider1.SetError(txtMatKhauCu, "Bạn chưa nhập mật khẩu cũ!");
                status = false;
            }

            if (txtMatKhauMoi.Text.Length == 0)
            {
                errorProvider1.SetError(txtMatKhauMoi, "Bạn chưa nhập mật khẩu mới!");
                status = false;
            }

            if (txtNhapLaiMatKhauMoi.Text.Length == 0)
            {
                errorProvider1.SetError(txtNhapLaiMatKhauMoi, "Bạn chưa xác nhận mật khẩu mới!");
                status = false;
            }

            if (txtMatKhauMoi.Text != txtNhapLaiMatKhauMoi.Text)
            {
                errorProvider1.SetError(txtNhapLaiMatKhauMoi, "Mật khẩu bạn vừa xác nhận không đúng");
                status = false;
            }

            return status;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            kiemTraDuLieu();
        }
    }
}
