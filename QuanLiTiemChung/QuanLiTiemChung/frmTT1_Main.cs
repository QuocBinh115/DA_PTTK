using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTiemChung
{
    public partial class frmTT1_Main : Form
    {
        public frmTT1_Main()
        {
            InitializeComponent();
            //this.Text = String.Empty;
            //this.ControlBox = false;
        }

        private void lb_User_Click(object sender, EventArgs e)
        {

        }

        private void pic_User_Click(object sender, EventArgs e)
        {

        }

        private void bt_DangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_laphoadon_Click(object sender, EventArgs e)
        {
            frmTT3_LapHoaDon laphoadon = new frmTT3_LapHoaDon();
            this.Visible = false;
            laphoadon.ShowDialog();
            this.Visible = true;
        }

        private void bt_chiadot_Click(object sender, EventArgs e)
        {
            frmTT2_ChiaDotThanhToan chiadotthanhtoan = new frmTT2_ChiaDotThanhToan();
            this.Visible = false;
            chiadotthanhtoan.ShowDialog();
            this.Visible = true;
        }
    }
}
