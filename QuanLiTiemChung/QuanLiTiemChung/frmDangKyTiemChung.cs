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
            if(!KhachHang.KiemtraThongTin(txtCMND.Text, txtSDT.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                return;
            }
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
            User.current = new KhachHang("KH00000000");
            //KhachHang kh = new KhachHang();

            //KhachHang.LayThongTin("KH00000000");
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

        private void btn_DatVacxin_Click(object sender, EventArgs e)
        {
            frm_DatMuaVaccine frm = new frm_DatMuaVaccine();
            frm.Show();
        }
    }
}
