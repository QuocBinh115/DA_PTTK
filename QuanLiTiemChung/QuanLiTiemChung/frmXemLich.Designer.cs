
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
            this.cb_MaNV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvLichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLichLamViec
            // 
            this.gvLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLichLamViec.Location = new System.Drawing.Point(8, 163);
            this.gvLichLamViec.Margin = new System.Windows.Forms.Padding(2);
            this.gvLichLamViec.Name = "gvLichLamViec";
            this.gvLichLamViec.RowHeadersWidth = 62;
            this.gvLichLamViec.RowTemplate.Height = 28;
            this.gvLichLamViec.Size = new System.Drawing.Size(627, 279);
            this.gvLichLamViec.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(173, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "LỊCH LÀM VIỆC";
            // 
            // cb_MaNV
            // 
            this.cb_MaNV.FormattingEnabled = true;
            this.cb_MaNV.Location = new System.Drawing.Point(63, 115);
            this.cb_MaNV.Name = "cb_MaNV";
            this.cb_MaNV.Size = new System.Drawing.Size(121, 21);
            this.cb_MaNV.TabIndex = 2;
            this.cb_MaNV.SelectedIndexChanged += new System.EventHandler(this.cb_MaNV_SelectedIndexChanged);
            // 
            // frmXemLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_MaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvLichLamViec);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmXemLich";
            this.Text = "XemLich";
            this.Load += new System.EventHandler(this.frmXemLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvLichLamViec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_MaNV;
    }
}