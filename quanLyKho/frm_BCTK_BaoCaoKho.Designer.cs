﻿
namespace quanLyKho
{
    partial class frm_BCTK_BaoCaoKho
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnIn = new System.Windows.Forms.Button();
            this.lblBaoCaoKho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 166);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(807, 413);
            this.dgvMain.TabIndex = 17;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(12, 66);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(155, 55);
            this.btnIn.TabIndex = 16;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // lblBaoCaoKho
            // 
            this.lblBaoCaoKho.AutoSize = true;
            this.lblBaoCaoKho.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCaoKho.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBaoCaoKho.Location = new System.Drawing.Point(239, 8);
            this.lblBaoCaoKho.Name = "lblBaoCaoKho";
            this.lblBaoCaoKho.Size = new System.Drawing.Size(128, 25);
            this.lblBaoCaoKho.TabIndex = 15;
            this.lblBaoCaoKho.Text = "Báo cáo kho";
            // 
            // frm_BCTK_BaoCaoKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(831, 587);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblBaoCaoKho);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BCTK_BaoCaoKho";
            this.Text = "frm_BCTK_BaoCaoKho";
            this.Load += new System.EventHandler(this.frm_BCTK_BaoCaoKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label lblBaoCaoKho;
    }
}