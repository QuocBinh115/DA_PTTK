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
    public partial class frmDangKyTiemChung : Form
    {
        public frmDangKyTiemChung()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (checkIsChild.Checked)
            {
                frmDangKyGiamHo gh = new frmDangKyGiamHo();
                gh.Show();
                //this.Close();
            }
            else
            {
                frmChonVacXin ch = new frmChonVacXin();
                ch.Show();
                //this.Close();

            }
        }

        private void frmDangKyTiemChung_Load(object sender, EventArgs e)
        {
            //KhachHang kh = new KhachHang();
            KhachHang.LayThongTin("KH00000000");

            txtHoTen.Text = KhachHang.TenKH;
            date_ngaySinh.Value = KhachHang.NgaySinh;
            txtDiaChi.Text = KhachHang.DiaChi;
            txtCMND.Text = KhachHang.CMND;
            txtSDT.Text = KhachHang.SDT;
            if (KhachHang.GioiTinh == true)
            { checkNam.Checked = true; }
            else
            {
                checkNu.Checked = true;

            }


        }
    }
}
