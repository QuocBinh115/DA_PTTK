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
    class Vaccine_DB_19120640
    {
        public static Dictionary<string, string> getAllvaccine()
        {
            Dictionary<string, string> list_VX = new Dictionary<string, string>();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            string sql_cmd;
            sql_cmd = "select * from Vaccine ;";


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                //cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    list_VX.Add(row["TenVX"].ToString(), row["MaVX"].ToString());
                }

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
            return list_VX;
        }
        public static string ThemVaccine(string TenVX, string NSX, DateTime HSD, int GiaMua)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            string sql_cmd;
            sql_cmd = "sp_ThemVaccine";
            string result = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("i_Ten", MySqlDbType.VarChar, 50).Value = TenVX;
                cmd.Parameters.Add("i_NXS", MySqlDbType.VarChar, 50).Value = NSX;
                cmd.Parameters.Add("i_HSD", MySqlDbType.VarChar, 50).Value = HSD.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("i_GiaMua", MySqlDbType.Int32).Value = GiaMua;
                //cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
                result =  dt.Rows[0][0].ToString();


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
        public static int LayGiaVaccine(string MaVX)
        {
             
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            string sql_cmd;
            sql_cmd = "select GiaMua from Vaccine where MaVX ='"+MaVX+"' ;";
            int result = 0;


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if(dt != null)
                {
                    result = Int32.Parse(dt.Rows[0][0].ToString());
                }

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
        public static string LayTenVaccine(string MaVX)
        {
             
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            string sql_cmd;
            sql_cmd = "select TenVX from Vaccine where MaVX ='"+MaVX+"' ;";
            string result ="";


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if(dt != null)
                {
                    result = dt.Rows[0][0].ToString();
                }

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
