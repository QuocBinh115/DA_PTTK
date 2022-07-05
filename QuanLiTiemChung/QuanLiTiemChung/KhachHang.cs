using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using sqlConnect;
using System.Data;

namespace QuanLiTiemChung
{
    class KhachHang
    {
        public static string MaKH;
        public static string TenKH;
        public static DateTime NgaySinh;
        public static bool GioiTinh;
        public static string SDT;
        public static string DiaChi;
        public static string CMND;

        public static bool LayThongTin(string MaKH) {
            return KhachHangDB.DocTTKhachHang(MaKH);
        }
        public static bool KiemtraThongTin(string CMND,string SDT)
        {
            bool flag = true;
            //Console.WriteLine(CMND.Length +"x"+ SDT.Length);
            if(CMND.Length!=9 && CMND.Length != 12)
            {
                flag = false;
            }
            if (SDT.Length != 10 )
            {
                flag = false;
            }
            return flag;
        }
    }
}
