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
        DataTable ChiTietHD;
        string LoaiHD;
        //public HoaDon_1912640 dondathang;
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
            HoaDon hd = new HoaDon(ChiTietHD, LoaiHD);
            hd.TaoHoaDon(date_ngayhen.Value);

            frmTT4_TaoPhieuHen taophieuhen = new frmTT4_TaoPhieuHen();
            this.Visible = true;
            taophieuhen.LoadData(ChiTietHD, "MH");
            taophieuhen.NgayHen(date_ngayhen.Value);
            taophieuhen.Show();
            this.Visible = false;
        }

        private void lb_thanhtien_Click(object sender, EventArgs e)
        {

        }

        private void frmTT3_LapHoaDon_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(DataTable data,string type)
        {
            ChiTietHD = data;
            gv_dsGoiTiem.DataSource = ChiTietHD;
            LoaiHD = type;
            txt_diachi.Text = User.current.DiaChi;
            txt_ma.Text = User.current.MaKH;
            date_ngayhen.Value = DateTime.Today;
            txt_ten.Text = User.current.TenKH;
            txt_sdt.Text = User.current.SDT;
            int TongTien = 0;
            foreach(DataRow row in data.Rows)
            {
                int SoLuong = Int32.Parse(row["SoLuong"].ToString());
                int DonGia = Int32.Parse(row["DonGia"].ToString());
                TongTien = TongTien + (SoLuong * DonGia);
            }
            txt_thanhtien.Text = TongTien.ToString("#,0.###") + " VNĐ";
        }

        private void gv_dsGoiTiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_chiadottt_Click(object sender, EventArgs e)
        {
            frmTT2_ChiaDotThanhToan chiaDotThanhToan = new frmTT2_ChiaDotThanhToan();
            //this.Visible = true;
            chiaDotThanhToan.LoadData(ChiTietHD, "MH");
            chiaDotThanhToan.LayNgayHen(date_ngayhen.Value);
            chiaDotThanhToan.Show();
            //this.Visible = false;
        }


    }
}
