namespace quanLyKho
{
    partial class frm_BCTK_NCC
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BCTK_NCC_In = new System.Windows.Forms.Button();
            this.dgv_BCTK_NCC = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BCTK_NCC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ NHÀ CUNG CẤP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_BCTK_NCC_In
            // 
            this.btn_BCTK_NCC_In.Image = global::quanLyKho.Properties.Resources._in;
            this.btn_BCTK_NCC_In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BCTK_NCC_In.Location = new System.Drawing.Point(82, 56);
            this.btn_BCTK_NCC_In.Name = "btn_BCTK_NCC_In";
            this.btn_BCTK_NCC_In.Padding = new System.Windows.Forms.Padding(10, 0, 35, 0);
            this.btn_BCTK_NCC_In.Size = new System.Drawing.Size(161, 64);
            this.btn_BCTK_NCC_In.TabIndex = 1;
            this.btn_BCTK_NCC_In.Text = "In";
            this.btn_BCTK_NCC_In.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BCTK_NCC_In.UseVisualStyleBackColor = false;
            // 
            // dgv_BCTK_NCC
            // 
            this.dgv_BCTK_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BCTK_NCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BCTK_NCC.Location = new System.Drawing.Point(0, 0);
            this.dgv_BCTK_NCC.Name = "dgv_BCTK_NCC";
            this.dgv_BCTK_NCC.RowHeadersWidth = 51;
            this.dgv_BCTK_NCC.RowTemplate.Height = 24;
            this.dgv_BCTK_NCC.Size = new System.Drawing.Size(1200, 703);
            this.dgv_BCTK_NCC.TabIndex = 2;
            this.dgv_BCTK_NCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BCTK_NCC_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_BCTK_NCC_In);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 134);
            this.panel1.TabIndex = 3;
            // 
            // frm_BCTK_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_BCTK_NCC);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_BCTK_NCC";
            this.Text = "frm_BCTK_NCC";
            this.Load += new System.EventHandler(this.frm_BCTK_NCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BCTK_NCC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BCTK_NCC_In;
        private System.Windows.Forms.DataGridView dgv_BCTK_NCC;
        private System.Windows.Forms.Panel panel1;
    }
}