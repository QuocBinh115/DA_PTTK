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
        public static bool ThemHD(string MaKH)
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

                cmd.Parameters.Add("i_MaKH", MySqlDbType.VarChar, 10).Value = MaKH;
                cmd.Parameters.Add("i_NgayHen", MySqlDbType.Date, 10).Value = "2016-02-07";
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
            return true;
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
