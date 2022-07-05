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
    public partial class frmChonVacXin : Form
    {
        DataTable data = new DataTable();
        
        public frmChonVacXin()
        {
            InitializeComponent();
        }

        private void frmDangKyVacXin_Load(object sender, EventArgs e)
        {
            KhachHang.LayThongTin("KH00000000");

            lstDSGoiTiem.DataSource = GoiTiem.DocDSGoiTiem();
            lstDSGoiTiem.ValueMember = "MaGT";
            lstDSGoiTiem.DisplayMember = "TenGT";
            XemTTGoiTiem();
            ////
            data.Clear();
            data.Columns.Add("STT");
            data.Columns.Add("GoiVacXin");
            data.Columns.Add("TenGoi");
            data.Columns.Add("SoLuong");
            data.Columns.Add("DonGia");

            data.PrimaryKey = new DataColumn[] { data.Columns["GoiVacXin"] };
        }
        private void lstDSVacXin_SelectedIndexChanged(object sender, EventArgs e)
        {
            XemTTGoiTiem();
        }
        
        private void XemTTGoiTiem()
        {
            string MaGT = lstDSGoiTiem.SelectedValue.ToString();
            GoiTiem a = new GoiTiem(MaGT, 0);
            gv_ChiTietGoi.DataSource = a.DocTTGoiTiem();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int len = data.Rows.Count;
            if ( len<1)
            {
                MessageBox.Show("Không có gì để xóa");
                return;
            }
            
            string MaGT = gv_DSChon.CurrentRow.Cells[1].Value.ToString();
            DataRow row = data.Rows.Find(MaGT);
            int sl = Int32.Parse(row["SoLuong"].ToString()) - 1;
            if (sl > 0)
            {
                row["SoLuong"] = sl;
            }
            else
            {
                row.Delete();
                UpdateDSChon();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRowView obj = (DataRowView)lstDSGoiTiem.SelectedItem;

            string MaGT = obj["MaGT"].ToString();
            string TenGT = obj["TenGT"].ToString();
            string DonGia = obj["DonGia"].ToString();
            

            DataRow row = data.Rows.Find(MaGT);

            if (row==null)
            {
                object[] o = { data.Rows.Count + 1, MaGT, TenGT, 1, DonGia };
                GoiTiem a = new GoiTiem(MaGT, 1);
                if (!a.KiemtraTTGoiTiem())
                {
                    MessageBox.Show("Chọn gói khác nhé!");
                    return;
                }
                data.Rows.Add(o);
            }
            else
            {
                int SoLuong = Int32.Parse(row["SoLuong"].ToString()) + 1;

                GoiTiem a = new GoiTiem(MaGT, SoLuong);
                if (!a.KiemtraTTGoiTiem())
                {
                    MessageBox.Show("Chọn gói khác nhé!");
                    return;
                }

                row["SoLuong"] = Int32.Parse(row["SoLuong"].ToString())+1;

            }
            gv_DSChon.DataSource = data;
        }
        private void UpdateDSChon()
        {
            int count = 0;
            foreach (DataRow row in data.Rows)
            {
                row["STT"] =  count + 1;
                count++;
            }
            gv_DSChon.DataSource = data;
        }


        private void bt_laphoadon_Click(object sender, EventArgs e)
        {
            int len = data.Rows.Count;
            if (len < 1)
            {
                MessageBox.Show("Không có gì để xóa");
                return;
            }

            frmTT3_LapHoaDon thanhtoan = new frmTT3_LapHoaDon();
            thanhtoan.LoadData(data,"MH");


            //this.Visible = false;
            thanhtoan.Show();
            //this.Visible = true;
        }

        private void bt_DangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
