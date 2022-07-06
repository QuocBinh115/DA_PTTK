using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTiemChung
{
    class DonDatHang
    {
        public string MaDonDH;
        public string MaHD;
        public Boolean KiemDuyet;

        public string TaoDonHangMoi(string i_MaHD)
        {
            MaHD = i_MaHD;
            MaDonDH = DonDatHang_DB.TaoDonDatHang(MaHD);
            return MaDonDH;
        }
    }
}
