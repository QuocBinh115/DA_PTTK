
namespace QuanLiTiemChung
{
    partial class frm_DuyetDonDathang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DuyetDonDathang));
            this.DuyetDH_gv = new System.Windows.Forms.DataGridView();
            this.lb_thanhtoandonhang = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_gv = new System.Windows.Forms.Panel();
            this.pic_User = new System.Windows.Forms.PictureBox();
            this.lb_User = new System.Windows.Forms.Label();
            this.bt_DangXuat = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel_User = new System.Windows.Forms.Panel();
            this.panel_toolbar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DuyetDH_gv)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel_gv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            this.panel_User.SuspendLayout();
            this.panel_toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DuyetDH_gv
            // 
            this.DuyetDH_gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DuyetDH_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DuyetDH_gv.Location = new System.Drawing.Point(3, 3);
            this.DuyetDH_gv.Name = "DuyetDH_gv";
            this.DuyetDH_gv.RowHeadersWidth = 51;
            this.DuyetDH_gv.RowTemplate.Height = 24;
            this.DuyetDH_gv.Size = new System.Drawing.Size(957, 213);
            this.DuyetDH_gv.TabIndex = 0;
            // 
            // lb_thanhtoandonhang
            // 
            this.lb_thanhtoandonhang.AutoSize = true;
            this.lb_thanhtoandonhang.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtoandonhang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_thanhtoandonhang.Location = new System.Drawing.Point(300, 11);
            this.lb_thanhtoandonhang.Name = "lb_thanhtoandonhang";
            this.lb_thanhtoandonhang.Size = new System.Drawing.Size(361, 41);
            this.lb_thanhtoandonhang.TabIndex = 4;
            this.lb_thanhtoandonhang.Text = "DUYỆT ĐƠN ĐẶT HÀNG";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_main.Controls.Add(this.panel_gv);
            this.panel_main.Controls.Add(this.lb_thanhtoandonhang);
            this.panel_main.Location = new System.Drawing.Point(12, 66);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(980, 299);
            this.panel_main.TabIndex = 3;
            // 
            // panel_gv
            // 
            this.panel_gv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_gv.Controls.Add(this.DuyetDH_gv);
            this.panel_gv.Location = new System.Drawing.Point(8, 57);
            this.panel_gv.Margin = new System.Windows.Forms.Padding(4);
            this.panel_gv.Name = "panel_gv";
            this.panel_gv.Size = new System.Drawing.Size(965, 221);
            this.panel_gv.TabIndex = 6;
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
            this.panel_toolbar.Location = new System.Drawing.Point(12, 11);
            this.panel_toolbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.Size = new System.Drawing.Size(980, 48);
            this.panel_toolbar.TabIndex = 2;
            // 
            // frm_DuyetDonDathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1007, 378);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_toolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DuyetDonDathang";
            this.Text = "Duyệt đơn đặt hàng";
            this.Load += new System.EventHandler(this.frm_DuyetDonDathang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DuyetDH_gv)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_gv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            this.panel_User.ResumeLayout(false);
            this.panel_User.PerformLayout();
            this.panel_toolbar.ResumeLayout(false);
            this.panel_toolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DuyetDH_gv;
        private System.Windows.Forms.Label lb_thanhtoandonhang;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_gv;
        private System.Windows.Forms.PictureBox pic_User;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Button bt_DangXuat;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel_User;
        private System.Windows.Forms.Panel panel_toolbar;
    }
}