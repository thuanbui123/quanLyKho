namespace quanLyKho
{
    partial class frm_DM_QLKho
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DM_Kho = new System.Windows.Forms.DataGridView();
            this.cbo_DM_Kho_HangHoa = new System.Windows.Forms.ComboBox();
            this.btn_DM_Kho_LamMoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DM_Kho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_DM_Kho_LamMoi);
            this.panel1.Controls.Add(this.cbo_DM_Kho_HangHoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Hàng hóa";
            // 
            // dgv_DM_Kho
            // 
            this.dgv_DM_Kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DM_Kho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DM_Kho.Location = new System.Drawing.Point(0, 100);
            this.dgv_DM_Kho.Name = "dgv_DM_Kho";
            this.dgv_DM_Kho.RowHeadersWidth = 51;
            this.dgv_DM_Kho.RowTemplate.Height = 24;
            this.dgv_DM_Kho.Size = new System.Drawing.Size(1300, 631);
            this.dgv_DM_Kho.TabIndex = 1;
            // 
            // cbo_DM_Kho_HangHoa
            // 
            this.cbo_DM_Kho_HangHoa.FormattingEnabled = true;
            this.cbo_DM_Kho_HangHoa.Location = new System.Drawing.Point(229, 32);
            this.cbo_DM_Kho_HangHoa.Name = "cbo_DM_Kho_HangHoa";
            this.cbo_DM_Kho_HangHoa.Size = new System.Drawing.Size(227, 34);
            this.cbo_DM_Kho_HangHoa.TabIndex = 1;
            // 
            // btn_DM_Kho_LamMoi
            // 
            this.btn_DM_Kho_LamMoi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_DM_Kho_LamMoi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DM_Kho_LamMoi.Location = new System.Drawing.Point(490, 21);
            this.btn_DM_Kho_LamMoi.Name = "btn_DM_Kho_LamMoi";
            this.btn_DM_Kho_LamMoi.Size = new System.Drawing.Size(172, 54);
            this.btn_DM_Kho_LamMoi.TabIndex = 2;
            this.btn_DM_Kho_LamMoi.Text = "Làm mới";
            this.btn_DM_Kho_LamMoi.UseVisualStyleBackColor = false;
            // 
            // frm_DM_QLKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 731);
            this.Controls.Add(this.dgv_DM_Kho);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_DM_QLKho";
            this.Text = "frm_DM_QLKho";
            this.Load += new System.EventHandler(this.frm_DM_QLKho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DM_Kho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DM_Kho;
        private System.Windows.Forms.Button btn_DM_Kho_LamMoi;
        private System.Windows.Forms.ComboBox cbo_DM_Kho_HangHoa;
    }
}