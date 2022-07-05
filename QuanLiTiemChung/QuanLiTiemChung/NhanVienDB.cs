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
    class NhanVienDB
    {
        public static DataTable LayLichRanh()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_XemLichLamViec", conn);
                cmd.CommandType = CommandType.StoredProcedure;
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
            return dt;

        }

        public static DataTable LayLichRanh(string MaNV)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM LICHLAMVIEC WHERE MaNV='" +MaNV+"';", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
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
            return dt;

        }
        public static DataTable LayDSNV()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("select MaNV from NhanVien order by MaNV", conn);
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
            return dt;

        }

    }
}
