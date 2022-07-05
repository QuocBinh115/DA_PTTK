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
        string MaHD;
        DataTable ctHD;
        string LoaiHD;

        public HoaDon(DataTable input,string type)
        {
            LoaiHD = type;
            ctHD = input;
  
        }
        public bool TaoHoaDon(DataTable ctHD)
        {
            if (LoaiHD == "MH")
            {

            }
            else
            {

            }
            return true;
        }
        public static DataTable LayDSHoaDon()
        {
            return HoaDonDB.DocDSHoaDon();
        }
    }
}
