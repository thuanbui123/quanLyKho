﻿
namespace quanLyKho
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.lblNhapLaiMatKhauMoi = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMatKhauMoi = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCapNhatMatKhau = new System.Windows.Forms.Label();
            this.btnXemMatKhauCu = new System.Windows.Forms.Button();
            this.btnXemMatKhauMoi = new System.Windows.Forms.Button();
            this.btnXemMatKhauXacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(41, 51);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(105, 19);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = true;
            this.lblMatKhauCu.Location = new System.Drawing.Point(41, 100);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(91, 19);
            this.lblMatKhauCu.TabIndex = 1;
            this.lblMatKhauCu.Text = "Mật khẩu cũ";
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Location = new System.Drawing.Point(41, 149);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(102, 19);
            this.lblMatKhauMoi.TabIndex = 2;
            this.lblMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // lblNhapLaiMatKhauMoi
            // 
            this.lblNhapLaiMatKhauMoi.AutoSize = true;
            this.lblNhapLaiMatKhauMoi.Location = new System.Drawing.Point(41, 197);
            this.lblNhapLaiMatKhauMoi.Name = "lblNhapLaiMatKhauMoi";
            this.lblNhapLaiMatKhauMoi.Size = new System.Drawing.Size(160, 19);
            this.lblNhapLaiMatKhauMoi.TabIndex = 3;
            this.lblNhapLaiMatKhauMoi.Text = "Nhập lại mật khẩu mới";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(248, 48);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(262, 27);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(248, 97);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(262, 27);
            this.txtMatKhauCu.TabIndex = 5;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            this.txtMatKhauCu.TextChanged += new System.EventHandler(this.txtMatKhauCu_TextChanged);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(248, 146);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(262, 27);
            this.txtMatKhauMoi.TabIndex = 6;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            this.txtMatKhauMoi.TextChanged += new System.EventHandler(this.txtMatKhauMoi_TextChanged);
            // 
            // txtNhapLaiMatKhauMoi
            // 
            this.txtNhapLaiMatKhauMoi.Location = new System.Drawing.Point(248, 194);
            this.txtNhapLaiMatKhauMoi.Name = "txtNhapLaiMatKhauMoi";
            this.txtNhapLaiMatKhauMoi.Size = new System.Drawing.Size(262, 27);
            this.txtNhapLaiMatKhauMoi.TabIndex = 7;
            this.txtNhapLaiMatKhauMoi.UseSystemPasswordChar = true;
            this.txtNhapLaiMatKhauMoi.TextChanged += new System.EventHandler(this.txtNhapLaiMatKhauMoi_TextChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(248, 243);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(95, 40);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Lưu";
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(415, 243);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 40);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblCapNhatMatKhau
            // 
            this.lblCapNhatMatKhau.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapNhatMatKhau.ForeColor = System.Drawing.Color.Navy;
            this.lblCapNhatMatKhau.Location = new System.Drawing.Point(12, 9);
            this.lblCapNhatMatKhau.Name = "lblCapNhatMatKhau";
            this.lblCapNhatMatKhau.Size = new System.Drawing.Size(498, 27);
            this.lblCapNhatMatKhau.TabIndex = 10;
            this.lblCapNhatMatKhau.Text = "CẬP NHẬT MẬT KHẨU\r\n";
            this.lblCapNhatMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXemMatKhauCu
            // 
            this.btnXemMatKhauCu.Image = ((System.Drawing.Image)(resources.GetObject("btnXemMatKhauCu.Image")));
            this.btnXemMatKhauCu.Location = new System.Drawing.Point(519, 79);
            this.btnXemMatKhauCu.Name = "btnXemMatKhauCu";
            this.btnXemMatKhauCu.Size = new System.Drawing.Size(60, 45);
            this.btnXemMatKhauCu.TabIndex = 11;
            this.btnXemMatKhauCu.UseVisualStyleBackColor = true;
            this.btnXemMatKhauCu.Click += new System.EventHandler(this.btnXemMatKhauCu_Click);
            // 
            // btnXemMatKhauMoi
            // 
            this.btnXemMatKhauMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnXemMatKhauMoi.Image")));
            this.btnXemMatKhauMoi.Location = new System.Drawing.Point(519, 128);
            this.btnXemMatKhauMoi.Name = "btnXemMatKhauMoi";
            this.btnXemMatKhauMoi.Size = new System.Drawing.Size(60, 45);
            this.btnXemMatKhauMoi.TabIndex = 12;
            this.btnXemMatKhauMoi.UseVisualStyleBackColor = true;
            this.btnXemMatKhauMoi.Click += new System.EventHandler(this.btnXemMatKhauMoi_Click);
            // 
            // btnXemMatKhauXacNhan
            // 
            this.btnXemMatKhauXacNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXemMatKhauXacNhan.Image")));
            this.btnXemMatKhauXacNhan.Location = new System.Drawing.Point(519, 176);
            this.btnXemMatKhauXacNhan.Name = "btnXemMatKhauXacNhan";
            this.btnXemMatKhauXacNhan.Size = new System.Drawing.Size(60, 45);
            this.btnXemMatKhauXacNhan.TabIndex = 13;
            this.btnXemMatKhauXacNhan.UseVisualStyleBackColor = true;
            this.btnXemMatKhauXacNhan.Click += new System.EventHandler(this.btnXemMatKhauXacNhan_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 293);
            this.Controls.Add(this.btnXemMatKhauXacNhan);
            this.Controls.Add(this.btnXemMatKhauMoi);
            this.Controls.Add(this.btnXemMatKhauCu);
            this.Controls.Add(this.lblCapNhatMatKhau);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtNhapLaiMatKhauMoi);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblNhapLaiMatKhauMoi);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.lblMatKhauCu);
            this.Controls.Add(this.lblTenDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.Label lblNhapLaiMatKhauMoi;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhauMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblCapNhatMatKhau;
        private System.Windows.Forms.Button btnXemMatKhauXacNhan;
        private System.Windows.Forms.Button btnXemMatKhauMoi;
        private System.Windows.Forms.Button btnXemMatKhauCu;
    }
}