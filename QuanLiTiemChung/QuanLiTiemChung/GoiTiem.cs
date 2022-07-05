using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QuanLiTiemChung
{
    class GoiTiem
    {
        //public DataTable data = new DataTable();

        public static DataTable DocDSGoiTiem()
        {
            return GoiTiemDB.LayDSGoiTiem();
        }

        public static DataTable DocTTGoiTiem(string MaGT)
        {
            return GoiTiemDB.LayTTGoiTiem(MaGT);
        }

    }
}
