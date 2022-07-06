
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
            this.FormName_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ThemCTDH_btn = new System.Windows.Forms.Button();
            this.ChonVaccine_table = new System.Windows.Forms.DataGridView();
            this.ChonVaccine_cbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Chon_SL_input = new System.Windows.Forms.NumericUpDown();
            this.ThemMoiVaccine_btn = new System.Windows.Forms.Button();
            this.DatMuaVaccine_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChonVaccine_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chon_SL_input)).BeginInit();
            this.SuspendLayout();
            // 
            // FormName_label
            // 
            this.FormName_label.AutoSize = true;
            this.FormName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormName_label.Location = new System.Drawing.Point(357, 37);
            this.FormName_label.Name = "FormName_label";
            this.FormName_label.Size = new System.Drawing.Size(449, 39);
            this.FormName_label.TabIndex = 3;
            this.FormName_label.Text = "PHIẾU ĐẶT MUA VACCINE";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(24, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1200, 2);
            this.label3.TabIndex = 4;
            // 
            // ThemCTDH_btn
            // 
            this.ThemCTDH_btn.Location = new System.Drawing.Point(544, 133);
            this.ThemCTDH_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ThemCTDH_btn.Name = "ThemCTDH_btn";
            this.ThemCTDH_btn.Size = new System.Drawing.Size(154, 29);
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
            this.ChonVaccine_table.Location = new System.Drawing.Point(84, 191);
            this.ChonVaccine_table.Name = "ChonVaccine_table";
            this.ChonVaccine_table.ReadOnly = true;
            this.ChonVaccine_table.RowHeadersWidth = 51;
            this.ChonVaccine_table.RowTemplate.Height = 24;
            this.ChonVaccine_table.Size = new System.Drawing.Size(1066, 239);
            this.ChonVaccine_table.TabIndex = 6;
            // 
            // ChonVaccine_cbb
            // 
            this.ChonVaccine_cbb.FormattingEnabled = true;
            this.ChonVaccine_cbb.Location = new System.Drawing.Point(84, 136);
            this.ChonVaccine_cbb.Name = "ChonVaccine_cbb";
            this.ChonVaccine_cbb.Size = new System.Drawing.Size(219, 26);
            this.ChonVaccine_cbb.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn vaccine:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số lượng:";
            // 
            // Chon_SL_input
            // 
            this.Chon_SL_input.Location = new System.Drawing.Point(383, 138);
            this.Chon_SL_input.Name = "Chon_SL_input";
            this.Chon_SL_input.Size = new System.Drawing.Size(104, 24);
            this.Chon_SL_input.TabIndex = 11;
            // 
            // ThemMoiVaccine_btn
            // 
            this.ThemMoiVaccine_btn.Location = new System.Drawing.Point(965, 136);
            this.ThemMoiVaccine_btn.Name = "ThemMoiVaccine_btn";
            this.ThemMoiVaccine_btn.Size = new System.Drawing.Size(185, 32);
            this.ThemMoiVaccine_btn.TabIndex = 14;
            this.ThemMoiVaccine_btn.Text = "Thêm mới vaccine";
            this.ThemMoiVaccine_btn.UseVisualStyleBackColor = true;
            this.ThemMoiVaccine_btn.Click += new System.EventHandler(this.ThemMoiVaccine_btn_Click);
            // 
            // DatMuaVaccine_btn
            // 
            this.DatMuaVaccine_btn.Location = new System.Drawing.Point(426, 469);
            this.DatMuaVaccine_btn.Name = "DatMuaVaccine_btn";
            this.DatMuaVaccine_btn.Size = new System.Drawing.Size(259, 44);
            this.DatMuaVaccine_btn.TabIndex = 13;
            this.DatMuaVaccine_btn.Text = "Đặt Mua";
            this.DatMuaVaccine_btn.UseVisualStyleBackColor = true;
            this.DatMuaVaccine_btn.Click += new System.EventHandler(this.DatMuaVaccine_btn_Click);
            // 
            // frm_DatMuaVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 611);
            this.Controls.Add(this.DatMuaVaccine_btn);
            this.Controls.Add(this.ThemMoiVaccine_btn);
            this.Controls.Add(this.Chon_SL_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChonVaccine_cbb);
            this.Controls.Add(this.ChonVaccine_table);
            this.Controls.Add(this.ThemCTDH_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FormName_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_DatMuaVaccine";
            this.Text = "frm_DatMuaVaccine";
            this.Load += new System.EventHandler(this.frm_DatMuaVaccine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChonVaccine_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chon_SL_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FormName_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ThemCTDH_btn;
        private System.Windows.Forms.DataGridView ChonVaccine_table;
        private System.Windows.Forms.ComboBox ChonVaccine_cbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Chon_SL_input;
        private System.Windows.Forms.Button ThemMoiVaccine_btn;
        private System.Windows.Forms.Button DatMuaVaccine_btn;
    }
}