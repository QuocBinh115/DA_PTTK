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
    class DonDatHang_DB
    {
        public static string TaoDonDatHang(string maHD)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            string sql_cmd;
            sql_cmd = "sp_DatHang";
            string result = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("i_MaHD", MySqlDbType.VarChar, 50).Value = maHD;
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
