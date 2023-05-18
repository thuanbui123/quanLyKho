namespace quanLyKho
{
    partial class frm_DM_ThongTinLoaiHang
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbCapNhatLoaiHang = new System.Windows.Forms.GroupBox();
            this.lblThongTinLoaiHang = new System.Windows.Forms.Label();
            this.lblMaloaiHang = new System.Windows.Forms.Label();
            this.lblTenLoaiHang = new System.Windows.Forms.Label();
            this.lblDienGiai = new System.Windows.Forms.Label();
            this.txtMaLoaiHang = new System.Windows.Forms.TextBox();
            this.txtTenLoaiHang = new System.Windows.Forms.TextBox();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.grbTrangThai = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdoTimKiemTheoTen = new System.Windows.Forms.RadioButton();
            this.rdoTimKiemTheoMa = new System.Windows.Forms.RadioButton();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbCapNhatLoaiHang.SuspendLayout();
            this.grbTrangThai.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblThongTinLoaiHang);
            this.groupBox1.Controls.Add(this.grbCapNhatLoaiHang);
            this.groupBox1.Location = new System.Drawing.Point(27, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(680, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // grbCapNhatLoaiHang
            // 
            this.grbCapNhatLoaiHang.Controls.Add(this.txtDienGiai);
            this.grbCapNhatLoaiHang.Controls.Add(this.txtTenLoaiHang);
            this.grbCapNhatLoaiHang.Controls.Add(this.txtMaLoaiHang);
            this.grbCapNhatLoaiHang.Controls.Add(this.lblDienGiai);
            this.grbCapNhatLoaiHang.Controls.Add(this.lblTenLoaiHang);
            this.grbCapNhatLoaiHang.Controls.Add(this.lblMaloaiHang);
            this.grbCapNhatLoaiHang.Location = new System.Drawing.Point(7, 74);
            this.grbCapNhatLoaiHang.Name = "grbCapNhatLoaiHang";
            this.grbCapNhatLoaiHang.Size = new System.Drawing.Size(648, 223);
            this.grbCapNhatLoaiHang.TabIndex = 0;
            this.grbCapNhatLoaiHang.TabStop = false;
            this.grbCapNhatLoaiHang.Text = "Cập nhật loại hàng ";
            // 
            // lblThongTinLoaiHang
            // 
            this.lblThongTinLoaiHang.AutoSize = true;
            this.lblThongTinLoaiHang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinLoaiHang.Location = new System.Drawing.Point(209, 27);
            this.lblThongTinLoaiHang.Name = "lblThongTinLoaiHang";
            this.lblThongTinLoaiHang.Size = new System.Drawing.Size(257, 32);
            this.lblThongTinLoaiHang.TabIndex = 1;
            this.lblThongTinLoaiHang.Text = "Thông tin loại hàng ";
            // 
            // lblMaloaiHang
            // 
            this.lblMaloaiHang.AutoSize = true;
            this.lblMaloaiHang.Location = new System.Drawing.Point(16, 46);
            this.lblMaloaiHang.Name = "lblMaloaiHang";
            this.lblMaloaiHang.Size = new System.Drawing.Size(113, 22);
            this.lblMaloaiHang.TabIndex = 0;
            this.lblMaloaiHang.Text = "Mã loại hàng";
            // 
            // lblTenLoaiHang
            // 
            this.lblTenLoaiHang.AutoSize = true;
            this.lblTenLoaiHang.Location = new System.Drawing.Point(16, 106);
            this.lblTenLoaiHang.Name = "lblTenLoaiHang";
            this.lblTenLoaiHang.Size = new System.Drawing.Size(122, 22);
            this.lblTenLoaiHang.TabIndex = 1;
            this.lblTenLoaiHang.Text = "Tên loại hàng ";
            // 
            // lblDienGiai
            // 
            this.lblDienGiai.AutoSize = true;
            this.lblDienGiai.Location = new System.Drawing.Point(16, 167);
            this.lblDienGiai.Name = "lblDienGiai";
            this.lblDienGiai.Size = new System.Drawing.Size(83, 22);
            this.lblDienGiai.TabIndex = 2;
            this.lblDienGiai.Text = "Diễn giải";
            // 
            // txtMaLoaiHang
            // 
            this.txtMaLoaiHang.Location = new System.Drawing.Point(140, 46);
            this.txtMaLoaiHang.Name = "txtMaLoaiHang";
            this.txtMaLoaiHang.Size = new System.Drawing.Size(368, 30);
            this.txtMaLoaiHang.TabIndex = 3;
            // 
            // txtTenLoaiHang
            // 
            this.txtTenLoaiHang.Location = new System.Drawing.Point(140, 103);
            this.txtTenLoaiHang.Name = "txtTenLoaiHang";
            this.txtTenLoaiHang.Size = new System.Drawing.Size(368, 30);
            this.txtTenLoaiHang.TabIndex = 4;
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Location = new System.Drawing.Point(140, 159);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(368, 30);
            this.txtDienGiai.TabIndex = 5;
            // 
            // grbTrangThai
            // 
            this.grbTrangThai.Controls.Add(this.btnHuy);
            this.grbTrangThai.Controls.Add(this.btnLuu);
            this.grbTrangThai.Controls.Add(this.btnSua);
            this.grbTrangThai.Controls.Add(this.btnXoa);
            this.grbTrangThai.Controls.Add(this.btnThem);
            this.grbTrangThai.Location = new System.Drawing.Point(739, 12);
            this.grbTrangThai.Name = "grbTrangThai";
            this.grbTrangThai.Size = new System.Drawing.Size(165, 319);
            this.grbTrangThai.TabIndex = 1;
            this.grbTrangThai.TabStop = false;
            this.grbTrangThai.Text = "Trạng thái ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoTimKiemTheoMa);
            this.groupBox4.Controls.Add(this.rdoTimKiemTheoTen);
            this.groupBox4.Controls.Add(this.txtTimKiem);
            this.groupBox4.Controls.Add(this.btnTimKiem);
            this.groupBox4.Location = new System.Drawing.Point(27, 337);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(877, 64);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(174, 23);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(341, 30);
            this.txtTimKiem.TabIndex = 6;
            // 
            // rdoTimKiemTheoTen
            // 
            this.rdoTimKiemTheoTen.AutoSize = true;
            this.rdoTimKiemTheoTen.Location = new System.Drawing.Point(547, 30);
            this.rdoTimKiemTheoTen.Name = "rdoTimKiemTheoTen";
            this.rdoTimKiemTheoTen.Size = new System.Drawing.Size(99, 26);
            this.rdoTimKiemTheoTen.TabIndex = 7;
            this.rdoTimKiemTheoTen.TabStop = true;
            this.rdoTimKiemTheoTen.Text = "Theo tên";
            this.rdoTimKiemTheoTen.UseVisualStyleBackColor = true;
            // 
            // rdoTimKiemTheoMa
            // 
            this.rdoTimKiemTheoMa.AutoSize = true;
            this.rdoTimKiemTheoMa.Location = new System.Drawing.Point(694, 29);
            this.rdoTimKiemTheoMa.Name = "rdoTimKiemTheoMa";
            this.rdoTimKiemTheoMa.Size = new System.Drawing.Size(99, 26);
            this.rdoTimKiemTheoMa.TabIndex = 8;
            this.rdoTimKiemTheoMa.TabStop = true;
            this.rdoTimKiemTheoMa.Text = "Theo mã";
            this.rdoTimKiemTheoMa.UseVisualStyleBackColor = true;
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(27, 431);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(877, 256);
            this.dgvMain.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::quanLyKho.Properties.Resources.Tìm_kiếm;
            this.btnTimKiem.Location = new System.Drawing.Point(7, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(146, 42);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm ";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::quanLyKho.Properties.Resources.hủy_bỏ;
            this.btnHuy.Location = new System.Drawing.Point(24, 271);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 42);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::quanLyKho.Properties.Resources.Lưu;
            this.btnLuu.Location = new System.Drawing.Point(24, 210);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 42);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::quanLyKho.Properties.Resources.Sửa;
            this.btnSua.Location = new System.Drawing.Point(24, 90);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 42);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::quanLyKho.Properties.Resources.Xóa;
            this.btnXoa.Location = new System.Drawing.Point(24, 149);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 42);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::quanLyKho.Properties.Resources.Thêm;
            this.btnThem.Location = new System.Drawing.Point(24, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 42);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // frm_DM_ThongTinLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 699);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grbTrangThai);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_DM_ThongTinLoaiHang";
            this.Text = "Thông tin loại hàng ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbCapNhatLoaiHang.ResumeLayout(false);
            this.grbCapNhatLoaiHang.PerformLayout();
            this.grbTrangThai.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblThongTinLoaiHang;
        private System.Windows.Forms.GroupBox grbCapNhatLoaiHang;
        private System.Windows.Forms.TextBox txtDienGiai;
        private System.Windows.Forms.TextBox txtTenLoaiHang;
        private System.Windows.Forms.TextBox txtMaLoaiHang;
        private System.Windows.Forms.Label lblDienGiai;
        private System.Windows.Forms.Label lblTenLoaiHang;
        private System.Windows.Forms.Label lblMaloaiHang;
        private System.Windows.Forms.GroupBox grbTrangThai;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoTimKiemTheoMa;
        private System.Windows.Forms.RadioButton rdoTimKiemTheoTen;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}