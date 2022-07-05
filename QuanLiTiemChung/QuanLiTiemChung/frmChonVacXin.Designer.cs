
namespace QuanLiTiemChung
{
    partial class frmChonVacXin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonVacXin));
            this.gv_ChiTietGoi = new System.Windows.Forms.DataGridView();
            this.lstDSGoiTiem = new System.Windows.Forms.ListBox();
            this.gv_DSChon = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_laphoadon = new System.Windows.Forms.Button();
            this.lb_thanhtoandonhang = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_gv = new System.Windows.Forms.Panel();
            this.lb_mahoadon = new System.Windows.Forms.Label();
            this.pic_User = new System.Windows.Forms.PictureBox();
            this.lb_User = new System.Windows.Forms.Label();
            this.bt_DangXuat = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel_User = new System.Windows.Forms.Panel();
            this.panel_toolbar = new System.Windows.Forms.Panel();
            this.btn_DatMua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChiTietGoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSChon)).BeginInit();
            this.panel_button.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_gv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            this.panel_User.SuspendLayout();
            this.panel_toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_ChiTietGoi
            // 
            this.gv_ChiTietGoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_ChiTietGoi.Location = new System.Drawing.Point(230, 31);
            this.gv_ChiTietGoi.Name = "gv_ChiTietGoi";
            this.gv_ChiTietGoi.RowHeadersWidth = 51;
            this.gv_ChiTietGoi.Size = new System.Drawing.Size(491, 147);
            this.gv_ChiTietGoi.TabIndex = 1;
            // 
            // lstDSGoiTiem
            // 
            this.lstDSGoiTiem.FormattingEnabled = true;
            this.lstDSGoiTiem.Location = new System.Drawing.Point(3, 31);
            this.lstDSGoiTiem.Name = "lstDSGoiTiem";
            this.lstDSGoiTiem.Size = new System.Drawing.Size(219, 147);
            this.lstDSGoiTiem.TabIndex = 2;
            this.lstDSGoiTiem.SelectedIndexChanged += new System.EventHandler(this.lstDSVacXin_SelectedIndexChanged);
            // 
            // gv_DSChon
            // 
            this.gv_DSChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_DSChon.Location = new System.Drawing.Point(3, 3);
            this.gv_DSChon.Name = "gv_DSChon";
            this.gv_DSChon.RowHeadersWidth = 51;
            this.gv_DSChon.Size = new System.Drawing.Size(718, 151);
            this.gv_DSChon.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(601, 184);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 35);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(459, 184);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(136, 35);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_huy.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.Location = new System.Drawing.Point(601, 161);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(121, 30);
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
            this.bt_laphoadon.Location = new System.Drawing.Point(459, 161);
            this.bt_laphoadon.Name = "bt_laphoadon";
            this.bt_laphoadon.Size = new System.Drawing.Size(136, 30);
            this.bt_laphoadon.TabIndex = 4;
            this.bt_laphoadon.Text = "Thanh toán";
            this.bt_laphoadon.UseMnemonic = false;
            this.bt_laphoadon.UseVisualStyleBackColor = false;
            this.bt_laphoadon.Click += new System.EventHandler(this.bt_laphoadon_Click);
            // 
            // lb_thanhtoandonhang
            // 
            this.lb_thanhtoandonhang.AutoSize = true;
            this.lb_thanhtoandonhang.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtoandonhang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_thanhtoandonhang.Location = new System.Drawing.Point(264, 0);
            this.lb_thanhtoandonhang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thanhtoandonhang.Name = "lb_thanhtoandonhang";
            this.lb_thanhtoandonhang.Size = new System.Drawing.Size(199, 33);
            this.lb_thanhtoandonhang.TabIndex = 4;
            this.lb_thanhtoandonhang.Text = "CHỌN VACCINE";
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_button.Controls.Add(this.btn_DatMua);
            this.panel_button.Controls.Add(this.bt_huy);
            this.panel_button.Controls.Add(this.bt_laphoadon);
            this.panel_button.Controls.Add(this.gv_DSChon);
            this.panel_button.Location = new System.Drawing.Point(3, 292);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(726, 198);
            this.panel_button.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.panel_gv);
            this.panel_main.Controls.Add(this.lb_thanhtoandonhang);
            this.panel_main.Controls.Add(this.panel_button);
            this.panel_main.Location = new System.Drawing.Point(9, 54);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(736, 501);
            this.panel_main.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // panel_gv
            // 
            this.panel_gv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_gv.Controls.Add(this.lb_mahoadon);
            this.panel_gv.Controls.Add(this.lstDSGoiTiem);
            this.panel_gv.Controls.Add(this.gv_ChiTietGoi);
            this.panel_gv.Controls.Add(this.btnXoa);
            this.panel_gv.Controls.Add(this.btnThem);
            this.panel_gv.Location = new System.Drawing.Point(3, 37);
            this.panel_gv.Name = "panel_gv";
            this.panel_gv.Size = new System.Drawing.Size(726, 227);
            this.panel_gv.TabIndex = 6;
            // 
            // lb_mahoadon
            // 
            this.lb_mahoadon.AutoSize = true;
            this.lb_mahoadon.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mahoadon.Location = new System.Drawing.Point(0, 8);
            this.lb_mahoadon.Name = "lb_mahoadon";
            this.lb_mahoadon.Size = new System.Drawing.Size(147, 19);
            this.lb_mahoadon.TabIndex = 8;
            this.lb_mahoadon.Text = "Danh sách gói tiêm";
            // 
            // pic_User
            // 
            this.pic_User.BackColor = System.Drawing.Color.Transparent;
            this.pic_User.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_User.BackgroundImage")));
            this.pic_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_User.Location = new System.Drawing.Point(0, 0);
            this.pic_User.Name = "pic_User";
            this.pic_User.Size = new System.Drawing.Size(35, 30);
            this.pic_User.TabIndex = 1;
            this.pic_User.TabStop = false;
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.BackColor = System.Drawing.Color.Transparent;
            this.lb_User.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_User.Location = new System.Drawing.Point(40, 5);
            this.lb_User.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(84, 19);
            this.lb_User.TabIndex = 2;
            this.lb_User.Text = "Username";
            // 
            // bt_DangXuat
            // 
            this.bt_DangXuat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_DangXuat.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangXuat.Location = new System.Drawing.Point(619, 3);
            this.bt_DangXuat.Name = "bt_DangXuat";
            this.bt_DangXuat.Size = new System.Drawing.Size(110, 30);
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
            this.lb_Title.Location = new System.Drawing.Point(2, 6);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(288, 23);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "HỆ THỐNG TIÊM CHỦNG AN BÌNH";
            // 
            // panel_User
            // 
            this.panel_User.Controls.Add(this.pic_User);
            this.panel_User.Controls.Add(this.lb_User);
            this.panel_User.Location = new System.Drawing.Point(466, 3);
            this.panel_User.Name = "panel_User";
            this.panel_User.Size = new System.Drawing.Size(149, 30);
            this.panel_User.TabIndex = 3;
            // 
            // panel_toolbar
            // 
            this.panel_toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_toolbar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_toolbar.Controls.Add(this.bt_DangXuat);
            this.panel_toolbar.Controls.Add(this.lb_Title);
            this.panel_toolbar.Controls.Add(this.panel_User);
            this.panel_toolbar.Location = new System.Drawing.Point(9, 9);
            this.panel_toolbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.Size = new System.Drawing.Size(736, 40);
            this.panel_toolbar.TabIndex = 7;
            // 
            // btn_DatMua
            // 
            this.btn_DatMua.BackColor = System.Drawing.Color.White;
            this.btn_DatMua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_DatMua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_DatMua.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatMua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DatMua.Location = new System.Drawing.Point(317, 160);
            this.btn_DatMua.Name = "btn_DatMua";
            this.btn_DatMua.Size = new System.Drawing.Size(136, 30);
            this.btn_DatMua.TabIndex = 6;
            this.btn_DatMua.Text = "Đặt mua vắc-xin";
            this.btn_DatMua.UseMnemonic = false;
            this.btn_DatMua.UseVisualStyleBackColor = false;
            // 
            // frmChonVacXin
            // 
            this.AcceptButton = this.bt_laphoadon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.bt_huy;
            this.ClientSize = new System.Drawing.Size(752, 560);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_toolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChonVacXin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn vắc-xin";
            this.Load += new System.EventHandler(this.frmDangKyVacXin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChiTietGoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSChon)).EndInit();
            this.panel_button.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_gv.ResumeLayout(false);
            this.panel_gv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            this.panel_User.ResumeLayout(false);
            this.panel_User.PerformLayout();
            this.panel_toolbar.ResumeLayout(false);
            this.panel_toolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gv_ChiTietGoi;
        private System.Windows.Forms.ListBox lstDSGoiTiem;
        private System.Windows.Forms.DataGridView gv_DSChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_laphoadon;
        private System.Windows.Forms.Label lb_thanhtoandonhang;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_gv;
        private System.Windows.Forms.Label lb_mahoadon;
        private System.Windows.Forms.PictureBox pic_User;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Button bt_DangXuat;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel_User;
        private System.Windows.Forms.Panel panel_toolbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DatMua;
    }
}