namespace QuanLiTiemChung
{
    partial class frmTT2_ChiaDotThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTT2_ChiaDotThanhToan));
            this.panel_toolbar = new System.Windows.Forms.Panel();
            this.bt_DangXuat = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel_User = new System.Windows.Forms.Panel();
            this.pic_User = new System.Windows.Forms.PictureBox();
            this.lb_User = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_gv = new System.Windows.Forms.Panel();
            this.gv_thongtindonhang = new System.Windows.Forms.DataGridView();
            this.lb_thanhtoandonhang = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.bt_huy = new System.Windows.Forms.Button();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.lb_thanhtien = new System.Windows.Forms.Label();
            this.bt_laphoadon = new System.Windows.Forms.Button();
            this.lb_dtt = new System.Windows.Forms.Label();
            this.lb_mtt = new System.Windows.Forms.Label();
            this.txt_mtt = new System.Windows.Forms.TextBox();
            this.cb_dtt = new System.Windows.Forms.ComboBox();
            this.lb_cdtt = new System.Windows.Forms.Label();
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
            this.panel_toolbar.Location = new System.Drawing.Point(11, 12);
            this.panel_toolbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.Size = new System.Drawing.Size(736, 40);
            this.panel_toolbar.TabIndex = 2;
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
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_main.Controls.Add(this.lb_cdtt);
            this.panel_main.Controls.Add(this.panel_gv);
            this.panel_main.Controls.Add(this.lb_thanhtoandonhang);
            this.panel_main.Controls.Add(this.panel_button);
            this.panel_main.Location = new System.Drawing.Point(11, 57);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(736, 323);
            this.panel_main.TabIndex = 3;
            // 
            // panel_gv
            // 
            this.panel_gv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_gv.Controls.Add(this.gv_thongtindonhang);
            this.panel_gv.Location = new System.Drawing.Point(6, 36);
            this.panel_gv.Name = "panel_gv";
            this.panel_gv.Size = new System.Drawing.Size(723, 133);
            this.panel_gv.TabIndex = 5;
            // 
            // gv_thongtindonhang
            // 
            this.gv_thongtindonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_thongtindonhang.Location = new System.Drawing.Point(3, 3);
            this.gv_thongtindonhang.Name = "gv_thongtindonhang";
            this.gv_thongtindonhang.RowHeadersWidth = 51;
            this.gv_thongtindonhang.Size = new System.Drawing.Size(715, 125);
            this.gv_thongtindonhang.TabIndex = 2;
            // 
            // lb_thanhtoandonhang
            // 
            this.lb_thanhtoandonhang.AutoSize = true;
            this.lb_thanhtoandonhang.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtoandonhang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_thanhtoandonhang.Location = new System.Drawing.Point(236, 0);
            this.lb_thanhtoandonhang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thanhtoandonhang.Name = "lb_thanhtoandonhang";
            this.lb_thanhtoandonhang.Size = new System.Drawing.Size(286, 33);
            this.lb_thanhtoandonhang.TabIndex = 4;
            this.lb_thanhtoandonhang.Text = "THÔNG TIN ĐƠN HÀNG";
            this.lb_thanhtoandonhang.Click += new System.EventHandler(this.lb_thanhtoandonhang_Click);
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_button.Controls.Add(this.cb_dtt);
            this.panel_button.Controls.Add(this.txt_mtt);
            this.panel_button.Controls.Add(this.lb_mtt);
            this.panel_button.Controls.Add(this.lb_dtt);
            this.panel_button.Controls.Add(this.bt_huy);
            this.panel_button.Controls.Add(this.txt_thanhtien);
            this.panel_button.Controls.Add(this.lb_thanhtien);
            this.panel_button.Controls.Add(this.bt_laphoadon);
            this.panel_button.Location = new System.Drawing.Point(6, 198);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(723, 118);
            this.panel_button.TabIndex = 0;
            // 
            // bt_huy
            // 
            this.bt_huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_huy.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.Location = new System.Drawing.Point(596, 83);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(122, 30);
            this.bt_huy.TabIndex = 5;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(299, 57);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.ReadOnly = true;
            this.txt_thanhtien.Size = new System.Drawing.Size(419, 20);
            this.txt_thanhtien.TabIndex = 1;
            // 
            // lb_thanhtien
            // 
            this.lb_thanhtien.AutoSize = true;
            this.lb_thanhtien.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtien.Location = new System.Drawing.Point(201, 58);
            this.lb_thanhtien.Name = "lb_thanhtien";
            this.lb_thanhtien.Size = new System.Drawing.Size(92, 19);
            this.lb_thanhtien.TabIndex = 0;
            this.lb_thanhtien.Text = "Thành tiền: ";
            // 
            // bt_laphoadon
            // 
            this.bt_laphoadon.BackColor = System.Drawing.Color.White;
            this.bt_laphoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_laphoadon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_laphoadon.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_laphoadon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_laphoadon.Location = new System.Drawing.Point(446, 83);
            this.bt_laphoadon.Name = "bt_laphoadon";
            this.bt_laphoadon.Size = new System.Drawing.Size(145, 30);
            this.bt_laphoadon.TabIndex = 4;
            this.bt_laphoadon.Text = "Lập hóa đơn";
            this.bt_laphoadon.UseMnemonic = false;
            this.bt_laphoadon.UseVisualStyleBackColor = false;
            this.bt_laphoadon.Click += new System.EventHandler(this.bt_laphoadon_Click);
            // 
            // lb_dtt
            // 
            this.lb_dtt.AutoSize = true;
            this.lb_dtt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dtt.Location = new System.Drawing.Point(3, 9);
            this.lb_dtt.Name = "lb_dtt";
            this.lb_dtt.Size = new System.Drawing.Size(115, 19);
            this.lb_dtt.TabIndex = 7;
            this.lb_dtt.Text = "Đợt thanh toán";
            // 
            // lb_mtt
            // 
            this.lb_mtt.AutoSize = true;
            this.lb_mtt.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mtt.Location = new System.Drawing.Point(295, 9);
            this.lb_mtt.Name = "lb_mtt";
            this.lb_mtt.Size = new System.Drawing.Size(120, 19);
            this.lb_mtt.TabIndex = 8;
            this.lb_mtt.Text = "Mức thanh toán";
            // 
            // txt_mtt
            // 
            this.txt_mtt.Location = new System.Drawing.Point(299, 31);
            this.txt_mtt.Name = "txt_mtt";
            this.txt_mtt.ReadOnly = true;
            this.txt_mtt.Size = new System.Drawing.Size(419, 20);
            this.txt_mtt.TabIndex = 9;
            // 
            // cb_dtt
            // 
            this.cb_dtt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dtt.FormattingEnabled = true;
            this.cb_dtt.Location = new System.Drawing.Point(7, 31);
            this.cb_dtt.Name = "cb_dtt";
            this.cb_dtt.Size = new System.Drawing.Size(277, 21);
            this.cb_dtt.TabIndex = 10;
            // 
            // lb_cdtt
            // 
            this.lb_cdtt.AutoSize = true;
            this.lb_cdtt.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cdtt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_cdtt.Location = new System.Drawing.Point(9, 172);
            this.lb_cdtt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cdtt.Name = "lb_cdtt";
            this.lb_cdtt.Size = new System.Drawing.Size(209, 23);
            this.lb_cdtt.TabIndex = 6;
            this.lb_cdtt.Text = "CHIA ĐỢT THANH TOÁN";
            this.lb_cdtt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTT2_ChiaDotThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(758, 392);
            this.Controls.Add(this.panel_toolbar);
            this.Controls.Add(this.panel_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTT2_ChiaDotThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chia Đợt Thanh Toán";
            this.panel_toolbar.ResumeLayout(false);
            this.panel_toolbar.PerformLayout();
            this.panel_User.ResumeLayout(false);
            this.panel_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_gv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_thongtindonhang)).EndInit();
            this.panel_button.ResumeLayout(false);
            this.panel_button.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_toolbar;
        private System.Windows.Forms.Button bt_DangXuat;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel_User;
        private System.Windows.Forms.PictureBox pic_User;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_gv;
        private System.Windows.Forms.DataGridView gv_thongtindonhang;
        private System.Windows.Forms.Label lb_thanhtoandonhang;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label lb_thanhtien;
        private System.Windows.Forms.Button bt_laphoadon;
        private System.Windows.Forms.Label lb_dtt;
        private System.Windows.Forms.Label lb_mtt;
        private System.Windows.Forms.ComboBox cb_dtt;
        private System.Windows.Forms.TextBox txt_mtt;
        private System.Windows.Forms.Label lb_cdtt;
    }
}