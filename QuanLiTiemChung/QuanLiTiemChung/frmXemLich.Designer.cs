
namespace QuanLiTiemChung
{
    partial class frmXemLich
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
            this.gvLichLamViec = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvLichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLichLamViec
            // 
            this.gvLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLichLamViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.Ca,
            this.ViTri,
            this.NhanVien});
            this.gvLichLamViec.Location = new System.Drawing.Point(12, 152);
            this.gvLichLamViec.Name = "gvLichLamViec";
            this.gvLichLamViec.RowHeadersWidth = 62;
            this.gvLichLamViec.RowTemplate.Height = 28;
            this.gvLichLamViec.Size = new System.Drawing.Size(1176, 528);
            this.gvLichLamViec.TabIndex = 0;
            this.gvLichLamViec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvLichLamViec_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(421, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "LỊCH LÀM VIỆC";
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 8;
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 300;
            // 
            // Ca
            // 
            this.Ca.HeaderText = "Ca";
            this.Ca.MinimumWidth = 8;
            this.Ca.Name = "Ca";
            this.Ca.Width = 210;
            // 
            // ViTri
            // 
            this.ViTri.HeaderText = "Vị Trí";
            this.ViTri.MinimumWidth = 8;
            this.ViTri.Name = "ViTri";
            this.ViTri.Width = 300;
            // 
            // NhanVien
            // 
            this.NhanVien.HeaderText = "Nhân Viên Phụ Trách";
            this.NhanVien.MinimumWidth = 8;
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Width = 300;
            // 
            // frmXemLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvLichLamViec);
            this.Name = "frmXemLich";
            this.Text = "XemLich";
            ((System.ComponentModel.ISupportInitialize)(this.gvLichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvLichLamViec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
    }
}