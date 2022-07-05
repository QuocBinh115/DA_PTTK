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
    public partial class frmDangKyLichRanh : Form
    {
        public frmDangKyLichRanh()
        {
            InitializeComponent();
        }

        private void btnThemLichRanh_Click(object sender, EventArgs e)
        {
            DateTime Ngay = (DateTime)dtpThemNgay.Value;
            string Ca = cbbThemCa.SelectedItem.ToString();
            LichRanh l = new LichRanh(Ngay, Ca);
            if (!l.TaoLichRanh())
            {
                MessageBox.Show("Lịch đã tồn tại");
                return;
            };
            gvLichRanh.DataSource = LichRanh.XemLichRanh();
        }

        private void frmDangKyLichRanh_Load(object sender, EventArgs e)
        {
            gvLichRanh.DataSource = LichRanh.XemLichRanh();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_DangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
