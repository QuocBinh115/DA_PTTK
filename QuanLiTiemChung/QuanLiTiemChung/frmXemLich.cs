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
    public partial class frmXemLich : Form
    {
        public frmXemLich()
        {
            InitializeComponent();
        }

        private void frmXemLich_Load(object sender, EventArgs e)
        {
            cb_MaNV.DataSource = NhanVien.XemDSNV();
            cb_MaNV.DisplayMember = "MaNV";
            cb_MaNV.ValueMember = "MaNV";
            gvLichLamViec.DataSource = NhanVien.XemLichRanh();
        }

        private void cb_MaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(cb_MaNV.SelectedValue.ToString());

            gvLichLamViec.DataSource = NhanVien.XemLichRanh(cb_MaNV.SelectedValue.ToString());
            //gvLichLamViec.DataSource = NhanVien.XemLichRanh("' or True; #");
        }
    }
}
