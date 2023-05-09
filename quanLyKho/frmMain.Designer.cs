
namespace quanLyKho
{
    partial class frmMain
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
            this.mnuQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXemTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKiemKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiaoDich = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXuatKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLuaChon = new System.Windows.Forms.MenuStrip();
            this.mnuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtTrangHienTai = new System.Windows.Forms.TextBox();
            this.btnTrangSau = new System.Windows.Forms.Button();
            this.btnTrangCuoi = new System.Windows.Forms.Button();
            this.btnTrangTruoc = new System.Windows.Forms.Button();
            this.btnTrangDau = new System.Windows.Forms.Button();
            this.lblTrongKho = new System.Windows.Forms.Label();
            this.dgvHangTrongKho = new System.Windows.Forms.DataGridView();
            this.mnuLuaChon.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangTrongKho)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuQuanLyTaiKhoan
            // 
            this.mnuQuanLyTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXemTaiKhoan,
            this.mnuDoiMatKhau,
            this.mnuDangXuat});
            this.mnuQuanLyTaiKhoan.Name = "mnuQuanLyTaiKhoan";
            this.mnuQuanLyTaiKhoan.Size = new System.Drawing.Size(138, 23);
            this.mnuQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            // 
            // mnuXemTaiKhoan
            // 
            this.mnuXemTaiKhoan.Name = "mnuXemTaiKhoan";
            this.mnuXemTaiKhoan.Size = new System.Drawing.Size(240, 24);
            this.mnuXemTaiKhoan.Text = "Xem thông tin tài khoản";
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(240, 24);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(240, 24);
            this.mnuDangXuat.Text = "Đăng xuất";
            // 
            // mnuHangHoa
            // 
            this.mnuHangHoa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuKiemKho});
            this.mnuHangHoa.Name = "mnuHangHoa";
            this.mnuHangHoa.Size = new System.Drawing.Size(84, 23);
            this.mnuHangHoa.Text = "Hàng hóa";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(146, 24);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuKiemKho
            // 
            this.mnuKiemKho.Name = "mnuKiemKho";
            this.mnuKiemKho.Size = new System.Drawing.Size(146, 24);
            this.mnuKiemKho.Text = "Kiểm kho";
            // 
            // mnuGiaoDich
            // 
            this.mnuGiaoDich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhapKho,
            this.mnuXuatKho});
            this.mnuGiaoDich.Name = "mnuGiaoDich";
            this.mnuGiaoDich.Size = new System.Drawing.Size(87, 23);
            this.mnuGiaoDich.Text = "Giao dịch";
            // 
            // mnuNhapKho
            // 
            this.mnuNhapKho.Name = "mnuNhapKho";
            this.mnuNhapKho.Size = new System.Drawing.Size(142, 24);
            this.mnuNhapKho.Text = "Nhập kho";
            // 
            // mnuXuatKho
            // 
            this.mnuXuatKho.Name = "mnuXuatKho";
            this.mnuXuatKho.Size = new System.Drawing.Size(142, 24);
            this.mnuXuatKho.Text = "Xuất kho";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuNhaCungCap,
            this.mnuKhachHang});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(66, 23);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(168, 24);
            this.mnuNhanVien.Text = "Nhân viên";
            // 
            // mnuNhaCungCap
            // 
            this.mnuNhaCungCap.Name = "mnuNhaCungCap";
            this.mnuNhaCungCap.Size = new System.Drawing.Size(168, 24);
            this.mnuNhaCungCap.Text = "Nhà cung cấp";
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(168, 24);
            this.mnuKhachHang.Text = "Khách hàng";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(76, 23);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuLuaChon
            // 
            this.mnuLuaChon.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuLuaChon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin,
            this.mnuQuanLyTaiKhoan,
            this.mnuHangHoa,
            this.mnuGiaoDich,
            this.mnuBaoCao,
            this.mnuBanHang});
            this.mnuLuaChon.Location = new System.Drawing.Point(0, 0);
            this.mnuLuaChon.Name = "mnuLuaChon";
            this.mnuLuaChon.Size = new System.Drawing.Size(559, 27);
            this.mnuLuaChon.TabIndex = 0;
            this.mnuLuaChon.Text = "menuStrip1";
            // 
            // mnuBanHang
            // 
            this.mnuBanHang.Name = "mnuBanHang";
            this.mnuBanHang.Size = new System.Drawing.Size(82, 23);
            this.mnuBanHang.Text = "Bán hàng";
            this.mnuBanHang.Click += new System.EventHandler(this.tsmiBanHang_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.txtFilter);
            this.pnlContainer.Controls.Add(this.lblFilter);
            this.pnlContainer.Controls.Add(this.txtTrangHienTai);
            this.pnlContainer.Controls.Add(this.btnTrangSau);
            this.pnlContainer.Controls.Add(this.btnTrangCuoi);
            this.pnlContainer.Controls.Add(this.btnTrangTruoc);
            this.pnlContainer.Controls.Add(this.btnTrangDau);
            this.pnlContainer.Controls.Add(this.lblTrongKho);
            this.pnlContainer.Controls.Add(this.dgvHangTrongKho);
            this.pnlContainer.Location = new System.Drawing.Point(0, 30);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(559, 302);
            this.pnlContainer.TabIndex = 1;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(177, 7);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(374, 27);
            this.txtFilter.TabIndex = 19;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 10);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(133, 19);
            this.lblFilter.TabIndex = 18;
            this.lblFilter.Text = "Tìm kiếm theo tên";
            // 
            // txtTrangHienTai
            // 
            this.txtTrangHienTai.Location = new System.Drawing.Point(226, 265);
            this.txtTrangHienTai.Name = "txtTrangHienTai";
            this.txtTrangHienTai.Size = new System.Drawing.Size(115, 27);
            this.txtTrangHienTai.TabIndex = 17;
            this.txtTrangHienTai.Text = "1";
            this.txtTrangHienTai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTrangSau
            // 
            this.btnTrangSau.Location = new System.Drawing.Point(347, 259);
            this.btnTrangSau.Name = "btnTrangSau";
            this.btnTrangSau.Size = new System.Drawing.Size(99, 36);
            this.btnTrangSau.TabIndex = 16;
            this.btnTrangSau.Text = "Trang sau";
            this.btnTrangSau.UseVisualStyleBackColor = true;
            // 
            // btnTrangCuoi
            // 
            this.btnTrangCuoi.Location = new System.Drawing.Point(452, 259);
            this.btnTrangCuoi.Name = "btnTrangCuoi";
            this.btnTrangCuoi.Size = new System.Drawing.Size(99, 36);
            this.btnTrangCuoi.TabIndex = 15;
            this.btnTrangCuoi.Text = "Trang cuối";
            this.btnTrangCuoi.UseVisualStyleBackColor = true;
            // 
            // btnTrangTruoc
            // 
            this.btnTrangTruoc.Location = new System.Drawing.Point(121, 259);
            this.btnTrangTruoc.Name = "btnTrangTruoc";
            this.btnTrangTruoc.Size = new System.Drawing.Size(99, 36);
            this.btnTrangTruoc.TabIndex = 14;
            this.btnTrangTruoc.Text = "Trang trước";
            this.btnTrangTruoc.UseVisualStyleBackColor = true;
            // 
            // btnTrangDau
            // 
            this.btnTrangDau.Location = new System.Drawing.Point(16, 259);
            this.btnTrangDau.Name = "btnTrangDau";
            this.btnTrangDau.Size = new System.Drawing.Size(99, 36);
            this.btnTrangDau.TabIndex = 13;
            this.btnTrangDau.Text = "Trang đầu";
            this.btnTrangDau.UseVisualStyleBackColor = true;
            // 
            // lblTrongKho
            // 
            this.lblTrongKho.AutoSize = true;
            this.lblTrongKho.Location = new System.Drawing.Point(12, 41);
            this.lblTrongKho.Name = "lblTrongKho";
            this.lblTrongKho.Size = new System.Drawing.Size(141, 19);
            this.lblTrongKho.TabIndex = 12;
            this.lblTrongKho.Text = "Hàng hóa trong kho";
            // 
            // dgvHangTrongKho
            // 
            this.dgvHangTrongKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangTrongKho.Location = new System.Drawing.Point(16, 76);
            this.dgvHangTrongKho.Name = "dgvHangTrongKho";
            this.dgvHangTrongKho.Size = new System.Drawing.Size(535, 178);
            this.dgvHangTrongKho.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 335);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.mnuLuaChon);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuLuaChon;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý kho";
            this.mnuLuaChon.ResumeLayout(false);
            this.mnuLuaChon.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangTrongKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuXemTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuHangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuKiemKho;
        private System.Windows.Forms.ToolStripMenuItem mnuGiaoDich;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapKho;
        private System.Windows.Forms.ToolStripMenuItem mnuXuatKho;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.MenuStrip mnuLuaChon;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuBanHang;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtTrangHienTai;
        private System.Windows.Forms.Button btnTrangSau;
        private System.Windows.Forms.Button btnTrangCuoi;
        private System.Windows.Forms.Button btnTrangTruoc;
        private System.Windows.Forms.Button btnTrangDau;
        private System.Windows.Forms.Label lblTrongKho;
        private System.Windows.Forms.DataGridView dgvHangTrongKho;
    }
}

