
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
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemLichRanh = new System.Windows.Forms.Button();
            this.dtpThemNgay = new System.Windows.Forms.DateTimePicker();
            this.cbbThemCa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbXoaCa = new System.Windows.Forms.ComboBox();
            this.dtpXoaNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXoaLichRanh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvLichRanh)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLichRanh
            // 
            this.gvLichRanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLichRanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.Ca});
            this.gvLichRanh.Location = new System.Drawing.Point(12, 279);
            this.gvLichRanh.Name = "gvLichRanh";
            this.gvLichRanh.RowHeadersWidth = 62;
            this.gvLichRanh.RowTemplate.Height = 28;
            this.gvLichRanh.Size = new System.Drawing.Size(1176, 401);
            this.gvLichRanh.TabIndex = 0;
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 8;
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 800;
            // 
            // Ca
            // 
            this.Ca.HeaderText = "Ca";
            this.Ca.MinimumWidth = 8;
            this.Ca.Name = "Ca";
            this.Ca.Width = 310;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ca";
            // 
            // btnThemLichRanh
            // 
            this.btnThemLichRanh.Location = new System.Drawing.Point(189, 209);
            this.btnThemLichRanh.Name = "btnThemLichRanh";
            this.btnThemLichRanh.Size = new System.Drawing.Size(104, 38);
            this.btnThemLichRanh.TabIndex = 5;
            this.btnThemLichRanh.Text = "Thêm";
            this.btnThemLichRanh.UseVisualStyleBackColor = true;
            // 
            // dtpThemNgay
            // 
            this.dtpThemNgay.Location = new System.Drawing.Point(189, 102);
            this.dtpThemNgay.Name = "dtpThemNgay";
            this.dtpThemNgay.Size = new System.Drawing.Size(270, 26);
            this.dtpThemNgay.TabIndex = 6;
            // 
            // cbbThemCa
            // 
            this.cbbThemCa.FormattingEnabled = true;
            this.cbbThemCa.Items.AddRange(new object[] {
            "Sáng",
            "Chiều"});
            this.cbbThemCa.Location = new System.Drawing.Point(189, 157);
            this.cbbThemCa.Name = "cbbThemCa";
            this.cbbThemCa.Size = new System.Drawing.Size(166, 28);
            this.cbbThemCa.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(556, 59);
            this.label3.TabIndex = 8;
            this.label3.Text = "ĐĂNG KÝ LỊCH RẢNH";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbXoaCa
            // 
            this.cbbXoaCa.FormattingEnabled = true;
            this.cbbXoaCa.Items.AddRange(new object[] {
            "Sáng",
            "Chiều"});
            this.cbbXoaCa.Location = new System.Drawing.Point(819, 157);
            this.cbbXoaCa.Name = "cbbXoaCa";
            this.cbbXoaCa.Size = new System.Drawing.Size(166, 28);
            this.cbbXoaCa.TabIndex = 13;
            // 
            // dtpXoaNgay
            // 
            this.dtpXoaNgay.Location = new System.Drawing.Point(819, 102);
            this.dtpXoaNgay.Name = "dtpXoaNgay";
            this.dtpXoaNgay.Size = new System.Drawing.Size(270, 26);
            this.dtpXoaNgay.TabIndex = 12;
            // 
            // btnXoaLichRanh
            // 
            this.btnXoaLichRanh.Location = new System.Drawing.Point(819, 209);
            this.btnXoaLichRanh.Name = "btnXoaLichRanh";
            this.btnXoaLichRanh.Size = new System.Drawing.Size(104, 38);
            this.btnXoaLichRanh.TabIndex = 11;
            this.btnXoaLichRanh.Text = "Xóa";
            this.btnXoaLichRanh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(768, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày";
            // 
            // frmDangKyLichRanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.cbbXoaCa);
            this.Controls.Add(this.dtpXoaNgay);
            this.Controls.Add(this.btnXoaLichRanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbThemCa);
            this.Controls.Add(this.dtpThemNgay);
            this.Controls.Add(this.btnThemLichRanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvLichRanh);
            this.Name = "frmDangKyLichRanh";
            this.Text = "DangKyLichRanh";
            ((System.ComponentModel.ISupportInitialize)(this.gvLichRanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvLichRanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemLichRanh;
        private System.Windows.Forms.DateTimePicker dtpThemNgay;
        private System.Windows.Forms.ComboBox cbbThemCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbXoaCa;
        private System.Windows.Forms.DateTimePicker dtpXoaNgay;
        private System.Windows.Forms.Button btnXoaLichRanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}