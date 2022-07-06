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
        public Boolean KiemDuyet = false;
        public int TongTien;
        public List<ctDonDatHang> list_ctDatHang =new List<ctDonDatHang>();
        public string TaoDonHangMoi(string i_MaHD)
        {
            MaHD = i_MaHD;
            MaDonDH = DonDatHang_DB.TaoDonDatHang(MaHD);
            
            foreach (var list_ctDonDH in list_ctDatHang)
            {
                list_ctDonDH.MaDonDH = MaDonDH;
                list_ctDonDH.ThemctDonDatHangMoi();
            }

            return MaDonDH;
        }
        public int TinhTongTien()
        {
            TongTien = 0;
            foreach(var list_ctDonDH in list_ctDatHang)
            {
                TongTien += list_ctDonDH.ThanhTien;
            }
            return TongTien;
        }
    }
}
