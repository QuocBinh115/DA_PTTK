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
    public partial class frmDangKyGiamHo : Form
    {
        public frmDangKyGiamHo()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmChonVacXin ch = new frmChonVacXin();
            ch.Show();
            this.Close();
        }

        private void frmDangKyGiamHo_Load(object sender, EventArgs e)
        {
            User.current.LayThongTin();

            txtHoTen.Text = User.current.TenKH;
            date_ngaySinh.Value = User.current.NgaySinh;
            txtDiaChi.Text = User.current.DiaChi;
            txtCMND.Text = User.current.CMND;
            txtSDT.Text = User.current.SDT;
            if (User.current.GioiTinh == true)
            { checkNam.Checked = true; }
            else
            {
                checkNu.Checked = true;
            }
        }

        private void bt_DangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            string cmnd = txtCMND.Text;
            KhachHang GiamHo = new KhachHang("", cmnd);
            if (!GiamHo.KiemTraTonTai())
            {
                GiamHo.TenKH = txtHoTen.Text;
                GiamHo.SDT = txtSDT.Text;
                GiamHo.NgaySinh = date_ngaySinh.Value;
                GiamHo.quanhe = txtQuanHe.Text;
                GiamHo.DiaChi = txtDiaChi.Text;
                if (!GiamHo.ThemGiamHo()) {
                    return;
                };
            }
            
            frmChonVacXin frm = new frmChonVacXin();
            frm.Show();
        }
    }
}
