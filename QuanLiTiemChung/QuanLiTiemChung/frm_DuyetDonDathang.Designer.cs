
namespace QuanLiTiemChung
{
    partial class frm_DuyetDonDathang
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
            this.DuyetDH_gv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.FormName_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DuyetDH_gv)).BeginInit();
            this.SuspendLayout();
            // 
            // DuyetDH_gv
            // 
            this.DuyetDH_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DuyetDH_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DuyetDH_gv.Location = new System.Drawing.Point(38, 78);
            this.DuyetDH_gv.Name = "DuyetDH_gv";
            this.DuyetDH_gv.RowHeadersWidth = 51;
            this.DuyetDH_gv.RowTemplate.Height = 24;
            this.DuyetDH_gv.Size = new System.Drawing.Size(1101, 315);
            this.DuyetDH_gv.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(38, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1100, 2);
            this.label3.TabIndex = 6;
            // 
            // FormName_label
            // 
            this.FormName_label.AutoSize = true;
            this.FormName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormName_label.Location = new System.Drawing.Point(336, 9);
            this.FormName_label.Name = "FormName_label";
            this.FormName_label.Size = new System.Drawing.Size(449, 39);
            this.FormName_label.TabIndex = 5;
            this.FormName_label.Text = "PHIẾU ĐẶT MUA VACCINE";
            // 
            // frm_DuyetDonDathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FormName_label);
            this.Controls.Add(this.DuyetDH_gv);
            this.Name = "frm_DuyetDonDathang";
            this.Text = "frm_DuyetDonDathang";
            this.Load += new System.EventHandler(this.frm_DuyetDonDathang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DuyetDH_gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DuyetDH_gv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FormName_label;
    }
}