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
    class HoaDon_DB_19120640
    {
        public static string TaoHoaDon(string loaiHD, string MaKH, DateTime NgayHen, string NguoiLap)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            string sql_cmd;
            sql_cmd = "sp_TaoHD";
            string result = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("i_Loai", MySqlDbType.VarChar, 50).Value = loaiHD;
                cmd.Parameters.Add("i_MaKH", MySqlDbType.VarChar, 50).Value = MaKH;
                cmd.Parameters.Add("i_NgayHen", MySqlDbType.VarChar, 50).Value = NgayHen.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("i_NguoiLap", MySqlDbType.VarChar, 50).Value = NguoiLap;
                //cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
                result = dt.Rows[0][0].ToString();


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
