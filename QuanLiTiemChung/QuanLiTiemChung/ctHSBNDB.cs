using MySql.Data.MySqlClient;
using sqlConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTiemChung
{
    class ctHSBNDB
    {
        public static bool them(string maBn, string ngayKham, string maNv, int stt, string mota)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {

                MySqlCommand cmd = new MySqlCommand("sp_ThemCTHSBN", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("i_MaBN", MySqlDbType.VarChar, 10).Value = maBn;
                cmd.Parameters.Add("i_NgayKham", MySqlDbType.Date, 10).Value = DateTime.Parse(ngayKham);
                cmd.Parameters.Add("i_NguoiKham", MySqlDbType.VarChar, 10).Value = maNv;
                cmd.Parameters.Add("i_STT", MySqlDbType.Int32, 10).Value = Int32.Parse(stt.ToString());
                cmd.Parameters.Add("i_MoTa", MySqlDbType.VarChar, 10).Value = mota;
                //cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error);
                Console.WriteLine(error.StackTrace);
                return false;
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
