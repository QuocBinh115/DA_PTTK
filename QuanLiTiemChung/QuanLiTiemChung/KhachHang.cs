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
        public string quanhe;

        public KhachHang(string Ma)
        {
            MaKH = Ma;
        }
        public KhachHang(string Ma,string cmt)
        {
            MaKH = Ma;
            CMND = cmt;

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
        public bool KiemTraTonTai()
        {
            bool flag = true;
            DataTable dt = KhachHangDB.DocTTTuCMND(CMND);
            if (dt.Rows.Count < 1)
            {
                flag = false;
            }
            else
            {
                MaKH = dt.Rows[0]["MaKH"].ToString();
                TenKH = dt.Rows[0]["HoTenKH"].ToString();
                NgaySinh = DateTime.ParseExact(dt.Rows[0]["niceDate"].ToString(), "dd/MM/yyyy", null);
                GioiTinh = dt.Rows[0]["GioiTinh"].ToString() == "True" ? true : false;
                SDT = dt.Rows[0]["SDT"].ToString();
                DiaChi = dt.Rows[0]["DiaChi"].ToString();
                CMND = dt.Rows[0]["CMND"].ToString();
            };
            return flag;
        }
        public bool ThemGiamHo()
        {
            KhachHangDB.TaoGiamHo(this);
            return this.KiemTraTonTai();
        }
    }
    static class User
    {
        public static KhachHang current;
        // = new KhachHang("KH00000000");

    }
}
