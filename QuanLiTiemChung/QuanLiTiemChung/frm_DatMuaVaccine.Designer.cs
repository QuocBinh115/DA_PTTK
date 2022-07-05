
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chonvaccine_lable = new System.Windows.Forms.Label();
            this.FormName_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ThemVaccine_btn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Soluong_lable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(313, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // chonvaccine_lable
            // 
            this.chonvaccine_lable.AutoSize = true;
            this.chonvaccine_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chonvaccine_lable.Location = new System.Drawing.Point(91, 126);
            this.chonvaccine_lable.Name = "chonvaccine_lable";
            this.chonvaccine_lable.Size = new System.Drawing.Size(121, 25);
            this.chonvaccine_lable.TabIndex = 2;
            this.chonvaccine_lable.Text = "Chọn vaccin";
            // 
            // FormName_label
            // 
            this.FormName_label.AutoSize = true;
            this.FormName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormName_label.Location = new System.Drawing.Point(366, 33);
            this.FormName_label.Name = "FormName_label";
            this.FormName_label.Size = new System.Drawing.Size(449, 39);
            this.FormName_label.TabIndex = 3;
            this.FormName_label.Text = "PHIẾU ĐẶT MUA VACCINE";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(179, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(840, 2);
            this.label3.TabIndex = 4;
            // 
            // ThemVaccine_btn
            // 
            this.ThemVaccine_btn.Location = new System.Drawing.Point(911, 134);
            this.ThemVaccine_btn.Name = "ThemVaccine_btn";
            this.ThemVaccine_btn.Size = new System.Drawing.Size(160, 44);
            this.ThemVaccine_btn.TabIndex = 5;
            this.ThemVaccine_btn.Text = "Thêm vaccine";
            this.ThemVaccine_btn.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(543, 158);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 6;
            // 
            // Soluong_lable
            // 
            this.Soluong_lable.AutoSize = true;
            this.Soluong_lable.Location = new System.Drawing.Point(539, 133);
            this.Soluong_lable.Name = "Soluong_lable";
            this.Soluong_lable.Size = new System.Drawing.Size(64, 17);
            this.Soluong_lable.TabIndex = 7;
            this.Soluong_lable.Text = "Số lượng";
            // 
            // frm_DatMuaVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 543);
            this.Controls.Add(this.Soluong_lable);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ThemVaccine_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FormName_label);
            this.Controls.Add(this.chonvaccine_lable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frm_DatMuaVaccine";
            this.Text = "frm_DatMuaVaccine";
            this.Load += new System.EventHandler(this.frm_DatMuaVaccine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label chonvaccine_lable;
        private System.Windows.Forms.Label FormName_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ThemVaccine_btn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Soluong_lable;
    }
}