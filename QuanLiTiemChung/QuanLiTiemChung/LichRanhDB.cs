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
    class LichRanhDB
    {
        public static DataTable LayLichRanh()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_XemLichRanh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("i_MaNV", MySqlDbType.VarChar, 10).Value = NhanVien.MaNV;


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
        public static bool ThemLichRanh(DateTime Ngay, string Ca)
        {
            bool flag = true;
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_ThemLichRanh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("i_MaNV", MySqlDbType.VarChar, 10).Value = NhanVien.MaNV;
                cmd.Parameters.Add("i_Ngay", MySqlDbType.Date, 10).Value = Ngay;
                cmd.Parameters.Add("i_Ca", MySqlDbType.VarChar, 10).Value = Ca;

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
