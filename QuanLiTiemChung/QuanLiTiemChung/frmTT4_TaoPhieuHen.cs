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
    public partial class frmTT4_TaoPhieuHen : Form
    {
        public frmTT4_TaoPhieuHen()
        {
            InitializeComponent();
        }

        private void lb_thanhtoandonhang_Click(object sender, EventArgs e)
        {

        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_DangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_taophieuhen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tạo phiếu hẹn thành công!", "Thông báo!");
            return;
        }
    }
}
