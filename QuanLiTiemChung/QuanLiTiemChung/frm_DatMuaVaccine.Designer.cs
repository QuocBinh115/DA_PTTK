
namespace QuanLiTiemChung
{
    partial class frm_DatMuaVaccine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DatMuaVaccine));
            this.ThemCTDH_btn = new System.Windows.Forms.Button();
            this.ChonVaccine_table = new System.Windows.Forms.DataGridView();
            this.ChonVaccine_cbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Chon_SL_input = new System.Windows.Forms.NumericUpDown();
            this.ThemMoiVaccine_btn = new System.Windows.Forms.Button();
            this.DatMuaVaccine_btn = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.lb_thanhtoandonhang = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_gv = new System.Windows.Forms.Panel();
            this.pic_User = new System.Windows.Forms.PictureBox();
            this.lb_User = new System.Windows.Forms.Label();
            this.bt_DangXuat = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel_User = new System.Windows.Forms.Panel();
            this.panel_toolbar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ChonVaccine_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chon_SL_input)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel_gv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            this.panel_User.SuspendLayout();
            this.panel_toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThemCTDH_btn
            // 
            this.ThemCTDH_btn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemCTDH_btn.Location = new System.Drawing.Point(724, 10);
            this.ThemCTDH_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ThemCTDH_btn.Name = "ThemCTDH_btn";
            this.ThemCTDH_btn.Size = new System.Drawing.Size(236, 37);
            this.ThemCTDH_btn.TabIndex = 12;
            this.ThemCTDH_btn.Text = "Thêm vào danh sách";
            this.ThemCTDH_btn.UseVisualStyleBackColor = true;
            this.ThemCTDH_btn.Click += new System.EventHandler(this.ThemVaccine_btn_Click);
            // 
            // ChonVaccine_table
            // 
            this.ChonVaccine_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChonVaccine_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ChonVaccine_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChonVaccine_table.Location = new System.Drawing.Point(3, 54);
            this.ChonVaccine_table.Name = "ChonVaccine_table";
            this.ChonVaccine_table.ReadOnly = true;
            this.ChonVaccine_table.RowHeadersWidth = 51;
            this.ChonVaccine_table.RowTemplate.Height = 24;
            this.ChonVaccine_table.Size = new System.Drawing.Size(957, 208);
            this.ChonVaccine_table.TabIndex = 6;
            // 
            // ChonVaccine_cbb
            // 
            this.ChonVaccine_cbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChonVaccine_cbb.FormattingEnabled = true;
            this.ChonVaccine_cbb.Location = new System.Drawing.Point(142, 13);
            this.ChonVaccine_cbb.Name = "ChonVaccine_cbb";
            this.ChonVaccine_cbb.Size = new System.Drawing.Size(339, 33);
            this.ChonVaccine_cbb.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn vaccine:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số lượng:";
            // 
            // Chon_SL_input
            // 
            this.Chon_SL_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chon_SL_input.Location = new System.Drawing.Point(597, 14);
            this.Chon_SL_input.Name = "Chon_SL_input";
            this.Chon_SL_input.Size = new System.Drawing.Size(104, 30);
            this.Chon_SL_input.TabIndex = 11;
            // 
            // ThemMoiVaccine_btn
            // 
            this.ThemMoiVaccine_btn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemMoiVaccine_btn.Location = new System.Drawing.Point(467, 332);
            this.ThemMoiVaccine_btn.Name = "ThemMoiVaccine_btn";
            this.ThemMoiVaccine_btn.Size = new System.Drawing.Size(164, 37);
            this.ThemMoiVaccine_btn.TabIndex = 14;
            this.ThemMoiVaccine_btn.Text = "Thêm mới vaccine";
            this.ThemMoiVaccine_btn.UseVisualStyleBackColor = true;
            this.ThemMoiVaccine_btn.Click += new System.EventHandler(this.ThemMoiVaccine_btn_Click);
            // 
            // DatMuaVaccine_btn
            // 
            this.DatMuaVaccine_btn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatMuaVaccine_btn.Location = new System.Drawing.Point(637, 331);
            this.DatMuaVaccine_btn.Name = "DatMuaVaccine_btn";
            this.DatMuaVaccine_btn.Size = new System.Drawing.Size(164, 37);
            this.DatMuaVaccine_btn.TabIndex = 13;
            this.DatMuaVaccine_btn.Text = "Đặt Mua";
            this.DatMuaVaccine_btn.UseVisualStyleBackColor = true;
            this.DatMuaVaccine_btn.Click += new System.EventHandler(this.DatMuaVaccine_btn_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_huy.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.Location = new System.Drawing.Point(808, 332);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(4);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(164, 37);
            this.bt_huy.TabIndex = 5;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // lb_thanhtoandonhang
            // 
            this.lb_thanhtoandonhang.AutoSize = true;
            this.lb_thanhtoandonhang.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtoandonhang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_thanhtoandonhang.Location = new System.Drawing.Point(293, 12);
            this.lb_thanhtoandonhang.Name = "lb_thanhtoandonhang";
            this.lb_thanhtoandonhang.Size = new System.Drawing.Size(402, 41);
            this.lb_thanhtoandonhang.TabIndex = 4;
            this.lb_thanhtoandonhang.Text = "PHIẾU ĐẶT MUA VACCINE";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_main.Controls.Add(this.bt_huy);
            this.panel_main.Controls.Add(this.DatMuaVaccine_btn);
            this.panel_main.Controls.Add(this.panel_gv);
            this.panel_main.Controls.Add(this.ThemMoiVaccine_btn);
            this.panel_main.Controls.Add(this.lb_thanhtoandonhang);
            this.panel_main.Location = new System.Drawing.Point(12, 66);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(981, 380);
            this.panel_main.TabIndex = 16;
            // 
            // panel_gv
            // 
            this.panel_gv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_gv.Controls.Add(this.label1);
            this.panel_gv.Controls.Add(this.ChonVaccine_cbb);
            this.panel_gv.Controls.Add(this.ChonVaccine_table);
            this.panel_gv.Controls.Add(this.ThemCTDH_btn);
            this.panel_gv.Controls.Add(this.label2);
            this.panel_gv.Controls.Add(this.Chon_SL_input);
            this.panel_gv.Location = new System.Drawing.Point(8, 57);
            this.panel_gv.Margin = new System.Windows.Forms.Padding(4);
            this.panel_gv.Name = "panel_gv";
            this.panel_gv.Size = new System.Drawing.Size(965, 267);
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
            this.panel_toolbar.Location = new System.Drawing.Point(12, 11);
            this.panel_toolbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.Size = new System.Drawing.Size(980, 48);
            this.panel_toolbar.TabIndex = 15;
            // 
            // frm_DatMuaVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 458);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_toolbar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_DatMuaVaccine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt mua vaccine";
            this.Load += new System.EventHandler(this.frm_DatMuaVaccine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChonVaccine_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chon_SL_input)).EndInit();
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
        private System.Windows.Forms.Button ThemCTDH_btn;
        private System.Windows.Forms.DataGridView ChonVaccine_table;
        private System.Windows.Forms.ComboBox ChonVaccine_cbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Chon_SL_input;
        private System.Windows.Forms.Button ThemMoiVaccine_btn;
        private System.Windows.Forms.Button DatMuaVaccine_btn;
        private System.Windows.Forms.Button bt_huy;
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