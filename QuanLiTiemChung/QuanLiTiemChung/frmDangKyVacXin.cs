using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sqlConnect;
using MySql.Data.MySqlClient;


namespace QuanLiTiemChung
{
    public partial class frmDangKyVacXin : Form
    {
        Dictionary<int, string> dsChon = new Dictionary<int, string>();
        public frmDangKyVacXin()
        {
            InitializeComponent();
        }

        private void frmDangKyVacXin_Load(object sender, EventArgs e)
        {
            GetDSVacXin();
            
        }
        private void lstDSVacXin_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_TTGoiTiem();
        }
        
        
        
        
        
        
        private void GetDSVacXin()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_XemDSGoiTiem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
                lstDSVacXin.DataSource = dt;
                lstDSVacXin.DisplayMember = "TenGT";
                lstDSVacXin.ValueMember = "MaGT";
                get_TTGoiTiem();
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
        private void get_TTGoiTiem()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("sp_XemCTGoiTiem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("i_MaGT", MySqlDbType.VarChar, 10).Value
                    = lstDSVacXin.SelectedValue;
                cmd.ExecuteNonQuery();

                da.SelectCommand = cmd;
                da.Fill(dt);
                gv_ChiTietGoi.DataSource = dt;

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dsChon.Remove(Int32.Parse(gv_DSChon.CurrentRow.Cells[0].Value.ToString()));
            UpdateDSChon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            dsChon.Add(dsChon.Count + 1, lstDSVacXin.SelectedValue.ToString());
            
            UpdateDSChon();
        }
        private void UpdateDSChon()
        {
            UpdateDSChonData();
            gv_DSChon.DataSource = (from entry in dsChon
                                    orderby entry.Key
                                    select new { entry.Key, entry.Value }).ToList(); ;
        }
        private void UpdateDSChonData()
        {
            Dictionary<int, string> tmp = new Dictionary<int, string>();

            foreach (var entry in dsChon)
            {
                tmp.Add(tmp.Count+1,entry.Value);
            }
            dsChon = tmp;
        }
    }
}
