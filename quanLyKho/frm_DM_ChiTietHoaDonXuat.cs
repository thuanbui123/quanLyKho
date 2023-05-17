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
    public partial class frm_DM_ChiTietHoaDonXuat : Form
    {
        public frm_DM_ChiTietHoaDonXuat()
        {
            InitializeComponent();
            loadDuLieuLenLuoi();



        }

        public void loadDuLieuLenLuoi()
        {
            string query = "Select hh.tenHangHoa, hh.donViTinh, ctpx.soLuongXuat, ctpx.donGiaXuat from chiTietPhieuXuat as ctpx, kho as k, hangHoa as hh, phieuXuat as px where ctpx.idKho = k.id and ctpx.idPhieuXuat = px.soPhieuXuat and k.idHangHoa = hh.id";

            DataTable data = getData(query);

            dgv_Main_DonXuat.DataSource = data;
            dinhDangLuoi();
        }

        private DataTable getData(string query)
        {
            DataTable data;

            data = DataProvider.Instance.executeQuery(query);

            return data;
        }

        private void dinhDangLuoi()
        {
            dgv_Main_DonXuat.Columns[0].HeaderText = "Tên hàng hóa";
            dgv_Main_DonXuat.Columns[0].Width = 300;
            dgv_Main_DonXuat.Columns[1].HeaderText = "Đơn vị tính";
            dgv_Main_DonXuat.Columns[1].Width = 200;
            dgv_Main_DonXuat.Columns[2].HeaderText = "Số lượng";
            dgv_Main_DonXuat.Columns[2].Width = 200;
            dgv_Main_DonXuat.Columns[3].HeaderText = "Đơn giá";
            dgv_Main_DonXuat.Columns[3].Width = 250;

        }

        private void btn_DM_ThemDonXuat_Click(object sender, EventArgs e)
        {


            btn_DM_ThemDonXuat.Enabled = false;
            txt_DonGia.Focus();
            btn_DM_SuaDonXuat.Enabled = false;
            btn_DM_XoaDonXuat.Enabled = false;
            btn_DM_HuyDonXuat.Enabled = true;
            btn_DM_InDonXuat.Enabled = true;

            txt_DonGia.Enabled = true;
            txt_GiaGoc.Enabled = true;
            txt_SoLuong.Enabled = true;
            txt_SoLuongKho.Enabled = true;
            txt_SoLuongKho.Text = "";
            txt_SoLuong.Text = "";
            txt_GiaGoc.Text = "";
            txt_DonGia.Text = "";

        }
        private void addCustomer()
        {
            try
            {
                string query = "insert chiTietPhieuXuat" + " values ( '" + Convert.ToDecimal(txt_DonGia.Text.Trim()) + "" + Convert.ToDecimal(txt_SoLuongKho.Text.Trim()) + "" + Convert.ToDecimal(txt_GiaGoc.Text.Trim()) + "',  " + Convert.ToDecimal(txt_SoLuong.Text.Trim()) + ")";
                int i = DataProvider.Instance.executeNonQuery(query);
                if (i > 0)
                {
                    MessageBox.Show("thành công");
                    loadDuLieuLenLuoi();
                }
                else
                {

                }
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



                string query = "update KhachHang" + " set  tenkhachHang = N'" + txt_SoLuong.Text.Trim() + "', diaChi = '" + txt_SoLuongKho.Text.Trim() + "', soDienThoai = " + Convert.ToDecimal(txt_DonGia.Text.Trim()) + " where id = " + txt_GiaGoc.Text.Trim() + "";
                int i = DataProvider.Instance.executeNonQuery(query);

                if (i > 0)
                {
                    MessageBox.Show("thành công");
                    loadDuLieuLenLuoi();
                }
                else
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void bnt_DM_LuuDonXuat_Click(object sender, EventArgs e)
        {
            addCustomer();
        }
    }
}
