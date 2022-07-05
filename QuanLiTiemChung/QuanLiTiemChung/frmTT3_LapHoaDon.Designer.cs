namespace QuanLiTiemChung
{
    partial class frmTT3_LapHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTT3_LapHoaDon));
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.lb_ten = new System.Windows.Forms.Label();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_laphoadon = new System.Windows.Forms.Button();
            this.lb_thanhtoandonhang = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.date_ntns = new System.Windows.Forms.DateTimePicker();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.lb_ma = new System.Windows.Forms.Label();
            this.gv_dsGoiTiem = new System.Windows.Forms.DataGridView();
            this.lb_ttKH = new System.Windows.Forms.Label();
            this.panel_gv = new System.Windows.Forms.Panel();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.lb_thanhtien = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.pic_User = new System.Windows.Forms.PictureBox();
            this.lb_User = new System.Windows.Forms.Label();
            this.bt_DangXuat = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel_User = new System.Windows.Forms.Panel();
            this.panel_toolbar = new System.Windows.Forms.Panel();
            this.bt_chiadottt = new System.Windows.Forms.Button();
            this.panel_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dsGoiTiem)).BeginInit();
            this.panel_gv.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            this.panel_User.SuspendLayout();
            this.panel_toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(8, 39);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.ReadOnly = true;
            this.txt_ten.Size = new System.Drawing.Size(455, 27);
            this.txt_ten.TabIndex = 9;
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(4, 12);
            this.lb_ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(149, 24);
            this.lb_ten.TabIndex = 8;
            this.lb_ten.Text = "Tên khách hàng";
            // 
            // bt_huy
            // 
            this.bt_huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_huy.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.Location = new System.Drawing.Point(795, 194);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(4);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(163, 37);
            this.bt_huy.TabIndex = 5;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_laphoadon
            // 
            this.bt_laphoadon.BackColor = System.Drawing.Color.White;
            this.bt_laphoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_laphoadon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_laphoadon.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_laphoadon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_laphoadon.Location = new System.Drawing.Point(593, 194);
            this.bt_laphoadon.Margin = new System.Windows.Forms.Padding(4);
            this.bt_laphoadon.Name = "bt_laphoadon";
            this.bt_laphoadon.Size = new System.Drawing.Size(193, 37);
            this.bt_laphoadon.TabIndex = 4;
            this.bt_laphoadon.Text = "Lập hóa đơn";
            this.bt_laphoadon.UseMnemonic = false;
            this.bt_laphoadon.UseVisualStyleBackColor = false;
            this.bt_laphoadon.Click += new System.EventHandler(this.bt_laphoadon_Click);
            // 
            // lb_thanhtoandonhang
            // 
            this.lb_thanhtoandonhang.AutoSize = true;
            this.lb_thanhtoandonhang.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtoandonhang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_thanhtoandonhang.Location = new System.Drawing.Point(315, 0);
            this.lb_thanhtoandonhang.Name = "lb_thanhtoandonhang";
            this.lb_thanhtoandonhang.Size = new System.Drawing.Size(363, 41);
            this.lb_thanhtoandonhang.TabIndex = 4;
            this.lb_thanhtoandonhang.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_button.Controls.Add(this.bt_chiadottt);
            this.panel_button.Controls.Add(this.date_ntns);
            this.panel_button.Controls.Add(this.txt_diachi);
            this.panel_button.Controls.Add(this.lb_diachi);
            this.panel_button.Controls.Add(this.lb_ngaysinh);
            this.panel_button.Controls.Add(this.txt_sdt);
            this.panel_button.Controls.Add(this.lb_sdt);
            this.panel_button.Controls.Add(this.txt_ma);
            this.panel_button.Controls.Add(this.lb_ma);
            this.panel_button.Controls.Add(this.txt_ten);
            this.panel_button.Controls.Add(this.lb_ten);
            this.panel_button.Controls.Add(this.bt_huy);
            this.panel_button.Controls.Add(this.bt_laphoadon);
            this.panel_button.Location = new System.Drawing.Point(8, 295);
            this.panel_button.Margin = new System.Windows.Forms.Padding(4);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(963, 242);
            this.panel_button.TabIndex = 0;
            // 
            // date_ntns
            // 
            this.date_ntns.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ntns.Enabled = false;
            this.date_ntns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ntns.Location = new System.Drawing.Point(477, 101);
            this.date_ntns.Margin = new System.Windows.Forms.Padding(4);
            this.date_ntns.Name = "date_ntns";
            this.date_ntns.Size = new System.Drawing.Size(480, 27);
            this.date_ntns.TabIndex = 18;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(8, 160);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.ReadOnly = true;
            this.txt_diachi.Size = new System.Drawing.Size(949, 27);
            this.txt_diachi.TabIndex = 17;
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diachi.Location = new System.Drawing.Point(4, 132);
            this.lb_diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(71, 24);
            this.lb_diachi.TabIndex = 16;
            this.lb_diachi.Text = "Địa chỉ";
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaysinh.Location = new System.Drawing.Point(473, 73);
            this.lb_ngaysinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(198, 24);
            this.lb_ngaysinh.TabIndex = 14;
            this.lb_ngaysinh.Text = "Ngày tháng năm sinh";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(8, 101);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.ReadOnly = true;
            this.txt_sdt.Size = new System.Drawing.Size(455, 27);
            this.txt_sdt.TabIndex = 13;
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt.Location = new System.Drawing.Point(4, 73);
            this.lb_sdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(126, 24);
            this.lb_sdt.TabIndex = 12;
            this.lb_sdt.Text = "Số điện thoại";
            // 
            // txt_ma
            // 
            this.txt_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma.Location = new System.Drawing.Point(477, 39);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.ReadOnly = true;
            this.txt_ma.Size = new System.Drawing.Size(480, 27);
            this.txt_ma.TabIndex = 11;
            // 
            // lb_ma
            // 
            this.lb_ma.AutoSize = true;
            this.lb_ma.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ma.Location = new System.Drawing.Point(473, 12);
            this.lb_ma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ma.Name = "lb_ma";
            this.lb_ma.Size = new System.Drawing.Size(145, 24);
            this.lb_ma.TabIndex = 10;
            this.lb_ma.Text = "Mã khách hàng";
            // 
            // gv_dsGoiTiem
            // 
            this.gv_dsGoiTiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_dsGoiTiem.Location = new System.Drawing.Point(4, 4);
            this.gv_dsGoiTiem.Margin = new System.Windows.Forms.Padding(4);
            this.gv_dsGoiTiem.Name = "gv_dsGoiTiem";
            this.gv_dsGoiTiem.RowHeadersWidth = 51;
            this.gv_dsGoiTiem.Size = new System.Drawing.Size(953, 170);
            this.gv_dsGoiTiem.TabIndex = 2;
            this.gv_dsGoiTiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_dsGoiTiem_CellContentClick);
            // 
            // lb_ttKH
            // 
            this.lb_ttKH.AutoSize = true;
            this.lb_ttKH.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ttKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_ttKH.Location = new System.Drawing.Point(3, 263);
            this.lb_ttKH.Name = "lb_ttKH";
            this.lb_ttKH.Size = new System.Drawing.Size(286, 29);
            this.lb_ttKH.TabIndex = 6;
            this.lb_ttKH.Text = "THÔNG TIN KHÁCH HÀNG";
            this.lb_ttKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_gv
            // 
            this.panel_gv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_gv.Controls.Add(this.txt_thanhtien);
            this.panel_gv.Controls.Add(this.lb_thanhtien);
            this.panel_gv.Controls.Add(this.gv_dsGoiTiem);
            this.panel_gv.Location = new System.Drawing.Point(8, 44);
            this.panel_gv.Margin = new System.Windows.Forms.Padding(4);
            this.panel_gv.Name = "panel_gv";
            this.panel_gv.Size = new System.Drawing.Size(963, 215);
            this.panel_gv.TabIndex = 5;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thanhtien.Location = new System.Drawing.Point(400, 182);
            this.txt_thanhtien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.ReadOnly = true;
            this.txt_thanhtien.Size = new System.Drawing.Size(557, 27);
            this.txt_thanhtien.TabIndex = 8;
            // 
            // lb_thanhtien
            // 
            this.lb_thanhtien.AutoSize = true;
            this.lb_thanhtien.Font = new System.Drawing.Font("Bahnschrift", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtien.Location = new System.Drawing.Point(277, 182);
            this.lb_thanhtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_thanhtien.Name = "lb_thanhtien";
            this.lb_thanhtien.Size = new System.Drawing.Size(114, 27);
            this.lb_thanhtien.TabIndex = 7;
            this.lb_thanhtien.Text = "Thành tiền";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_main.Controls.Add(this.lb_ttKH);
            this.panel_main.Controls.Add(this.panel_gv);
            this.panel_main.Controls.Add(this.lb_thanhtoandonhang);
            this.panel_main.Controls.Add(this.panel_button);
            this.panel_main.Location = new System.Drawing.Point(15, 65);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(980, 547);
            this.panel_main.TabIndex = 5;
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
            // bt_DangXuat
            // 
            this.bt_DangXuat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_DangXuat.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangXuat.Location = new System.Drawing.Point(825, 4);
            this.bt_DangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DangXuat.Name = "bt_DangXuat";
            this.bt_DangXuat.Size = new System.Drawing.Size(147, 37);
            this.bt_DangXuat.TabIndex = 1;
            this.bt_DangXuat.Text = "Đăng xuất";
            this.bt_DangXuat.UseVisualStyleBackColor = true;
            this.bt_DangXuat.Click += new System.EventHandler(this.bt_DangXuat_Click);
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
            // panel_toolbar
            // 
            this.panel_toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_toolbar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_toolbar.Controls.Add(this.bt_DangXuat);
            this.panel_toolbar.Controls.Add(this.lb_Title);
            this.panel_toolbar.Controls.Add(this.panel_User);
            this.panel_toolbar.Location = new System.Drawing.Point(15, 11);
            this.panel_toolbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.Size = new System.Drawing.Size(980, 48);
            this.panel_toolbar.TabIndex = 4;
            // 
            // bt_chiadottt
            // 
            this.bt_chiadottt.BackColor = System.Drawing.Color.White;
            this.bt_chiadottt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_chiadottt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_chiadottt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chiadottt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_chiadottt.Location = new System.Drawing.Point(392, 195);
            this.bt_chiadottt.Margin = new System.Windows.Forms.Padding(4);
            this.bt_chiadottt.Name = "bt_chiadottt";
            this.bt_chiadottt.Size = new System.Drawing.Size(193, 37);
            this.bt_chiadottt.TabIndex = 19;
            this.bt_chiadottt.Text = "Chia đợt thanh toán";
            this.bt_chiadottt.UseMnemonic = false;
            this.bt_chiadottt.UseVisualStyleBackColor = false;
            this.bt_chiadottt.Click += new System.EventHandler(this.bt_chiadottt_Click);
            // 
            // frmTT3_LapHoaDon
            // 
            this.AcceptButton = this.bt_laphoadon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.bt_huy;
            this.ClientSize = new System.Drawing.Size(1011, 625);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_toolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTT3_LapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Hóa Đơn";
            this.Load += new System.EventHandler(this.frmTT3_LapHoaDon_Load);
            this.panel_button.ResumeLayout(false);
            this.panel_button.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dsGoiTiem)).EndInit();
            this.panel_gv.ResumeLayout(false);
            this.panel_gv.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            this.panel_User.ResumeLayout(false);
            this.panel_User.PerformLayout();
            this.panel_toolbar.ResumeLayout(false);
            this.panel_toolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_laphoadon;
        private System.Windows.Forms.Label lb_thanhtoandonhang;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.DataGridView gv_dsGoiTiem;
        private System.Windows.Forms.Label lb_ttKH;
        private System.Windows.Forms.Panel panel_gv;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox pic_User;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Button bt_DangXuat;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel_User;
        private System.Windows.Forms.Panel panel_toolbar;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label lb_ma;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label lb_thanhtien;
        private System.Windows.Forms.DateTimePicker date_ntns;
        private System.Windows.Forms.Button bt_chiadottt;
    }
}