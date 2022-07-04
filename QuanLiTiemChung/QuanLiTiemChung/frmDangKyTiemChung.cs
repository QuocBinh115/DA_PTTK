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
                this.Close();
            }
            else
            {
                frmChonVacXin ch = new frmChonVacXin();
                ch.Show();
                this.Close();

            }
        }

        private void frmDangKyTiemChung_Load(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.LayThongTin("KH002");
            txtHoTen.Text = kh.TenKH;
            date_ngaySinh.Value = kh.NgaySinh;
            txtDiaChi.Text = kh.DiaChi;
            txtCMND.Text = kh.CMND;
            txtSDT.Text = kh.SDT;
            if (kh.GioiTinh == true)
            { checkNam.Checked = true; }
            else
            {
                checkNu.Checked = true;

            }


        }
    }
}
