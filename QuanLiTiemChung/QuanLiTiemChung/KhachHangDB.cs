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
        public static DataTable DocTTTuCMND(string cmnd)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            string sql_cmd;
            sql_cmd = "select *,DATE_FORMAT(NgaySinh,'%d/%m/%Y') AS niceDate from KhachHang where CMND = '" + cmnd + "';";


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
 
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
            return dt;
        }
        public static bool TaoGiamHo(KhachHang gh)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            bool flag = true;

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_ThemGiamHo", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("i_MaKH", MySqlDbType.VarChar, 10).Value = User.current.MaKH;
                cmd.Parameters.Add("i_HoTen", MySqlDbType.VarChar, 50).Value = gh.TenKH;
                cmd.Parameters.Add("i_NgaySinh", MySqlDbType.Date, 10).Value = gh.NgaySinh;
                cmd.Parameters.Add("i_GioiTinh", MySqlDbType.Bit, 1).Value = gh.GioiTinh;
                cmd.Parameters.Add("i_DiaChi", MySqlDbType.VarChar, 100).Value = gh.DiaChi;
                cmd.Parameters.Add("i_CMND", MySqlDbType.VarChar, 12).Value = gh.CMND;
                cmd.Parameters.Add("i_SDT", MySqlDbType.VarChar, 10).Value = gh.SDT;
                cmd.Parameters.Add("i_qh", MySqlDbType.VarChar, 10).Value = gh.quanhe;

                //cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);

            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error);
                Console.WriteLine(error.StackTrace);
                flag = false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return flag;
        }
    }
}
