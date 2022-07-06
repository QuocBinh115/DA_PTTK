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
        DataTable ChiTietHD;
        string LoaiHD;

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
            this.Close();
        }

        public void LoadData(DataTable data, string type)
        {
            ChiTietHD = data;
            gv_thongtindonhang.DataSource = ChiTietHD;
            LoaiHD = type;
            txt_diachi.Text = User.current.DiaChi;
            txt_ma.Text = User.current.MaKH;
            date_ngayhen.Value = DateTime.Today;
            txt_ten.Text = User.current.TenKH;
            txt_sdt.Text = User.current.SDT;
        }
    }
}
