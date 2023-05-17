namespace quanLyKho
{
    partial class frm_BCTK_BaoCaoNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BCTK_BaoCaoNhapKho));
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTheoHoaDon = new System.Windows.Forms.ComboBox();
            this.cboTheoNhaCungCap = new System.Windows.Forms.ComboBox();
            this.chkTheoHoaDon = new System.Windows.Forms.CheckBox();
            this.chkTheoNhaCungCap = new System.Windows.Forms.CheckBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(310, 20);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 62;
            this.dgvMain.RowTemplate.Height = 28;
            this.dgvMain.Size = new System.Drawing.Size(861, 557);
            this.dgvMain.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.btnThucHien);
            this.groupBox1.Controls.Add(this.cboTheoHoaDon);
            this.groupBox1.Controls.Add(this.cboTheoNhaCungCap);
            this.groupBox1.Controls.Add(this.chkTheoHoaDon);
            this.groupBox1.Controls.Add(this.chkTheoNhaCungCap);
            this.groupBox1.Controls.Add(this.dtpDenNgay);
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Controls.Add(this.lblDenNgay);
            this.groupBox1.Controls.Add(this.lblTuNgay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 619);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // cboTheoHoaDon
            // 
            this.cboTheoHoaDon.FormattingEnabled = true;
            this.cboTheoHoaDon.Location = new System.Drawing.Point(21, 351);
            this.cboTheoHoaDon.Name = "cboTheoHoaDon";
            this.cboTheoHoaDon.Size = new System.Drawing.Size(235, 28);
            this.cboTheoHoaDon.TabIndex = 3;
            // 
            // cboTheoNhaCungCap
            // 
            this.cboTheoNhaCungCap.FormattingEnabled = true;
            this.cboTheoNhaCungCap.Location = new System.Drawing.Point(21, 269);
            this.cboTheoNhaCungCap.Name = "cboTheoNhaCungCap";
            this.cboTheoNhaCungCap.Size = new System.Drawing.Size(235, 28);
            this.cboTheoNhaCungCap.TabIndex = 3;
            // 
            // chkTheoHoaDon
            // 
            this.chkTheoHoaDon.AutoSize = true;
            this.chkTheoHoaDon.Checked = true;
            this.chkTheoHoaDon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTheoHoaDon.Location = new System.Drawing.Point(21, 312);
            this.chkTheoHoaDon.Name = "chkTheoHoaDon";
            this.chkTheoHoaDon.Size = new System.Drawing.Size(145, 24);
            this.chkTheoHoaDon.TabIndex = 2;
            this.chkTheoHoaDon.Text = "Theo hóa đơn";
            this.chkTheoHoaDon.UseVisualStyleBackColor = true;
            // 
            // chkTheoNhaCungCap
            // 
            this.chkTheoNhaCungCap.AutoSize = true;
            this.chkTheoNhaCungCap.Checked = true;
            this.chkTheoNhaCungCap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTheoNhaCungCap.Location = new System.Drawing.Point(21, 230);
            this.chkTheoNhaCungCap.Name = "chkTheoNhaCungCap";
            this.chkTheoNhaCungCap.Size = new System.Drawing.Size(188, 24);
            this.chkTheoNhaCungCap.TabIndex = 2;
            this.chkTheoNhaCungCap.Text = "Theo nhà cung cấp";
            this.chkTheoNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(6, 158);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(266, 26);
            this.dtpDenNgay.TabIndex = 1;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(6, 70);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(266, 26);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(17, 125);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(85, 20);
            this.lblDenNgay.TabIndex = 0;
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(17, 38);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(72, 20);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(63, 475);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(146, 72);
            this.btnIn.TabIndex = 12;
            this.btnIn.Text = "In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Image = ((System.Drawing.Image)(resources.GetObject("btnThucHien.Image")));
            this.btnThucHien.Location = new System.Drawing.Point(63, 397);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(146, 72);
            this.btnThucHien.TabIndex = 11;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThucHien.UseVisualStyleBackColor = true;
            // 
            // frm_BCTK_BaoCaoNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 658);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_BCTK_BaoCaoNhapKho";
            this.Text = "Báo cáo nhập kho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.ComboBox cboTheoHoaDon;
        private System.Windows.Forms.ComboBox cboTheoNhaCungCap;
        private System.Windows.Forms.CheckBox chkTheoHoaDon;
        private System.Windows.Forms.CheckBox chkTheoNhaCungCap;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
    }
}