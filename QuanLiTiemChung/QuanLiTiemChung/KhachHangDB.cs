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
    class KhachHangDB
    {
        public static bool DocTTKhachHang(string MaKH)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            string sql_cmd;
            sql_cmd = "select *, DATE_FORMAT(NgaySinh,'%d/%m/%Y') AS niceDate from KhachHang where MaKH = '" + MaKH + "';";


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if(dt.Rows.Count == 0)
                {
                    return false;
                }
                KhachHang.MaKH = dt.Rows[0]["MaKH"].ToString();
                KhachHang.TenKH = dt.Rows[0]["HoTenKH"].ToString();
                KhachHang.NgaySinh = DateTime.ParseExact(dt.Rows[0]["niceDate"].ToString(), "dd/MM/yyyy", null);
                KhachHang.GioiTinh = dt.Rows[0]["GioiTinh"].ToString() == "True" ? true : false;
                KhachHang.SDT = dt.Rows[0]["SDT"].ToString();
                KhachHang.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                KhachHang.CMND = dt.Rows[0]["CMND"].ToString();

            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error);
                Console.WriteLine(error.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return true;

        }
    }
}
