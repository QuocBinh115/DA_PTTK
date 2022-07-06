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
        DataTable ChiTietHD;
        int TongTien = 0;
        string LoaiHD;
        DateTime NgayHen;

        public frmTT2_ChiaDotThanhToan()
        {
            InitializeComponent();
        }

        private void bt_laphoadon_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon(ChiTietHD, LoaiHD);
            hd.TaoHoaDon(NgayHen);

            frmTT4_TaoPhieuHen taophieuhen = new frmTT4_TaoPhieuHen();
            this.Visible = true;
            taophieuhen.LoadData(ChiTietHD, "MH");
            taophieuhen.NgayHen(NgayHen);
            taophieuhen.Show();
            this.Visible = false;
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

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_dtt_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cb_dtt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 1;
            if (cb_dtt.SelectedIndex == 0) count = 2;
            else if (cb_dtt.SelectedIndex == 1) count = 3;
            else if (cb_dtt.SelectedIndex == 2) count = 4;
            else if (cb_dtt.SelectedIndex == 3) count = 7;
            else if (cb_dtt.SelectedIndex == 4) count = 10;
            else if (cb_dtt.SelectedIndex == 5) count = 13;
            
            float mucthanhtoan = (float)TongTien / count;
            txt_mtt.Text = mucthanhtoan.ToString("#,0.###") + " VNĐ/Tháng";
            txt_thanhtien.Text = mucthanhtoan.ToString("#,0.###") + " VNĐ"; 
        }

        public void LoadData(DataTable data, string type)
        {
            ChiTietHD = data;
            gv_thongtindonhang.DataSource = ChiTietHD;
            LoaiHD = type;
            foreach (DataRow row in data.Rows)
            {
                int SoLuong = Int32.Parse(row["SoLuong"].ToString());
                int DonGia = Int32.Parse(row["DonGia"].ToString());
                TongTien = TongTien + (SoLuong * DonGia);
            }
            txt_tongcong.Text = TongTien.ToString("#,0.###") + " VNĐ";
        }

        public void LayNgayHen(DateTime date)
        {
            NgayHen = date;
        }
    }
}
