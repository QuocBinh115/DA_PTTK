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
    public partial class frm_DatMuaVaccine : Form
    {
        public frm_DatMuaVaccine()
        {
            InitializeComponent();
        }

        private void frm_DatMuaVaccine_Load(object sender, EventArgs e)
        {
            KhachHang user = new KhachHang();
            user.LayThongTin("KH002");
            Console.WriteLine(KhachHang.TenKH);
            Console.WriteLine(KhachHang.DiaChi) ;
            Console.WriteLine(KhachHang.NgaySinh);
            Console.WriteLine(KhachHang.GioiTinh);
        }
    }
}
