﻿
namespace quanLyKho
{
    partial class frm_BCTK_XuatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BCTK_XuatHang));
            this.pnl_BaoCaoHangDaBan = new System.Windows.Forms.Panel();
            this.lbl_BaoCaoHangDaBan = new System.Windows.Forms.Label();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.txtTimKiemHoaDon = new System.Windows.Forms.TextBox();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.chkHoaDon = new System.Windows.Forms.CheckBox();
            this.txtTimKiemKhachHang = new System.Windows.Forms.TextBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.chkKhachHang = new System.Windows.Forms.CheckBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.pnl_BaoCaoHangDaBan.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_BaoCaoHangDaBan
            // 
            this.pnl_BaoCaoHangDaBan.Controls.Add(this.lbl_BaoCaoHangDaBan);
            this.pnl_BaoCaoHangDaBan.Location = new System.Drawing.Point(12, 4);
            this.pnl_BaoCaoHangDaBan.Name = "pnl_BaoCaoHangDaBan";
            this.pnl_BaoCaoHangDaBan.Size = new System.Drawing.Size(1067, 34);
            this.pnl_BaoCaoHangDaBan.TabIndex = 0;
            // 
            // lbl_BaoCaoHangDaBan
            // 
            this.lbl_BaoCaoHangDaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_BaoCaoHangDaBan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BaoCaoHangDaBan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_BaoCaoHangDaBan.Location = new System.Drawing.Point(0, 0);
            this.lbl_BaoCaoHangDaBan.Name = "lbl_BaoCaoHangDaBan";
            this.lbl_BaoCaoHangDaBan.Size = new System.Drawing.Size(1067, 34);
            this.lbl_BaoCaoHangDaBan.TabIndex = 0;
            this.lbl_BaoCaoHangDaBan.Text = "BÁO CÁO HÀNG ĐÃ BÁN";
            this.lbl_BaoCaoHangDaBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnHuy);
            this.grbChucNang.Controls.Add(this.btnIn);
            this.grbChucNang.Controls.Add(this.btnThucHien);
            this.grbChucNang.Controls.Add(this.txtTimKiemHoaDon);
            this.grbChucNang.Controls.Add(this.lblHoaDon);
            this.grbChucNang.Controls.Add(this.chkHoaDon);
            this.grbChucNang.Controls.Add(this.txtTimKiemKhachHang);
            this.grbChucNang.Controls.Add(this.lblKhachHang);
            this.grbChucNang.Controls.Add(this.chkKhachHang);
            this.grbChucNang.Controls.Add(this.dtpDenNgay);
            this.grbChucNang.Controls.Add(this.lblDenNgay);
            this.grbChucNang.Controls.Add(this.dtpTuNgay);
            this.grbChucNang.Controls.Add(this.lblTuNgay);
            this.grbChucNang.Location = new System.Drawing.Point(12, 44);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(213, 504);
            this.grbChucNang.TabIndex = 1;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(42, 452);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(126, 50);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(42, 396);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(126, 50);
            this.btnIn.TabIndex = 11;
            this.btnIn.Text = "In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.Image")));
            this.btnThucHien.Location = new System.Drawing.Point(42, 340);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(126, 50);
            this.btnThucHien.TabIndex = 10;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // txtTimKiemHoaDon
            // 
            this.txtTimKiemHoaDon.Enabled = false;
            this.txtTimKiemHoaDon.Location = new System.Drawing.Point(6, 308);
            this.txtTimKiemHoaDon.Name = "txtTimKiemHoaDon";
            this.txtTimKiemHoaDon.Size = new System.Drawing.Size(196, 30);
            this.txtTimKiemHoaDon.TabIndex = 9;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Location = new System.Drawing.Point(6, 276);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(78, 22);
            this.lblHoaDon.TabIndex = 8;
            this.lblHoaDon.Text = "Hóa đơn";
            // 
            // chkHoaDon
            // 
            this.chkHoaDon.AutoSize = true;
            this.chkHoaDon.Location = new System.Drawing.Point(6, 247);
            this.chkHoaDon.Name = "chkHoaDon";
            this.chkHoaDon.Size = new System.Drawing.Size(140, 26);
            this.chkHoaDon.TabIndex = 7;
            this.chkHoaDon.Text = "Theo hóa đơn";
            this.chkHoaDon.UseVisualStyleBackColor = true;
            this.chkHoaDon.CheckedChanged += new System.EventHandler(this.chkHoaDon_CheckedChanged);
            // 
            // txtTimKiemKhachHang
            // 
            this.txtTimKiemKhachHang.Enabled = false;
            this.txtTimKiemKhachHang.Location = new System.Drawing.Point(6, 211);
            this.txtTimKiemKhachHang.Name = "txtTimKiemKhachHang";
            this.txtTimKiemKhachHang.Size = new System.Drawing.Size(196, 30);
            this.txtTimKiemKhachHang.TabIndex = 6;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(6, 179);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(101, 22);
            this.lblKhachHang.TabIndex = 5;
            this.lblKhachHang.Text = "Khách hàng";
            // 
            // chkKhachHang
            // 
            this.chkKhachHang.AutoSize = true;
            this.chkKhachHang.Location = new System.Drawing.Point(6, 150);
            this.chkKhachHang.Name = "chkKhachHang";
            this.chkKhachHang.Size = new System.Drawing.Size(163, 26);
            this.chkKhachHang.TabIndex = 4;
            this.chkKhachHang.Text = "Theo khách hàng";
            this.chkKhachHang.UseVisualStyleBackColor = true;
            this.chkKhachHang.CheckedChanged += new System.EventHandler(this.chkKhachHang_CheckedChanged);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(6, 116);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 30);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(6, 94);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(83, 22);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(6, 56);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 30);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(6, 34);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(74, 22);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvMain);
            this.pnlMain.Location = new System.Drawing.Point(231, 44);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(865, 487);
            this.pnlMain.TabIndex = 2;
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(6, 6);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.Size = new System.Drawing.Size(850, 470);
            this.dgvMain.TabIndex = 3;
            // 
            // frm_BCTK_XuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1099, 549);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.pnl_BaoCaoHangDaBan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BCTK_XuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thống kê hàng đã bán";
            this.Load += new System.EventHandler(this.frm_BCTK_XuatHang_Load);
            this.pnl_BaoCaoHangDaBan.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.grbChucNang.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_BaoCaoHangDaBan;
        private System.Windows.Forms.Label lbl_BaoCaoHangDaBan;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.TextBox txtTimKiemHoaDon;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.CheckBox chkHoaDon;
        private System.Windows.Forms.TextBox txtTimKiemKhachHang;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.CheckBox chkKhachHang;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvMain;
    }
}