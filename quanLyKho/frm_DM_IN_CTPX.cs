﻿using Microsoft.Reporting.WinForms;
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
    public partial class frm_DM_IN_CTPX : Form
    {
        public frm_DM_IN_CTPX()
        {
            InitializeComponent();
        }

        private void frm_DM_IN_CTPX_Load(object sender, EventArgs e)
        {
            string query = "Select hh.tenHangHoa, hh.donViTinh, ctpx.soLuongXuat, ctpx.donGiaXuat,ctpx.idXuat , ctpx.soLuongXuat * ctpx.donGiaXuat as thanhTien,kh.tenKhachHang,kh.soDienThoai,kh.diaChi " +
                " from chiTietPhieuXuat as ctpx, kho as k, hangHoa as hh, phieuXuat as px,khachHang as kh" +
               " where  kh.id = px.idKhachHang and ctpx.idKho = k.id and ctpx.idPhieuXuat = px.soPhieuXuat and k.idHangHoa = hh.id and ctpx.idPhieuXuat = '" + GlobalDataChiTietHoaDonXuat.soHoaDon + "'";

            DataTable dt = DataProvider.Instance.executeQuery(query);




            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanLyKho.Report_DM_CTPX.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
