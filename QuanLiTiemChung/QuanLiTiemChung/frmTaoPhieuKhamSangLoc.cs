using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTiemChung.PhieuKhamSangLoc
{
    public partial class frmTaoPhieuKhamSangLoc : Form
    {
        public frmTaoPhieuKhamSangLoc()
        {
            InitializeComponent();
            setTingNhanVien();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCmndChange(object sender, EventArgs e)
        {
            if(txtCmnd.Text == "" || txTenKH.Text == "Không tồn tại")
            {

            } else
            {
                txTenKH.Text = KhachHang.layKHtuCMND(txtCmnd.Text).TenKH;
            }
        }

        private void btnLuu_click(object sender, MouseEventArgs e)
        {
            if (txtCmnd.Text != "" && txTenKH.Text != "Không tồn tại" && cmboxMaNV.Text != "" )
            {
                int[] sicks = { ckbSick1.Checked?1:0, ckbSick2.Checked ? 2 : 0,
                ckbSick3.Checked?3:0,ckbSick4.Checked?4:0,ckbSick5.Checked?5:0,ckbSick6.Checked?6:0,
                    ckbSick7.Checked?7:0,ckbSick8.Checked?8:0,ckbSick9.Checked?9:0};
                if(ctHSBN.them(KhachHang.layKHtuCMND(txtCmnd.Text).MaKH, txtNgayTao.Text, cmboxMaNV.Text, sicks))
                {
                    MessageBox.Show("Lưu thông tin thành công");
                } else
                {
                    MessageBox.Show("Lưu không thành công");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }

        private void frmTaoPhieuKhamSangLoc_Load(object sender, EventArgs e)
        {

        }
    }
}
