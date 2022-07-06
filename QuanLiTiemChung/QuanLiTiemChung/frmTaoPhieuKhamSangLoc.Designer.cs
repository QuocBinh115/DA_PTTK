using System;

namespace QuanLiTiemChung.PhieuKhamSangLoc
{
    partial class frmTaoPhieuKhamSangLoc
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
        private void setTingNhanVien()
        {
            cmboxMaNV.Items.AddRange(NhanVien.layMaNV());
        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.txtNgayTao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmboxMaNV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ckbSick1 = new System.Windows.Forms.CheckBox();
            this.ckbSick2 = new System.Windows.Forms.CheckBox();
            this.ckbSick3 = new System.Windows.Forms.CheckBox();
            this.ckbSick4 = new System.Windows.Forms.CheckBox();
            this.ckbSick5 = new System.Windows.Forms.CheckBox();
            this.ckbSick6 = new System.Windows.Forms.CheckBox();
            this.ckbSick7 = new System.Windows.Forms.CheckBox();
            this.ckbSick8 = new System.Windows.Forms.CheckBox();
            this.ckbSick9 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ckbDuDieuKien = new System.Windows.Forms.CheckBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Khám Sàng Lọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(737, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "------------------------------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CMND";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(135, 151);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(436, 22);
            this.txtCmnd.TabIndex = 3;
            this.txtCmnd.TextChanged += new System.EventHandler(this.txtCmndChange);
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Location = new System.Drawing.Point(648, 151);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.ReadOnly = true;
            this.txtNgayTao.Size = new System.Drawing.Size(436, 22);
            this.txtNgayTao.TabIndex = 5;
            this.txtNgayTao.Text = "2022-07-06";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày tạo";
            // 
            // txTenKH
            // 
            this.txTenKH.Location = new System.Drawing.Point(135, 232);
            this.txTenKH.Name = "txTenKH";
            this.txTenKH.ReadOnly = true;
            this.txTenKH.Size = new System.Drawing.Size(436, 22);
            this.txTenKH.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã nhân viên";
            // 
            // cmboxMaNV
            // 
            this.cmboxMaNV.FormattingEnabled = true;
            this.cmboxMaNV.Location = new System.Drawing.Point(648, 229);
            this.cmboxMaNV.Name = "cmboxMaNV";
            this.cmboxMaNV.Size = new System.Drawing.Size(436, 24);
            this.cmboxMaNV.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "I. Khám sàng lọc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(128, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(965, 39);
            this.label8.TabIndex = 11;
            this.label8.Text = "-------------------------------------------------------------------------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(381, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "1. Tiền sử rõ ràng phản vệ với vắc xin phòng COVID-19 lần trước";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(297, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "2. Tiền sử rõ ràng bị COVID-19 trong vòng 6 tháng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "3. Đang mắc bệnh cấp tính";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "4. Phụ nữ mang thai";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(132, 477);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(280, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "5. Phản vệ độ 3 trở lên với bất kì dị nguyên nào";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(132, 505);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(499, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "6. Đang bị suy giảm miễn dịch nặng, ung thư giai đoạn cuối đang điều trị hóa trị," +
    " xạ trị";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(132, 537);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(246, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "7. Tiền sử dị ứng với bất kì dị nguyên nào";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(132, 566);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(236, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "8. Tiền sử rối loạn đông máu/ cầm máu";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(132, 595);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(207, 16);
            this.label17.TabIndex = 20;
            this.label17.Text = "9. Rồi loạn tri giác, rối loạn hành vi";
            // 
            // ckbSick1
            // 
            this.ckbSick1.AutoSize = true;
            this.ckbSick1.Location = new System.Drawing.Point(1066, 355);
            this.ckbSick1.Name = "ckbSick1";
            this.ckbSick1.Size = new System.Drawing.Size(18, 17);
            this.ckbSick1.TabIndex = 21;
            this.ckbSick1.UseVisualStyleBackColor = true;
            // 
            // ckbSick2
            // 
            this.ckbSick2.AutoSize = true;
            this.ckbSick2.Location = new System.Drawing.Point(1066, 386);
            this.ckbSick2.Name = "ckbSick2";
            this.ckbSick2.Size = new System.Drawing.Size(18, 17);
            this.ckbSick2.TabIndex = 22;
            this.ckbSick2.UseVisualStyleBackColor = true;
            // 
            // ckbSick3
            // 
            this.ckbSick3.AutoSize = true;
            this.ckbSick3.Location = new System.Drawing.Point(1066, 417);
            this.ckbSick3.Name = "ckbSick3";
            this.ckbSick3.Size = new System.Drawing.Size(18, 17);
            this.ckbSick3.TabIndex = 23;
            this.ckbSick3.UseVisualStyleBackColor = true;
            // 
            // ckbSick4
            // 
            this.ckbSick4.AutoSize = true;
            this.ckbSick4.Location = new System.Drawing.Point(1066, 447);
            this.ckbSick4.Name = "ckbSick4";
            this.ckbSick4.Size = new System.Drawing.Size(18, 17);
            this.ckbSick4.TabIndex = 24;
            this.ckbSick4.UseVisualStyleBackColor = true;
            // 
            // ckbSick5
            // 
            this.ckbSick5.AutoSize = true;
            this.ckbSick5.Location = new System.Drawing.Point(1066, 478);
            this.ckbSick5.Name = "ckbSick5";
            this.ckbSick5.Size = new System.Drawing.Size(18, 17);
            this.ckbSick5.TabIndex = 25;
            this.ckbSick5.UseVisualStyleBackColor = true;
            // 
            // ckbSick6
            // 
            this.ckbSick6.AutoSize = true;
            this.ckbSick6.Location = new System.Drawing.Point(1066, 506);
            this.ckbSick6.Name = "ckbSick6";
            this.ckbSick6.Size = new System.Drawing.Size(18, 17);
            this.ckbSick6.TabIndex = 26;
            this.ckbSick6.UseVisualStyleBackColor = true;
            // 
            // ckbSick7
            // 
            this.ckbSick7.AutoSize = true;
            this.ckbSick7.Location = new System.Drawing.Point(1066, 538);
            this.ckbSick7.Name = "ckbSick7";
            this.ckbSick7.Size = new System.Drawing.Size(18, 17);
            this.ckbSick7.TabIndex = 27;
            this.ckbSick7.UseVisualStyleBackColor = true;
            // 
            // ckbSick8
            // 
            this.ckbSick8.AutoSize = true;
            this.ckbSick8.Location = new System.Drawing.Point(1066, 567);
            this.ckbSick8.Name = "ckbSick8";
            this.ckbSick8.Size = new System.Drawing.Size(18, 17);
            this.ckbSick8.TabIndex = 28;
            this.ckbSick8.UseVisualStyleBackColor = true;
            // 
            // ckbSick9
            // 
            this.ckbSick9.AutoSize = true;
            this.ckbSick9.Location = new System.Drawing.Point(1066, 596);
            this.ckbSick9.Name = "ckbSick9";
            this.ckbSick9.Size = new System.Drawing.Size(18, 17);
            this.ckbSick9.TabIndex = 29;
            this.ckbSick9.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(130, 632);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 29);
            this.label18.TabIndex = 30;
            this.label18.Text = "II. Kết luận";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(157, 678);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(262, 20);
            this.label19.TabIndex = 31;
            this.label19.Text = "Đủ điều kiện tiêm chủng ngay:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(419, 678);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 20);
            this.label20.TabIndex = 32;
            this.label20.Text = "Tất cả đều ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(518, 678);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 20);
            this.label21.TabIndex = 33;
            this.label21.Text = "Không";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(585, 678);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(151, 20);
            this.label22.TabIndex = 34;
            this.label22.Text = "có điểm bất thường";
            // 
            // ckbDuDieuKien
            // 
            this.ckbDuDieuKien.AutoSize = true;
            this.ckbDuDieuKien.Location = new System.Drawing.Point(1066, 666);
            this.ckbDuDieuKien.Name = "ckbDuDieuKien";
            this.ckbDuDieuKien.Size = new System.Drawing.Size(18, 17);
            this.ckbDuDieuKien.TabIndex = 35;
            this.ckbDuDieuKien.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(489, 724);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(273, 32);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLuu_click);
            // 
            // frmTaoPhieuKhamSangLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 829);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.ckbDuDieuKien);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ckbSick9);
            this.Controls.Add(this.ckbSick8);
            this.Controls.Add(this.ckbSick7);
            this.Controls.Add(this.ckbSick6);
            this.Controls.Add(this.ckbSick5);
            this.Controls.Add(this.ckbSick4);
            this.Controls.Add(this.ckbSick3);
            this.Controls.Add(this.ckbSick2);
            this.Controls.Add(this.ckbSick1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmboxMaNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txTenKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNgayTao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCmnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTaoPhieuKhamSangLoc";
            this.Text = "TaoPhieuKhamSangLoc";
            this.Load += new System.EventHandler(this.frmTaoPhieuKhamSangLoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.TextBox txtNgayTao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmboxMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox ckbSick1;
        private System.Windows.Forms.CheckBox ckbSick2;
        private System.Windows.Forms.CheckBox ckbSick3;
        private System.Windows.Forms.CheckBox ckbSick4;
        private System.Windows.Forms.CheckBox ckbSick5;
        private System.Windows.Forms.CheckBox ckbSick6;
        private System.Windows.Forms.CheckBox ckbSick7;
        private System.Windows.Forms.CheckBox ckbSick8;
        private System.Windows.Forms.CheckBox ckbSick9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox ckbDuDieuKien;
        private System.Windows.Forms.Button btnLuu;
    }
}