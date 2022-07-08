namespace QuanLiTiemChung
{
    partial class frmTT1_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTT1_Main));
            this.panel_toolbar = new System.Windows.Forms.Panel();
            this.bt_DangXuat = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel_User = new System.Windows.Forms.Panel();
            this.pic_User = new System.Windows.Forms.PictureBox();
            this.lb_User = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_gv = new System.Windows.Forms.Panel();
            this.gv_thongtindonhang = new System.Windows.Forms.DataGridView();
            this.lb_mahoadon = new System.Windows.Forms.Label();
            this.lb_thanhtoandonhang = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.bt_huy = new System.Windows.Forms.Button();
            this.txt_tongcong = new System.Windows.Forms.TextBox();
            this.bt_chiadot = new System.Windows.Forms.Button();
            this.lb_thanhtien = new System.Windows.Forms.Label();
            this.bt_laphoadon = new System.Windows.Forms.Button();
            this.txt_mahoadon = new System.Windows.Forms.TextBox();
            this.panel_toolbar.SuspendLayout();
            this.panel_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel_gv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thongtindonhang)).BeginInit();
            this.panel_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_toolbar
            // 
            this.panel_toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_toolbar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_toolbar.Controls.Add(this.bt_DangXuat);
            this.panel_toolbar.Controls.Add(this.lb_Title);
            this.panel_toolbar.Controls.Add(this.panel_User);
            this.panel_toolbar.Location = new System.Drawing.Point(15, 14);
            this.panel_toolbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.Size = new System.Drawing.Size(980, 48);
            this.panel_toolbar.TabIndex = 0;
            // 
            // bt_DangXuat
            // 
            this.bt_DangXuat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_DangXuat.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangXuat.Location = new System.Drawing.Point(825, 4);
            this.bt_DangXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.panel_User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.pic_User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_User.Name = "pic_User";
            this.pic_User.Size = new System.Drawing.Size(47, 37);
            this.pic_User.TabIndex = 1;
            this.pic_User.TabStop = false;
            this.pic_User.Click += new System.EventHandler(this.pic_User_Click);
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
            this.lb_User.Click += new System.EventHandler(this.lb_User_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_main.Controls.Add(this.panel_gv);
            this.panel_main.Controls.Add(this.lb_thanhtoandonhang);
            this.panel_main.Controls.Add(this.panel_button);
            this.panel_main.Location = new System.Drawing.Point(15, 69);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(980, 363);
            this.panel_main.TabIndex = 1;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
            // 
            // panel_gv
            // 
            this.panel_gv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_gv.Controls.Add(this.txt_mahoadon);
            this.panel_gv.Controls.Add(this.gv_thongtindonhang);
            this.panel_gv.Controls.Add(this.lb_mahoadon);
            this.panel_gv.Location = new System.Drawing.Point(8, 57);
            this.panel_gv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_gv.Name = "panel_gv";
            this.panel_gv.Size = new System.Drawing.Size(965, 221);
            this.panel_gv.TabIndex = 6;
            // 
            // gv_thongtindonhang
            // 
            this.gv_thongtindonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_thongtindonhang.Location = new System.Drawing.Point(4, 41);
            this.gv_thongtindonhang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gv_thongtindonhang.Name = "gv_thongtindonhang";
            this.gv_thongtindonhang.RowHeadersWidth = 51;
            this.gv_thongtindonhang.Size = new System.Drawing.Size(955, 174);
            this.gv_thongtindonhang.TabIndex = 2;
            // 
            // lb_mahoadon
            // 
            this.lb_mahoadon.AutoSize = true;
            this.lb_mahoadon.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mahoadon.Location = new System.Drawing.Point(4, 10);
            this.lb_mahoadon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mahoadon.Name = "lb_mahoadon";
            this.lb_mahoadon.Size = new System.Drawing.Size(113, 24);
            this.lb_mahoadon.TabIndex = 8;
            this.lb_mahoadon.Text = "Mã hóa đơn";
            // 
            // lb_thanhtoandonhang
            // 
            this.lb_thanhtoandonhang.AutoSize = true;
            this.lb_thanhtoandonhang.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtoandonhang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_thanhtoandonhang.Location = new System.Drawing.Point(300, 11);
            this.lb_thanhtoandonhang.Name = "lb_thanhtoandonhang";
            this.lb_thanhtoandonhang.Size = new System.Drawing.Size(397, 41);
            this.lb_thanhtoandonhang.TabIndex = 4;
            this.lb_thanhtoandonhang.Text = "THANH TOÁN ĐƠN HÀNG";
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_button.Controls.Add(this.bt_huy);
            this.panel_button.Controls.Add(this.txt_tongcong);
            this.panel_button.Controls.Add(this.bt_chiadot);
            this.panel_button.Controls.Add(this.lb_thanhtien);
            this.panel_button.Controls.Add(this.bt_laphoadon);
            this.panel_button.Location = new System.Drawing.Point(8, 278);
            this.panel_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(964, 80);
            this.panel_button.TabIndex = 0;
            // 
            // bt_huy
            // 
            this.bt_huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_huy.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.Location = new System.Drawing.Point(795, 39);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(164, 37);
            this.bt_huy.TabIndex = 5;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // txt_tongcong
            // 
            this.txt_tongcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongcong.Location = new System.Drawing.Point(341, 7);
            this.txt_tongcong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tongcong.Name = "txt_tongcong";
            this.txt_tongcong.ReadOnly = true;
            this.txt_tongcong.Size = new System.Drawing.Size(617, 27);
            this.txt_tongcong.TabIndex = 1;
            // 
            // bt_chiadot
            // 
            this.bt_chiadot.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_chiadot.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chiadot.Location = new System.Drawing.Point(541, 39);
            this.bt_chiadot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_chiadot.Name = "bt_chiadot";
            this.bt_chiadot.Size = new System.Drawing.Size(245, 37);
            this.bt_chiadot.TabIndex = 5;
            this.bt_chiadot.Text = "Chia đợt thanh toán";
            this.bt_chiadot.UseVisualStyleBackColor = true;
            this.bt_chiadot.Click += new System.EventHandler(this.bt_chiadot_Click);
            // 
            // lb_thanhtien
            // 
            this.lb_thanhtien.AutoSize = true;
            this.lb_thanhtien.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtien.Location = new System.Drawing.Point(229, 7);
            this.lb_thanhtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_thanhtien.Name = "lb_thanhtien";
            this.lb_thanhtien.Size = new System.Drawing.Size(111, 27);
            this.lb_thanhtien.TabIndex = 0;
            this.lb_thanhtien.Text = "Tổng cộng";
            // 
            // bt_laphoadon
            // 
            this.bt_laphoadon.BackColor = System.Drawing.Color.White;
            this.bt_laphoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_laphoadon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_laphoadon.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_laphoadon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_laphoadon.Location = new System.Drawing.Point(341, 39);
            this.bt_laphoadon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_laphoadon.Name = "bt_laphoadon";
            this.bt_laphoadon.Size = new System.Drawing.Size(193, 37);
            this.bt_laphoadon.TabIndex = 4;
            this.bt_laphoadon.Text = "Lập hóa đơn";
            this.bt_laphoadon.UseMnemonic = false;
            this.bt_laphoadon.UseVisualStyleBackColor = false;
            this.bt_laphoadon.Click += new System.EventHandler(this.bt_laphoadon_Click);
            // 
            // txt_mahoadon
            // 
            this.txt_mahoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahoadon.Location = new System.Drawing.Point(124, 7);
            this.txt_mahoadon.Name = "txt_mahoadon";
            this.txt_mahoadon.ReadOnly = true;
            this.txt_mahoadon.Size = new System.Drawing.Size(239, 27);
            this.txt_mahoadon.TabIndex = 9;
            // 
            // frmTT1_Main
            // 
            this.AcceptButton = this.bt_laphoadon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.bt_huy;
            this.ClientSize = new System.Drawing.Size(1011, 446);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_toolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTT1_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán Tiêm Chủng";
            this.Load += new System.EventHandler(this.frmTT1_Main_Load);
            this.panel_toolbar.ResumeLayout(false);
            this.panel_toolbar.PerformLayout();
            this.panel_User.ResumeLayout(false);
            this.panel_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_gv.ResumeLayout(false);
            this.panel_gv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thongtindonhang)).EndInit();
            this.panel_button.ResumeLayout(false);
            this.panel_button.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_toolbar;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Button bt_DangXuat;
        private System.Windows.Forms.Panel panel_User;
        private System.Windows.Forms.PictureBox pic_User;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_chiadot;
        private System.Windows.Forms.Button bt_laphoadon;
        private System.Windows.Forms.Label lb_thanhtoandonhang;
        private System.Windows.Forms.Label lb_thanhtien;
        private System.Windows.Forms.Panel panel_gv;
        private System.Windows.Forms.DataGridView gv_thongtindonhang;
        private System.Windows.Forms.Label lb_mahoadon;
        private System.Windows.Forms.TextBox txt_tongcong;
        private System.Windows.Forms.TextBox txt_mahoadon;
    }
}