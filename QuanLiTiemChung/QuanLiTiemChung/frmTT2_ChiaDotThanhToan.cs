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
    public partial class frmTT2_ChiaDotThanhToan : Form
    {
        public frmTT2_ChiaDotThanhToan()
        {
            InitializeComponent();
        }

        private void bt_laphoadon_Click(object sender, EventArgs e)
        {
            frmTT3_LapHoaDon laphoadon = new frmTT3_LapHoaDon();
            this.Visible = false;
            laphoadon.ShowDialog();
            this.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_thanhtoandonhang_Click(object sender, EventArgs e)
        {

        }

        private void bt_DangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
