
namespace QuanLiTiemChung
{
    partial class frmDangKyVacXin
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
            this.gv_ChiTietGoi = new System.Windows.Forms.DataGridView();
            this.lstDSVacXin = new System.Windows.Forms.ListBox();
            this.gv_DSChon = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChiTietGoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSChon)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_ChiTietGoi
            // 
            this.gv_ChiTietGoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_ChiTietGoi.Location = new System.Drawing.Point(196, 46);
            this.gv_ChiTietGoi.Name = "gv_ChiTietGoi";
            this.gv_ChiTietGoi.Size = new System.Drawing.Size(378, 147);
            this.gv_ChiTietGoi.TabIndex = 1;
            // 
            // lstDSVacXin
            // 
            this.lstDSVacXin.FormattingEnabled = true;
            this.lstDSVacXin.Location = new System.Drawing.Point(21, 46);
            this.lstDSVacXin.Name = "lstDSVacXin";
            this.lstDSVacXin.Size = new System.Drawing.Size(153, 147);
            this.lstDSVacXin.TabIndex = 2;
            this.lstDSVacXin.SelectedIndexChanged += new System.EventHandler(this.lstDSVacXin_SelectedIndexChanged);
            // 
            // gv_DSChon
            // 
            this.gv_DSChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DSChon.Location = new System.Drawing.Point(12, 232);
            this.gv_DSChon.Name = "gv_DSChon";
            this.gv_DSChon.Size = new System.Drawing.Size(562, 151);
            this.gv_DSChon.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(594, 295);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 35);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(594, 106);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 35);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmDangKyVacXin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gv_DSChon);
            this.Controls.Add(this.lstDSVacXin);
            this.Controls.Add(this.gv_ChiTietGoi);
            this.Name = "frmDangKyVacXin";
            this.Text = "frmDangKyVacXin";
            this.Load += new System.EventHandler(this.frmDangKyVacXin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChiTietGoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSChon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gv_ChiTietGoi;
        private System.Windows.Forms.ListBox lstDSVacXin;
        private System.Windows.Forms.DataGridView gv_DSChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}