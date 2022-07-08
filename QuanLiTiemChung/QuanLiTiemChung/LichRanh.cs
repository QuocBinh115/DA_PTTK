using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiTiemChung
{
    class LichRanh
    {
        DateTime Ngay;
        string Ca;
        public LichRanh(DateTime n, string c)
        {
            Ngay = n;
            Ca = c;
        }
        public bool TaoLichRanh()
        {

            return LichRanhDB.ThemLichRanh(Ngay, Ca);
   
        }
        public static DataTable XemLichRanh()
        {
            return LichRanhDB.LayLichRanh();
        }
    }
}
