using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiTiemChung
{
    class ctHoaDon
    {
        public static bool kiemTraCTHD()
        {

            return true;
        }
        public static DataTable LayCTHoaDon(string MaHD)
        {
            return ctHoaDonDB.XemCTHoaDon(MaHD);
        }
    }
}
