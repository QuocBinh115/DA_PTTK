
namespace QuanLiTiemChung
{
    partial class frm_ThemMoiVaccine
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
            this.label3 = new System.Windows.Forms.Label();
            this.FormName_label = new System.Windows.Forms.Label();
            this.TenVaccine_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NSX_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HSD_input = new System.Windows.Forms.DateTimePicker();
            this.ThemVaccine_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(85, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1000, 2);
            this.label3.TabIndex = 6;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormName_label
            // 
            this.FormName_label.AutoSize = true;
            this.FormName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormName_label.Location = new System.Drawing.Point(408, 31);
            this.FormName_label.Name = "FormName_label";
            this.FormName_label.Size = new System.Drawing.Size(350, 39);
            this.FormName_label.TabIndex = 5;
            this.FormName_label.Text = "THÊM MỚI VACCINE";
            // 
            // TenVaccine_input
            // 
            this.TenVaccine_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenVaccine_input.Location = new System.Drawing.Point(274, 141);
            this.TenVaccine_input.Name = "TenVaccine_input";
            this.TenVaccine_input.Size = new System.Drawing.Size(214, 30);
            this.TenVaccine_input.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên vaccine";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(649, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhà sản xuất";
            // 
            // NSX_input
            // 
            this.NSX_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSX_input.Location = new System.Drawing.Point(654, 141);
            this.NSX_input.Name = "NSX_input";
            this.NSX_input.Size = new System.Drawing.Size(214, 30);
            this.NSX_input.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hạn sử dụng";
            // 
            // HSD_input
            // 
            this.HSD_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSD_input.Location = new System.Drawing.Point(274, 249);
            this.HSD_input.Name = "HSD_input";
            this.HSD_input.Size = new System.Drawing.Size(594, 30);
            this.HSD_input.TabIndex = 12;
            // 
            // ThemVaccine_btn
            // 
            this.ThemVaccine_btn.Location = new System.Drawing.Point(469, 348);
            this.ThemVaccine_btn.Name = "ThemVaccine_btn";
            this.ThemVaccine_btn.Size = new System.Drawing.Size(177, 46);
            this.ThemVaccine_btn.TabIndex = 13;
            this.ThemVaccine_btn.Text = "Thêm";
            this.ThemVaccine_btn.UseVisualStyleBackColor = true;
            // 
            // frm_ThemMoiVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 450);
            this.Controls.Add(this.ThemVaccine_btn);
            this.Controls.Add(this.HSD_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NSX_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TenVaccine_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FormName_label);
            this.Name = "frm_ThemMoiVaccine";
            this.Text = "Thêm mới vaccine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FormName_label;
        private System.Windows.Forms.TextBox TenVaccine_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NSX_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker HSD_input;
        private System.Windows.Forms.Button ThemVaccine_btn;
    }
}