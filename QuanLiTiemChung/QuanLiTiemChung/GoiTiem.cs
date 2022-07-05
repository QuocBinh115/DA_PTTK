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
        string MaGT;
        int SoLuong;
        public GoiTiem(string Ma,int sl)
        {
            MaGT = Ma;
            SoLuong = sl;
        }

        public static DataTable DocDSGoiTiem()
        {
            return GoiTiemDB.LayDSGoiTiem();
        }

        public DataTable DocTTGoiTiem()
        {
            return GoiTiemDB.LayTTGoiTiem(MaGT);
        }
        public bool KiemtraTTGoiTiem()
        {
            bool flag = true;
            DataTable dt = GoiTiemDB.KiemtraGoiTiem(MaGT, SoLuong);
            foreach (DataRow row in dt.Rows)
            {
                int len = row.ItemArray.Length;
                for (int i = 0; i < len; i++)
                {
                    if (row["sl"].ToString() != "1")
                    {
                        flag = false;
                    }
                }
            }
            return flag; 
        }

    }
}
