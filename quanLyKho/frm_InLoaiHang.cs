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
    public partial class frm_InLoaiHang : Form
    {
        public frm_InLoaiHang()
        {
            InitializeComponent();
        }

        private void frm_InLoaiHang_Load(object sender, EventArgs e)
        {
            string query = "SELECT lh.id,lh.tenLoai,lh.dienGiai from loaiHang as lh";
            DataTable dt = DataProvider.Instance.executeQuery(query);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanLyKho.ReportLoaiHang.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
