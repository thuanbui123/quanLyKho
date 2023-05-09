
namespace quanLyKho
{
    partial class frmBanHang
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
            this.mnuLuaChon = new System.Windows.Forms.MenuStrip();
            this.mnuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuLuaChon
            // 
            this.mnuLuaChon.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuLuaChon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHangHoa,
            this.mnuHoaDon,
            this.mnuTimKiem,
            this.mnuBaoCao,
            this.mnuGioiThieu});
            this.mnuLuaChon.Location = new System.Drawing.Point(0, 0);
            this.mnuLuaChon.Name = "mnuLuaChon";
            this.mnuLuaChon.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnuLuaChon.Size = new System.Drawing.Size(770, 29);
            this.mnuLuaChon.TabIndex = 0;
            this.mnuLuaChon.Text = "menuStrip1";
            this.mnuLuaChon.UseWaitCursor = true;
            // 
            // mnuHangHoa
            // 
            this.mnuHangHoa.Name = "mnuHangHoa";
            this.mnuHangHoa.Size = new System.Drawing.Size(84, 23);
            this.mnuHangHoa.Text = "Hàng hóa";
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDonBan});
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(79, 23);
            this.mnuHoaDon.Text = "Hóa đơn";
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTimKiemHoaDonBan,
            this.mnuTimKiemHangHoa});
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(86, 23);
            this.mnuTimKiem.Text = "Tìm kiếm";
            // 
            // mnuHoaDonBan
            // 
            this.mnuHoaDonBan.Name = "mnuHoaDonBan";
            this.mnuHoaDonBan.Size = new System.Drawing.Size(180, 24);
            this.mnuHoaDonBan.Text = "Hóa đơn bán";
            // 
            // mnuTimKiemHoaDonBan
            // 
            this.mnuTimKiemHoaDonBan.Name = "mnuTimKiemHoaDonBan";
            this.mnuTimKiemHoaDonBan.Size = new System.Drawing.Size(180, 24);
            this.mnuTimKiemHoaDonBan.Text = "Hóa đơn";
            // 
            // mnuTimKiemHangHoa
            // 
            this.mnuTimKiemHangHoa.Name = "mnuTimKiemHangHoa";
            this.mnuTimKiemHangHoa.Size = new System.Drawing.Size(180, 24);
            this.mnuTimKiemHangHoa.Text = "Hàng hóa";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoanhThu});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(76, 23);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuDoanhThu
            // 
            this.mnuDoanhThu.Name = "mnuDoanhThu";
            this.mnuDoanhThu.Size = new System.Drawing.Size(180, 24);
            this.mnuDoanhThu.Text = "Doanh thu";
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(90, 23);
            this.mnuGioiThieu.Text = "Giới thiệu";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 373);
            this.Controls.Add(this.mnuLuaChon);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuLuaChon;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBanHang";
            this.Text = "Bán hàng";
            this.mnuLuaChon.ResumeLayout(false);
            this.mnuLuaChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuLuaChon;
        private System.Windows.Forms.ToolStripMenuItem mnuHangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiemHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiemHangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
    }
}