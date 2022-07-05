using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiTiemChung
{
    class HoaDon
    {
        string MaHD="";
        DataTable ctHD;
        string LoaiHD;
        DateTime NgayHen;

        public HoaDon(DataTable input,string type)
        {
            LoaiHD = type;
            ctHD = input;
        }
        public bool TaoHoaDon(DateTime Ngay)
        {
            NgayHen = Ngay;

            if (LoaiHD == "MH")
            {
                MaHD = HoaDonDB.ThemHD(NgayHen);
                foreach (DataRow ct in ctHD.Rows){
                    ctHoaDon a = new ctHoaDon(ct);
                    a.TaoCTHoaDon(MaHD);
                }
            }
            else
            {
                MaHD = HoaDonDB.ThemDH(NgayHen);

            }
            return true;
        }
        public static DataTable LayDSHoaDon()
        {
            return HoaDonDB.DocDSHoaDon();
        }
    }
}
