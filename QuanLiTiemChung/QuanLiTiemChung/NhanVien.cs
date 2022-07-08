using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiTiemChung
{
    class NhanVien
    {
        public static string MaNV="NV00000000";

        public static DataTable XemLichRanh()
        {
            return NhanVienDB.LayLichRanh();
        }
        public static DataTable XemDSNV()
        {
            return NhanVienDB.LayDSNV();
        }
        public static DataTable XemLichRanh(string MaNV)
        {
            return NhanVienDB.LayLichRanh(MaNV);
        }

        public static string[] layMaNV()
        {
            DataTable data = NhanVienDB.LayDSNV();
            string[] result = new string[data.Rows.Count];
            Console.WriteLine(data.Rows.Count);
            for (int i = 0; i < data.Rows.Count;i++)
            {
                result[i] = data.Rows[i]["MaNV"].ToString();
                
            }
            return result;
        }
    }
}
