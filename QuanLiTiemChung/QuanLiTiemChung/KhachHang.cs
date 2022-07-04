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
        public static string MaKH ="KH00000000";
        public static string TenKH;
        public static DateTime NgaySinh;
        public static Boolean GioiTinh;
        public static string SDT;
        public static string DiaChi;
        public static string CMND;

        public void LayThongTin(string MaKH) {
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
                TenKH = dt.Rows[0]["HoTenKH"].ToString();
                MaKH = dt.Rows[0]["MaKH"].ToString();
                NgaySinh = DateTime.ParseExact(dt.Rows[0]["niceDate"].ToString(), "dd/MM/yyyy", null);
                GioiTinh = dt.Rows[0]["GioiTinh"].ToString()== "True" ? true:false;
                SDT = dt.Rows[0]["SDT"].ToString();
                DiaChi = dt.Rows[0]["DiaChi"].ToString();
                CMND = dt.Rows[0]["CMND"].ToString();

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
        }

        
    }
}
