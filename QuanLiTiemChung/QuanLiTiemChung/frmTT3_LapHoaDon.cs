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
    public partial class frmTT3_LapHoaDon : Form
    {
        public frmTT3_LapHoaDon()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void bt_laphoadon_Click(object sender, EventArgs e)
        {
            frmTT4_TaoPhieuHen taophieuhen = new frmTT4_TaoPhieuHen();
            //this.Visible = false;
            taophieuhen.Show();
            //this.Visible = true;
        }

        private void lb_thanhtien_Click(object sender, EventArgs e)
        {

        }

        private void frmTT3_LapHoaDon_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(DataTable data)
        {
            gv_dsGoiTiem.DataSource = data;
            txt_diachi.Text = KhachHang.DiaChi;
            txt_ma.Text = KhachHang.MaKH;
            date_ntns.Value = KhachHang.NgaySinh;
            txt_ten.Text = KhachHang.TenKH;
            txt_sdt.Text = KhachHang.SDT;
        }
    }
}
