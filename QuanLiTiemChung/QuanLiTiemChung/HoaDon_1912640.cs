using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTiemChung
{
    class HoaDon_1912640
    {
        public string MaHD;
        public string LoaiHD;
        public string MaKH;
        public DateTime NgayHen;
        public string NguoiLap;

        public string TaoHoaDonMoi()
        {
            MaHD = HoaDon_DB_19120640.TaoHoaDon(LoaiHD, MaKH, NgayHen, NguoiLap);
            return MaHD;
        }
    }
}
