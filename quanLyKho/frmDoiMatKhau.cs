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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private List<TextBox> textBoxList = new List<TextBox>();
        private List<Button> buttonList = new List<Button>();

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            //Thêm tất cả các textBox cần kiểm tra vào danh sách textBoxList
            textBoxList.Add(txtTenDangNhap);
            textBoxList.Add(txtMatKhauCu);
            textBoxList.Add(txtMatKhauMoi);
            textBoxList.Add(txtNhapLaiMatKhauMoi);

            //Thêm tất cả các Button cần kiểm tra vào danh sách buttonList
            buttonList.Add(btnCapNhat);
            buttonList.Add(btnHuy);

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
            }
        }

        private void EnableButtons()
        {
            foreach(Button button in buttonList)
            {
                button.Enabled = true;
            }
        }

        private void DisableButtons()
        {
            foreach(Button button in buttonList)
            {
                button.Enabled = false;
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void txtNhapLaiMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
            txtTenDangNhap.Focus();
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtNhapLaiMatKhauMoi.Text = "";
            btnHuy.Enabled = false;
            btnCapNhat.Enabled = false;
        }
    }
}
