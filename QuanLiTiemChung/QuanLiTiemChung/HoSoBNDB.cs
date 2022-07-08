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
    class HoSoBNDB
    {
        public static bool them(string maBn, string ngayKham, string maNv)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {

                MySqlCommand cmd = new MySqlCommand("sp_TaoHSBN", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("i_MaBN", MySqlDbType.VarChar, 10).Value = maBn;
                cmd.Parameters.Add("i_Ngay", MySqlDbType.Date, 10).Value = DateTime.Parse(ngayKham);
                cmd.Parameters.Add("i_NguoiTiem", MySqlDbType.VarChar, 10).Value = maNv;
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

        public static HoSoBN layThongtinTuBN(string maKH)
        {
            HoSoBN result = new HoSoBN();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            string sql_cmd;
            sql_cmd = "select * from hosobn where MaBN = '" + maKH + "';";


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return result;
                }
                result.maBn = dt.Rows[0]["MaBN"].ToString();
                result.maNguoiTiem = dt.Rows[0]["NguoiTiem"].ToString();
                result.ngayKham = dt.Rows[0]["NgayKham"].ToString();

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
