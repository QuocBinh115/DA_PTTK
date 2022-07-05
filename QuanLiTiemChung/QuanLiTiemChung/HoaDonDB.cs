using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using sqlConnect;
using MySql.Data.MySqlClient;

namespace QuanLiTiemChung
{
    class HoaDonDB
    {
        public static string ThemHD(DateTime NgayHen)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                
                MySqlCommand cmd = new MySqlCommand("sp_TaoHD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("i_Loai", MySqlDbType.VarChar, 10).Value = "MH";
                cmd.Parameters.Add("i_MaKH", MySqlDbType.VarChar, 10).Value = User.current.MaKH;
                cmd.Parameters.Add("i_NgayHen", MySqlDbType.Date, 10).Value = NgayHen;
                cmd.Parameters.Add("i_NguoiLap", MySqlDbType.VarChar, 10).Value = "NV00000001";

                //cmd.ExecuteNonQuery();
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
            return dt.Rows[0]["MaHD"].ToString();
        }
        public static string ThemDH(DateTime NgayHen)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_TaoHD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("i_Loai", MySqlDbType.VarChar, 10).Value = "DH";

                cmd.Parameters.Add("i_MaKH", MySqlDbType.VarChar, 10).Value = User.current.MaKH;
                cmd.Parameters.Add("i_NgayHen", MySqlDbType.Date, 10).Value = NgayHen;
                cmd.Parameters.Add("i_NguoiLap", MySqlDbType.VarChar, 10).Value = "NV00000000";

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
            return "";
        }
        public static DataTable DocDSHoaDon()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_XemHoaDon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
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
    }
}
