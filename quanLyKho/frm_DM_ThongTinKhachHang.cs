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

namespace ttkh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        DataSet ds = new DataSet();
        bool status, state;
        //bool kiemrtra = true;


        public static string strCon = @"Data Source=DESKTOP-02VJS88\DUY;Initial Catalog=quanLyKho;Integrated Security=True";
        public void LoadData()
        {
            SqlConnection connection = new SqlConnection(strCon);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            string query = "Select * from KhachHang";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 || ds.Tables[0].Rows.Count > 0)
            {
                dgvDM_Main_KhachHang.DataSource = ds.Tables[0];
            }
            else
            {
                dgvDM_Main_KhachHang.DataSource = null;
            }

            connection.Close();

            dinhDangLuoi();
        }
        private bool error()
        {
            bool error = true;
            int sdt;

            if (txt_DM_MaKhachHang.Text == "")
            {
                errorProvider1.SetError(txt_DM_MaKhachHang, "Chưa điền mã khách hàng");
                //kiemrtra = false;
                error = false;

                txt_DM_MaKhachHang.Focus();
            }


            if (txt_DM_TenKhachHang.Text == "")
            {
                errorProvider1.SetError(txt_DM_TenKhachHang, "Tên khách hàng không được để trống");
                txt_DM_TenKhachHang.Focus();
                //kiemrtra = false;
                error = false;
            }


            if (txt_DM_DiaChi.Text == "")
            {
                errorProvider1.SetError(txt_DM_DiaChi, "Vui lòng nhập địa chỉ của bạn");
                txt_DM_DiaChi.Focus();
                //kiemrtra = false;
                error = false;
            }

            if (int.TryParse(txt_DM_DIenThoai.Text, out sdt) == false)
            {
                errorProvider1.SetError(txt_DM_DIenThoai, "Sai định dạng");
                txt_DM_DIenThoai.Focus();
                //kiemrtra = false;
                error = false;
            }
            return error;
        }

        private void btn_DM_ThemKhachHang_Click(object sender, EventArgs e)
        {


            status = true;
            btn_DM_ThemKhachHang.Enabled = false;
            txt_DM_MaKhachHang.Focus();
            btn_DM_SuaKhachHang.Enabled = false;
            btn_DM_XoaKhachHang.Enabled = false;
            btn_DM_HuyKhachHang.Enabled = true;
            btn_DM_LuuKhachHang.Enabled = true;
            txt_DM_MaKhachHang.Enabled = true;
            txt_DM_TenKhachHang.Enabled = true;
            txt_DM_DiaChi.Enabled = true;
            txt_DM_DIenThoai.Enabled = true;
            txt_DM_MaKhachHang.Text = "";
            txt_DM_TenKhachHang.Text = "";
            txt_DM_DiaChi.Text = "";
            txt_DM_DIenThoai.Text = "";

        }
        private void addCustomer()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strCon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "insert KhachHang" + " values ( '" + txt_DM_MaKhachHang.Text.Trim() + "', N'" + txt_DM_TenKhachHang.Text.Trim() + "',  N'" + txt_DM_DiaChi.Text.Trim() + "',  " + Convert.ToDecimal(txt_DM_DIenThoai.Text.Trim()) + ")";

                SqlCommand command = new SqlCommand(query, connection);

                var result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Insert success");
                    LoadData();
                }
                //else
                //{

                //    MessageBox.Show("Insert error");
                //}

                LoadData();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }



        private void editStudent()
        {
            try
            {
                SqlConnection connection = new SqlConnection(strCon);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }


                string query = "update KhachHang" + " set  tenkhachHang = N'" + txt_DM_TenKhachHang.Text.Trim() + "', diaChi = '" + txt_DM_TenKhachHang.Text.Trim() + "', soDienThoai = " + Convert.ToDecimal(txt_DM_DIenThoai.Text.Trim()) + " where id = " + txt_DM_MaKhachHang.Text.Trim() + "";

                SqlCommand command = new SqlCommand(query, connection);

                var result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Update success");
                    LoadData();
                    state = true;
                }
                else
                {
                    MessageBox.Show("Update error");
                    state = false;
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void btn_DM_SuaKhachHang_Click(object sender, EventArgs e)
        {
            status = false;
            btn_DM_ThemKhachHang.Enabled = false;
            btn_DM_SuaKhachHang.Enabled = false;
            btn_DM_XoaKhachHang.Enabled = false;
            txt_DM_MaKhachHang.Enabled = true;
            txt_DM_TenKhachHang.Focus();
            txt_DM_TenKhachHang.Enabled = true;
            txt_DM_DiaChi.Enabled = true;
            txt_DM_DIenThoai.Enabled = true;
            btn_DM_HuyKhachHang.Enabled = true;
            btn_DM_LuuKhachHang.Enabled = true;

        }

        private void dgvDM_Main_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sdt;
            int i = dgvDM_Main_KhachHang.CurrentCell.RowIndex;
            if (i >= 0)
            {
                txt_DM_MaKhachHang.Text = dgvDM_Main_KhachHang.Rows[i].Cells[0].Value.ToString();
                txt_DM_TenKhachHang.Text = dgvDM_Main_KhachHang.Rows[i].Cells[1].Value.ToString();
                txt_DM_DiaChi.Text = dgvDM_Main_KhachHang.Rows[i].Cells[2].Value.ToString();
                if (int.TryParse(dgvDM_Main_KhachHang.Rows[i].Cells[3].Value.ToString(), out sdt))
                {
                    txt_DM_DIenThoai.Text = sdt.ToString();

                }
                else { }
            }
        }
        private void btn_DM_XoaKhachHang_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    SqlConnection connection = new SqlConnection(strCon);
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    string query = "Delete from KhachHang where id = '" + txt_DM_MaKhachHang.Text + "'";


                    SqlCommand command = new SqlCommand(query, connection);


                    var result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Delete success");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Delete error");
                    }
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btn_DM_HuyKhachHang_Click(object sender, EventArgs e)
        {
            txt_DM_MaKhachHang.Text = "";
            txt_DM_TenKhachHang.Text = "";
            txt_DM_DiaChi.Text = "";
            txt_DM_DIenThoai.Text = "";
            btn_DM_ThemKhachHang.Enabled = true;
            status = true;
            btn_DM_SuaKhachHang.Enabled = true;
            btn_DM_XoaKhachHang.Enabled = true;
            btn_DM_HuyKhachHang.Enabled = false;
            btn_DM_LuuKhachHang.Enabled = false;
            txt_DM_TimKiem.Text = "";
            rdo_DM_TheoMa.Checked = false;
            rdo_DM_TheoTen.Checked = false;
        }
        private void dinhDangLuoi()
        {
            dgvDM_Main_KhachHang.Columns[0].HeaderText = "Mã Khách Hàng";
            dgvDM_Main_KhachHang.Columns[0].Width = 130;
            dgvDM_Main_KhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
            dgvDM_Main_KhachHang.Columns[1].Width = 200;
            dgvDM_Main_KhachHang.Columns[2].HeaderText = "Địa Chỉ";
            dgvDM_Main_KhachHang.Columns[2].Width = 250;
            dgvDM_Main_KhachHang.Columns[3].HeaderText = "Điện Thoại";
            dgvDM_Main_KhachHang.Columns[3].Width = 150;
        }
        private void btnDM_TimKiem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_DM_LuuKhachHang_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (error() == false)
            {
                error();
            }
            else
            {
                if (status == true)
                {

                    addCustomer();
                    btn_DM_LuuKhachHang.Enabled = false;
                    btn_DM_HuyKhachHang.Enabled = false;

                }
                else
                {
                    editStudent();


                    if (state == false)
                    {
                        btn_DM_LuuKhachHang.Enabled = true;
                        btn_DM_HuyKhachHang.Enabled = true;
                        btn_DM_ThemKhachHang.Enabled = false;
                        btn_DM_SuaKhachHang.Enabled = false;
                        btn_DM_XoaKhachHang.Enabled = false;
                    }
                    else
                    {
                        btn_DM_LuuKhachHang.Enabled = false;
                        btn_DM_HuyKhachHang.Enabled = false;
                        btn_DM_ThemKhachHang.Enabled = true;
                        btn_DM_SuaKhachHang.Enabled = true;
                        btn_DM_XoaKhachHang.Enabled = true;
                    }
                }


            }
        }

        private void dgvDM_Main_KhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int sdt;
            int i = dgvDM_Main_KhachHang.CurrentCell.RowIndex;
            if (i >= 0)
            {
                txt_DM_MaKhachHang.Text = dgvDM_Main_KhachHang.Rows[i].Cells[0].Value.ToString();
                txt_DM_TenKhachHang.Text = dgvDM_Main_KhachHang.Rows[i].Cells[1].Value.ToString();
                txt_DM_DiaChi.Text = dgvDM_Main_KhachHang.Rows[i].Cells[2].Value.ToString();
                if (int.TryParse(dgvDM_Main_KhachHang.Rows[i].Cells[3].Value.ToString(), out sdt))
                {
                    txt_DM_DIenThoai.Text = sdt.ToString();

                }
            }
        }

        private void txt_DM_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdo_DM_TheoMa.Checked == false && rdo_DM_TheoTen.Checked == false)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dgvDM_Main_KhachHang.DataSource;
                bindingSource.Filter = string.Format("id LIKE '%{0}%' OR [tenKhachHang] LIKE '%{0}%'", txt_DM_TimKiem.Text);
                dgvDM_Main_KhachHang.DataSource = bindingSource;
            }
            if (rdo_DM_TheoMa.Checked == true)
            {
                string rowFilter = string.Format("{0} like '{1}'", "id", "*" + txt_DM_TimKiem.Text + "*");
                (dgvDM_Main_KhachHang.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            else if (rdo_DM_TheoTen.Checked == true)
            {
                string rowFilter = string.Format("{0} like '{1}'", "tenKhachHang", "*" + txt_DM_TimKiem.Text + "*");
                (dgvDM_Main_KhachHang.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }



        }
    }
}



