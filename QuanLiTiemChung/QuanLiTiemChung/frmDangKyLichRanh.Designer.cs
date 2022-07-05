
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKyLichRanh));
            this.gvLichRanh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemLichRanh = new System.Windows.Forms.Button();
            this.dtpThemNgay = new System.Windows.Forms.DateTimePicker();
            this.cbbThemCa = new System.Windows.Forms.ComboBox();
            this.bt_huy = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_thanhtoandonhang = new System.Windows.Forms.Label();
            this.bt_DangXuat = new System.Windows.Forms.Button();
            this.panel_toolbar = new System.Windows.Forms.Panel();
            this.panel_User = new System.Windows.Forms.Panel();
            this.pic_User = new System.Windows.Forms.PictureBox();
            this.lb_User = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvLichRanh)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_toolbar.SuspendLayout();
            this.panel_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLichRanh
            // 
            this.gvLichRanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLichRanh.Location = new System.Drawing.Point(3, 51);
            this.gvLichRanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvLichRanh.Name = "gvLichRanh";
            this.gvLichRanh.RowHeadersWidth = 62;
            this.gvLichRanh.RowTemplate.Height = 28;
            this.gvLichRanh.Size = new System.Drawing.Size(967, 215);
            this.gvLichRanh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ca";
            // 
            // btnThemLichRanh
            // 
            this.btnThemLichRanh.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLichRanh.Location = new System.Drawing.Point(634, 5);
            this.btnThemLichRanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemLichRanh.Name = "btnThemLichRanh";
            this.btnThemLichRanh.Size = new System.Drawing.Size(164, 37);
            this.btnThemLichRanh.TabIndex = 5;
            this.btnThemLichRanh.Text = "Thêm";
            this.btnThemLichRanh.UseVisualStyleBackColor = true;
            this.btnThemLichRanh.Click += new System.EventHandler(this.btnThemLichRanh_Click);
            // 
            // dtpThemNgay
            // 
            this.dtpThemNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThemNgay.Location = new System.Drawing.Point(65, 11);
            this.dtpThemNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpThemNgay.Name = "dtpThemNgay";
            this.dtpThemNgay.Size = new System.Drawing.Size(348, 30);
            this.dtpThemNgay.TabIndex = 6;
            // 
            // cbbThemCa
            // 
            this.cbbThemCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThemCa.FormattingEnabled = true;
            this.cbbThemCa.Items.AddRange(new object[] {
            "Sáng",
            "Chiều"});
            this.cbbThemCa.Location = new System.Drawing.Point(464, 7);
            this.cbbThemCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbThemCa.Name = "cbbThemCa";
            this.cbbThemCa.Size = new System.Drawing.Size(164, 34);
            this.cbbThemCa.TabIndex = 7;
            // 
            // bt_huy
            // 
            this.bt_huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_huy.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.Location = new System.Drawing.Point(805, 5);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(4);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(164, 37);
            this.bt_huy.TabIndex = 5;
            this.bt_huy.Text = "Thoát";
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Title.Location = new System.Drawing.Point(3, 7);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(369, 29);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "HỆ THỐNG TIÊM CHỦNG AN BÌNH";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Controls.Add(this.lb_thanhtoandonhang);
            this.panel_main.Location = new System.Drawing.Point(12, 66);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(986, 334);
            this.panel_main.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_huy);
            this.panel1.Controls.Add(this.gvLichRanh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThemLichRanh);
            this.panel1.Controls.Add(this.cbbThemCa);
            this.panel1.Controls.Add(this.dtpThemNgay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 270);
            this.panel1.TabIndex = 9;
            // 
            // lb_thanhtoandonhang
            // 
            this.lb_thanhtoandonhang.AutoSize = true;
            this.lb_thanhtoandonhang.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtoandonhang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_thanhtoandonhang.Location = new System.Drawing.Point(346, 11);
            this.lb_thanhtoandonhang.Name = "lb_thanhtoandonhang";
            this.lb_thanhtoandonhang.Size = new System.Drawing.Size(337, 41);
            this.lb_thanhtoandonhang.TabIndex = 4;
            this.lb_thanhtoandonhang.Text = "ĐĂNG KÝ LỊCH RẢNH";
            // 
            // bt_DangXuat
            // 
            this.bt_DangXuat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_DangXuat.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangXuat.Location = new System.Drawing.Point(832, 4);
            this.bt_DangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DangXuat.Name = "bt_DangXuat";
            this.bt_DangXuat.Size = new System.Drawing.Size(147, 37);
            this.bt_DangXuat.TabIndex = 1;
            this.bt_DangXuat.Text = "Đăng xuất";
            this.bt_DangXuat.UseVisualStyleBackColor = true;
            this.bt_DangXuat.Click += new System.EventHandler(this.bt_DangXuat_Click);
            // 
            // panel_toolbar
            // 
            this.panel_toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_toolbar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_toolbar.Controls.Add(this.bt_DangXuat);
            this.panel_toolbar.Controls.Add(this.lb_Title);
            this.panel_toolbar.Controls.Add(this.panel_User);
            this.panel_toolbar.Location = new System.Drawing.Point(12, 11);
            this.panel_toolbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.Size = new System.Drawing.Size(987, 48);
            this.panel_toolbar.TabIndex = 33;
            // 
            // panel_User
            // 
            this.panel_User.Controls.Add(this.pic_User);
            this.panel_User.Controls.Add(this.lb_User);
            this.panel_User.Location = new System.Drawing.Point(621, 4);
            this.panel_User.Margin = new System.Windows.Forms.Padding(4);
            this.panel_User.Name = "panel_User";
            this.panel_User.Size = new System.Drawing.Size(199, 37);
            this.panel_User.TabIndex = 3;
            // 
            // pic_User
            // 
            this.pic_User.BackColor = System.Drawing.Color.Transparent;
            this.pic_User.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_User.BackgroundImage")));
            this.pic_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_User.Location = new System.Drawing.Point(0, 0);
            this.pic_User.Margin = new System.Windows.Forms.Padding(4);
            this.pic_User.Name = "pic_User";
            this.pic_User.Size = new System.Drawing.Size(47, 37);
            this.pic_User.TabIndex = 1;
            this.pic_User.TabStop = false;
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.BackColor = System.Drawing.Color.Transparent;
            this.lb_User.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_User.Location = new System.Drawing.Point(53, 6);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(103, 24);
            this.lb_User.TabIndex = 2;
            this.lb_User.Text = "Username";
            // 
            // frmDangKyLichRanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1011, 413);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_toolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDangKyLichRanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký lịch rảnh";
            this.Load += new System.EventHandler(this.frmDangKyLichRanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLichRanh)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_toolbar.ResumeLayout(false);
            this.panel_toolbar.PerformLayout();
            this.panel_User.ResumeLayout(false);
            this.panel_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvLichRanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemLichRanh;
        private System.Windows.Forms.DateTimePicker dtpThemNgay;
        private System.Windows.Forms.ComboBox cbbThemCa;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_thanhtoandonhang;
        private System.Windows.Forms.Button bt_DangXuat;
        private System.Windows.Forms.Panel panel_toolbar;
        private System.Windows.Forms.Panel panel_User;
        private System.Windows.Forms.PictureBox pic_User;
        private System.Windows.Forms.Label lb_User;
    }
}