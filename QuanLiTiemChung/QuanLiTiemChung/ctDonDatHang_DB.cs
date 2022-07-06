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
    class ctDonDatHang_DB
    {
        public static void ThemctDonDatHang(string MaDH, string MaVX, int soluong, int ThanhTien)
        {
            
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            string sql_cmd;
            sql_cmd = "sp_ThemCTDatHang";
            //string result = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("i_MaDonDH", MySqlDbType.VarChar, 50).Value = MaDH;
                cmd.Parameters.Add("i_MaVX", MySqlDbType.VarChar, 50).Value = MaVX;
                cmd.Parameters.Add("i_SoLuong", MySqlDbType.Int32).Value = soluong;
                cmd.Parameters.Add("i_ThanhTien", MySqlDbType.Int32).Value = ThanhTien;
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                //da.Fill(dt);
                //result = dt.Rows[0][0].ToString();


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
            //return result;
            
        }
    }
}
