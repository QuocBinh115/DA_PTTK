﻿using System;
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

        public static List<DonDatHang> DanhSach_ChuaDuyet()
        {
            List<DonDatHang> list_DS = new List<DonDatHang>();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            string sql_cmd;
            sql_cmd = "select * from dathang where KiemDuyet = 0;";


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                //cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
                DonDatHang temp;
                foreach (DataRow row in dt.Rows)
                {
                    temp = new DonDatHang();
                    temp.MaDonDH = row["MaDonDH"].ToString();
                    temp.MaHD = row["MaHD"].ToString();
                    temp.TongTien = Int32.Parse(row["TongTien"].ToString());
                    list_DS.Add(temp);
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
            return list_DS;
        }
        public static void DuyetDonDH(string MaDonDH)
        {
           
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            string sql_cmd;
            sql_cmd = "update dathang set KiemDuyet = 1 where MaDonDH = '"+ MaDonDH+"'; ";


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql_cmd, conn);
                cmd.ExecuteNonQuery();
 

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

        }
    }
}
