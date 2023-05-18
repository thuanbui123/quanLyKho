﻿using System;
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
    public partial class frm_DM_TaoHoaDonXuat : Form
    {
        public frm_DM_TaoHoaDonXuat()
        {
            InitializeComponent();
            LoadData();
        }
        bool status;
        bool state = true;
        bool state1 = false;
        private void frm_DM_TaoHoaDonXuat_Load(object sender, EventArgs e)
        {
            txt_DM_SoHoaDon.Text = dgvDM_Main_DonXuat.Rows[0].Cells[0].Value.ToString();
            txt_DM_KhachHang.Text = dgvDM_Main_DonXuat.Rows[0].Cells[1].Value.ToString();
            dtp_DM_NgayTaoHD.Value = Convert.ToDateTime(dgvDM_Main_DonXuat.Rows[0].Cells[2].Value.ToString());
        }
        public static string strCon = @"Data Source=DESKTOP-02VJS88\DUY;Initial Catalog=quanLyKho;Integrated Security=True";
        private DataSet ds;

        public void LoadData()
        {
            SqlConnection connection = new SqlConnection(strCon);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string query = "Select phieuXuat.soPhieuXuat,khachHang.tenKhachHang,phieuXuat.ngayLap_Xuat from phieuXuat, khachHang where phieuXuat.idKhachHang=khachHang.id ";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 || ds.Tables[0].Rows.Count > 0)
            {
                dgvDM_Main_DonXuat.DataSource = ds.Tables[0];
            }
            else
            {
                dgvDM_Main_DonXuat.DataSource = null;
            }

            connection.Close();

            dinhDangLuoi();
        }
        private void dinhDangLuoi()
        {
            dgvDM_Main_DonXuat.Columns[0].HeaderText = "Số chứng từ xuất ";
            dgvDM_Main_DonXuat.Columns[0].Width = 130;
            dgvDM_Main_DonXuat.Columns[1].HeaderText = "Tên Khách Hàng";
            dgvDM_Main_DonXuat.Columns[1].Width = 200;
            dgvDM_Main_DonXuat.Columns[2].HeaderText = "Ngày xuất";
            dgvDM_Main_DonXuat.Columns[2].Width = 250;
        }
        private bool error()
        {
            bool error = true;
            int sdt;
            if (txt_DM_SoHoaDon.Text == "")
            {
                errorProvider1.SetError(txt_DM_SoHoaDon, "Chưa điền số hóa đơn");
                error = false;
                txt_DM_SoHoaDon.Focus();
            }
            if (txt_DM_KhachHang.Text == "")
            {
                errorProvider1.SetError(txt_DM_KhachHang, "Tên khách hàng không được để trống");
                txt_DM_KhachHang.Focus();
                error = false;
            }
            return error;
        }
        private void btn_DM_ThemDonXuat_Click(object sender, EventArgs e)
        {
            status = true;
            btn_DM_ThemDonXuat.Enabled = false;
            txt_DM_SoHoaDon.Focus();
            btn_DM_SuaDonXuat.Enabled = false;
            btn_DM_XoaDonXuat.Enabled = false;
            btn_DM_HuyDonXuat.Enabled = true;
            btn_DM_LuuDonXuat.Enabled = true;
            btn_DM_XuatHoaDon.Enabled = false;
            txt_DM_SoHoaDon.Enabled = true;
            txt_DM_KhachHang.Enabled = true;
            dtp_DM_NgayTaoHD.Enabled = true;
            txt_DM_SoHoaDon.Text = "";
            txt_DM_KhachHang.Text = "";

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

                string query1 = "Select kh.id from khachHang as kh where tenKhachHang = N'" + txt_DM_KhachHang.Text.Trim() + "'";
                SqlCommand command = new SqlCommand(query1, connection);
                object idKhachHang = command.ExecuteScalar();

                string query = "insert into phieuXuat " + " values ( '" + txt_DM_SoHoaDon.Text.Trim() + "', '" + idKhachHang + "', '" + dtp_DM_NgayTaoHD.Value.ToString("yyyy-MM-dd") + "')";

                command = new SqlCommand(query, connection);

                var result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Insert success");
                    state1 = true;
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Insert error");
                    state1 = false;
                }
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

                string query1 = "Select kh.id from khachHang as kh where tenKhachHang = N'" + txt_DM_KhachHang.Text.Trim() + "'";
                SqlCommand command = new SqlCommand(query1, connection);
                object idKhachHang = command.ExecuteScalar();
                string query = "update phieuXuat set  idkhachHang = N'" + idKhachHang + "', ngayLap_Xuat = '" + dtp_DM_NgayTaoHD.Value.ToString("yyyy-MM-dd") + "' where soPhieuXuat = '" + txt_DM_SoHoaDon.Text.Trim() + "'";
                command = new SqlCommand(query, connection);

                var result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Update success");
                    LoadData();
                    state1 = true;
                }
                else
                {
                    MessageBox.Show("Update error");
                    state1 = false;
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_DM_LuuDonXuat_Click(object sender, EventArgs e)
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
                    if (state1)
                    {
                        btn_DM_LuuDonXuat.Enabled = false;
                        btn_DM_HuyDonXuat.Enabled = false;
                        btn_DM_XuatHoaDon.Enabled = false;
                        btn_DM_ThemDonXuat.Enabled = true;
                        btn_DM_SuaDonXuat.Enabled = true;
                        btn_DM_XoaDonXuat.Enabled = true;
                    }
                    else
                    {
                        btn_DM_LuuDonXuat.Enabled = true;
                        btn_DM_HuyDonXuat.Enabled = true;
                        btn_DM_XuatHoaDon.Enabled = true;
                        btn_DM_ThemDonXuat.Enabled = false;
                        btn_DM_SuaDonXuat.Enabled = false;
                        btn_DM_XoaDonXuat.Enabled = false;
                    }
                }
                else
                {
                    editStudent();
                    if (state1 == true)
                    {
                        btn_DM_LuuDonXuat.Enabled = false;
                        btn_DM_HuyDonXuat.Enabled = false;
                        btn_DM_XuatHoaDon.Enabled = false;
                        btn_DM_ThemDonXuat.Enabled = true;
                        btn_DM_SuaDonXuat.Enabled = true;
                        btn_DM_XoaDonXuat.Enabled = true;
                    }
                    else
                    {
                        btn_DM_XuatHoaDon.Enabled = true;
                        btn_DM_LuuDonXuat.Enabled = true;
                        btn_DM_HuyDonXuat.Enabled = true;
                        btn_DM_ThemDonXuat.Enabled = false;
                        btn_DM_SuaDonXuat.Enabled = false;
                        btn_DM_XoaDonXuat.Enabled = false;
                    }
                }
            }
        }
        private void btn_DM_XoaDonXuat_Click(object sender, EventArgs e)
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
                    string query = "Delete from phieuXuat where soPhieuXuat = '" + txt_DM_SoHoaDon.Text + "'";
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
        private void dgvDM_Main_DonXuat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvDM_Main_DonXuat.CurrentCell.RowIndex;
            if (i >= 0)
            {
                txt_DM_SoHoaDon.Text = dgvDM_Main_DonXuat.Rows[i].Cells[0].Value.ToString();
                txt_DM_KhachHang.Text = dgvDM_Main_DonXuat.Rows[i].Cells[1].Value.ToString();
                dtp_DM_NgayTaoHD.Value = Convert.ToDateTime(dgvDM_Main_DonXuat.Rows[i].Cells[2].Value.ToString());
            }
        }
        private void btn_DM_SuaDonXuat_Click(object sender, EventArgs e)
        {
            status = false;
            btn_DM_ThemDonXuat.Enabled = false;
            btn_DM_SuaDonXuat.Enabled = false;
            btn_DM_XoaDonXuat.Enabled = false;
            txt_DM_SoHoaDon.Enabled = false;
            txt_DM_KhachHang.Focus();
            dtp_DM_NgayTaoHD.Enabled = true;
            txt_DM_KhachHang.Enabled = true;
            btn_DM_LuuDonXuat.Enabled = true;
            btn_DM_HuyDonXuat.Enabled = true;
        }
        private void btn_DM_HuyDonXuat_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txt_DM_SoHoaDon.Text = "";
            txt_DM_KhachHang.Text = "";
            btn_DM_ThemDonXuat.Enabled = true;
            status = true;
            btn_DM_SuaDonXuat.Enabled = true;
            btn_DM_XoaDonXuat.Enabled = true;
            btn_DM_HuyDonXuat.Enabled = false;
            btn_DM_LuuDonXuat.Enabled = false;
        }
    }
}