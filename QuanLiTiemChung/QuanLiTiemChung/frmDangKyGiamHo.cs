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
    }
}
