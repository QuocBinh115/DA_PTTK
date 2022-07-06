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
        public string MaKH;
        public string TenKH;
        public DateTime NgaySinh;
        public bool GioiTinh;
        public string SDT;
        public string DiaChi;
        public string CMND;

        public KhachHang(string Ma)
        {
            MaKH = Ma;
        }
        public bool LayThongTin() {
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
    static class User
    {
        public static KhachHang current;
        // = new KhachHang("KH00000000");

    }
}
