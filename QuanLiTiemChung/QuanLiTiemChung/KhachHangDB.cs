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
                User.current.MaKH = dt.Rows[0]["MaKH"].ToString();
                User.current.TenKH = dt.Rows[0]["HoTenKH"].ToString();
                User.current.NgaySinh = DateTime.ParseExact(dt.Rows[0]["niceDate"].ToString(), "dd/MM/yyyy", null);
                User.current.GioiTinh = dt.Rows[0]["GioiTinh"].ToString() == "True" ? true : false;
                User.current.SDT = dt.Rows[0]["SDT"].ToString();
                User.current.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                User.current.CMND = dt.Rows[0]["CMND"].ToString();

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
        public static KhachHang layKHtuCMND(string cmnd)
        {
            KhachHang result = new KhachHang();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            string sql_cmd;
            sql_cmd = "select * from KhachHang where CMND = '" + cmnd + "';";


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return result;
                }
                result.MaKH = dt.Rows[0]["MaKH"].ToString();
                result.TenKH = dt.Rows[0]["HoTenKH"].ToString();
                result.NgaySinh = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString());
                result.GioiTinh = dt.Rows[0]["GioiTinh"].ToString() == "True" ? true : false;
                result.SDT = dt.Rows[0]["SDT"].ToString();
                result.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                result.CMND = dt.Rows[0]["CMND"].ToString();

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
            return result;

        }
    }
}
