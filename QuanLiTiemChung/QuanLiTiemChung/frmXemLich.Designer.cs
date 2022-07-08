
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemLich));
            this.gvLichLamViec = new System.Windows.Forms.DataGridView();
            this.cb_MaNV = new System.Windows.Forms.ComboBox();
            this.bt_huy = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_thanhtoandonhang = new System.Windows.Forms.Label();
            this.bt_DangXuat = new System.Windows.Forms.Button();
            this.panel_toolbar = new System.Windows.Forms.Panel();
            this.panel_User = new System.Windows.Forms.Panel();
            this.pic_User = new System.Windows.Forms.PictureBox();
            this.lb_User = new System.Windows.Forms.Label();
            this.btnChuyenFrom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvLichLamViec)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_toolbar.SuspendLayout();
            this.panel_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLichLamViec
            // 
            this.gvLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLichLamViec.Location = new System.Drawing.Point(3, 42);
            this.gvLichLamViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvLichLamViec.Name = "gvLichLamViec";
            this.gvLichLamViec.RowHeadersWidth = 62;
            this.gvLichLamViec.RowTemplate.Height = 28;
            this.gvLichLamViec.Size = new System.Drawing.Size(1088, 229);
            this.gvLichLamViec.TabIndex = 0;
            // 
            // cb_MaNV
            // 
            this.cb_MaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MaNV.FormattingEnabled = true;
            this.cb_MaNV.Location = new System.Drawing.Point(174, 5);
            this.cb_MaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_MaNV.Name = "cb_MaNV";
            this.cb_MaNV.Size = new System.Drawing.Size(209, 28);
            this.cb_MaNV.TabIndex = 2;
            this.cb_MaNV.SelectedIndexChanged += new System.EventHandler(this.cb_MaNV_SelectedIndexChanged);
            // 
            // bt_huy
            // 
            this.bt_huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_huy.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.Location = new System.Drawing.Point(917, 361);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(184, 46);
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
            this.lb_Title.Location = new System.Drawing.Point(3, 9);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(450, 35);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "HỆ THỐNG TIÊM CHỦNG AN BÌNH";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_main.Controls.Add(this.btnChuyenFrom);
            this.panel_main.Controls.Add(this.bt_huy);
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Controls.Add(this.lb_thanhtoandonhang);
            this.panel_main.Location = new System.Drawing.Point(14, 82);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1109, 416);
            this.panel_main.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cb_MaNV);
            this.panel1.Controls.Add(this.gvLichLamViec);
            this.panel1.Location = new System.Drawing.Point(4, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 284);
            this.panel1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "MÃ NHÂN VIÊN";
            // 
            // lb_thanhtoandonhang
            // 
            this.lb_thanhtoandonhang.AutoSize = true;
            this.lb_thanhtoandonhang.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtoandonhang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_thanhtoandonhang.Location = new System.Drawing.Point(389, 14);
            this.lb_thanhtoandonhang.Name = "lb_thanhtoandonhang";
            this.lb_thanhtoandonhang.Size = new System.Drawing.Size(300, 49);
            this.lb_thanhtoandonhang.TabIndex = 4;
            this.lb_thanhtoandonhang.Text = "LỊCH LÀM VIỆC";
            // 
            // bt_DangXuat
            // 
            this.bt_DangXuat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_DangXuat.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangXuat.Location = new System.Drawing.Point(936, 5);
            this.bt_DangXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_DangXuat.Name = "bt_DangXuat";
            this.bt_DangXuat.Size = new System.Drawing.Size(165, 46);
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
            this.panel_toolbar.Location = new System.Drawing.Point(14, 14);
            this.panel_toolbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.Size = new System.Drawing.Size(1110, 59);
            this.panel_toolbar.TabIndex = 31;
            // 
            // panel_User
            // 
            this.panel_User.Controls.Add(this.pic_User);
            this.panel_User.Controls.Add(this.lb_User);
            this.panel_User.Location = new System.Drawing.Point(699, 5);
            this.panel_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_User.Name = "panel_User";
            this.panel_User.Size = new System.Drawing.Size(224, 46);
            this.panel_User.TabIndex = 3;
            // 
            // pic_User
            // 
            this.pic_User.BackColor = System.Drawing.Color.Transparent;
            this.pic_User.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_User.BackgroundImage")));
            this.pic_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_User.Location = new System.Drawing.Point(0, 0);
            this.pic_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_User.Name = "pic_User";
            this.pic_User.Size = new System.Drawing.Size(53, 46);
            this.pic_User.TabIndex = 1;
            this.pic_User.TabStop = false;
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.BackColor = System.Drawing.Color.Transparent;
            this.lb_User.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_User.Location = new System.Drawing.Point(60, 8);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(124, 29);
            this.lb_User.TabIndex = 2;
            this.lb_User.Text = "Username";
            // 
            // btnChuyenFrom
            // 
            this.btnChuyenFrom.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenFrom.Location = new System.Drawing.Point(816, 14);
            this.btnChuyenFrom.Name = "btnChuyenFrom";
            this.btnChuyenFrom.Size = new System.Drawing.Size(280, 48);
            this.btnChuyenFrom.TabIndex = 10;
            this.btnChuyenFrom.Text = "Đăng ký lịch rảnh";
            this.btnChuyenFrom.UseVisualStyleBackColor = true;
            this.btnChuyenFrom.Click += new System.EventHandler(this.btnChuyenFrom_Click);
            // 
            // frmXemLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1137, 516);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_toolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmXemLich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem lịch làm việc";
            this.Load += new System.EventHandler(this.frmXemLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLichLamViec)).EndInit();
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

        private System.Windows.Forms.DataGridView gvLichLamViec;
        private System.Windows.Forms.ComboBox cb_MaNV;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_thanhtoandonhang;
        private System.Windows.Forms.Button bt_DangXuat;
        private System.Windows.Forms.Panel panel_toolbar;
        private System.Windows.Forms.Panel panel_User;
        private System.Windows.Forms.PictureBox pic_User;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Button btnChuyenFrom;
    }
}