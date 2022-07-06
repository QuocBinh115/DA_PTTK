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
    public partial class frmPhieuXacNhanTiem : Form
    {
        public frmPhieuXacNhanTiem()
        {
            InitializeComponent();
        }

        private void frmPhieuXacNhanTiem_Load(object sender, EventArgs e)
        {

        }

        private void txtCmndChange(object sender, EventArgs e)
        {
            if (txtCmnd.Text == "" || txtNv.Text == "Không tồn tại")
            {

            }
            else
            {
                KhachHang kh = KhachHang.layKHtuCMND(txtCmnd.Text);
                txtTenKH.Text = kh.TenKH;
                txtDiaChi.Text = kh.DiaChi;
                txtNgaySinh.Text = kh.NgaySinh.ToString("yyyy-MM-dd");
                txtSDT.Text = kh.SDT;
                HoSoBN hs = HoSoBN.layThongtinTuBN(kh.MaKH);
                txtNv.Text = hs.maNguoiTiem;
                txtTime.Text = hs.ngayKham;

                

            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
