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
    class ctHoaDonDB
    {
        public static bool ThemCTHD(string MaHD,string MaGT,int SoLuong)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_ThemCTHD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("i_MaHD", MySqlDbType.VarChar, 10).Value = MaHD;
                cmd.Parameters.Add("i_MaGT", MySqlDbType.VarChar, 10).Value = MaGT;
                cmd.Parameters.Add("i_SoLuong", MySqlDbType.VarChar, 10).Value = SoLuong;

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


    }
}
