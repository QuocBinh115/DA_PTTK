using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTiemChung
{
    class ctDonDatHang
    {
        public string MaDonDH;
        public string MaVX;
        public int Soluong;
        public int ThanhTien;

        public int TinhThanhTien()
        {
            ThanhTien = Soluong * Vaccine_DB_19120640.LayGiaVaccine(MaVX);
            return ThanhTien;
        }
        public void ThemctDonDatHangMoi()
        {
            TinhThanhTien();
            ctDonDatHang_DB.ThemctDonDatHang(MaDonDH, MaVX, Soluong, ThanhTien);
        }
    }
}
