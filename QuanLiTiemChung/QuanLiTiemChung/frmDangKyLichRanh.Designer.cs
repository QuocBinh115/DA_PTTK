
namespace QuanLiTiemChung
{
    partial class frmDangKyLichRanh
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
            this.gvLichRanh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemLichRanh = new System.Windows.Forms.Button();
            this.dtpThemNgay = new System.Windows.Forms.DateTimePicker();
            this.cbbThemCa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvLichRanh)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLichRanh
            // 
            this.gvLichRanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLichRanh.Location = new System.Drawing.Point(8, 181);
            this.gvLichRanh.Margin = new System.Windows.Forms.Padding(2);
            this.gvLichRanh.Name = "gvLichRanh";
            this.gvLichRanh.RowHeadersWidth = 62;
            this.gvLichRanh.RowTemplate.Height = 28;
            this.gvLichRanh.Size = new System.Drawing.Size(784, 261);
            this.gvLichRanh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ca";
            // 
            // btnThemLichRanh
            // 
            this.btnThemLichRanh.Location = new System.Drawing.Point(126, 136);
            this.btnThemLichRanh.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemLichRanh.Name = "btnThemLichRanh";
            this.btnThemLichRanh.Size = new System.Drawing.Size(69, 25);
            this.btnThemLichRanh.TabIndex = 5;
            this.btnThemLichRanh.Text = "Thêm";
            this.btnThemLichRanh.UseVisualStyleBackColor = true;
            this.btnThemLichRanh.Click += new System.EventHandler(this.btnThemLichRanh_Click);
            // 
            // dtpThemNgay
            // 
            this.dtpThemNgay.Location = new System.Drawing.Point(126, 66);
            this.dtpThemNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpThemNgay.Name = "dtpThemNgay";
            this.dtpThemNgay.Size = new System.Drawing.Size(181, 20);
            this.dtpThemNgay.TabIndex = 6;
            // 
            // cbbThemCa
            // 
            this.cbbThemCa.FormattingEnabled = true;
            this.cbbThemCa.Items.AddRange(new object[] {
            "Sáng",
            "Chiều"});
            this.cbbThemCa.Location = new System.Drawing.Point(126, 102);
            this.cbbThemCa.Margin = new System.Windows.Forms.Padding(2);
            this.cbbThemCa.Name = "cbbThemCa";
            this.cbbThemCa.Size = new System.Drawing.Size(112, 21);
            this.cbbThemCa.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "ĐĂNG KÝ LỊCH RẢNH";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDangKyLichRanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbThemCa);
            this.Controls.Add(this.dtpThemNgay);
            this.Controls.Add(this.btnThemLichRanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvLichRanh);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDangKyLichRanh";
            this.Text = "DangKyLichRanh";
            this.Load += new System.EventHandler(this.frmDangKyLichRanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLichRanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvLichRanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemLichRanh;
        private System.Windows.Forms.DateTimePicker dtpThemNgay;
        private System.Windows.Forms.ComboBox cbbThemCa;
        private System.Windows.Forms.Label label3;
    }
}