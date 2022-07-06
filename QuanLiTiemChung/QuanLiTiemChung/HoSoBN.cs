using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTiemChung
{
    class HoSoBN
    {
        public string maBn;
        public string ngayKham;
        public string maNguoiTiem;


        public static bool them(string maBn, string ngayKham, string maNv)
        {
            return HoSoBNDB.them(maBn, ngayKham, maNv);
        }
        public static HoSoBN layThongtinTuBN(string maKH)
        {
            return HoSoBNDB.layThongtinTuBN(maKH);
        }
    }
}
