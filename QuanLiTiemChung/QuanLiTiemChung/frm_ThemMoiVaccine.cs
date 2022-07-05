using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using sqlConnect;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QuanLiTiemChung
{
    public partial class frm_ThemMoiVaccine : Form
    {
        public frm_ThemMoiVaccine()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ThemVaccine_btn_Click(object sender, EventArgs e)
        {
           
            string ten = TenVaccine_input.Text;
            string NSX = NSX_input.Text;
            DateTime HSD = HSD_input.Value;
            if (ten == "" || NSX == "" || HSD == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo");
                return;
            }
            Vaccine_19120640 newVX = new Vaccine_19120640();
            newVX.TenVX = ten;
            newVX.NSX = NSX;
            newVX.HSD = HSD;
            newVX.ThemVaccinemoi();
            MessageBox.Show("Thêm vaccine thành công!", "Thông báo");
            this.Controls.Clear();
            this.InitializeComponent();

        }
    }
}
