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
        DataRow ct;

        public ctHoaDon(DataRow d)
        {
            ct = d;
        }
        public static bool kiemTraCTHD()
        {

            return true;
        }
        public static DataTable LayCTHoaDon(string MaHD)
        {
            return ctHoaDonDB.XemCTHoaDon(MaHD);
        }
        public bool TaoCTHoaDon(string MaHD)
        {
            string MaGT =ct["GoiVacXin"].ToString();
            int SoLuong =Int32.Parse(ct["SoLuong"].ToString());
            return ctHoaDonDB.ThemCTHD( MaHD,  MaGT,  SoLuong);
        }
    }
}