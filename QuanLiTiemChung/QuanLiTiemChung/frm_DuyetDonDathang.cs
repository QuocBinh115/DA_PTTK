using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTiemChung
{
    public partial class frm_DuyetDonDathang : Form
    {
        List<DonDatHang> list_DH;
        public frm_DuyetDonDathang()
        {
            InitializeComponent();
        }

        private void frm_DuyetDonDathang_Load(object sender, EventArgs e)
        {
            //create columns
            DuyetDH_gv.ColumnCount = 4;
            DuyetDH_gv.ColumnHeadersVisible = true;
            DuyetDH_gv.Columns[0].Name = "Số thứ tự";
            DuyetDH_gv.Columns[1].Name = "Mã đơn đặt hàng";
            DuyetDH_gv.Columns[2].Name = "Mã hóa đơn";
            DuyetDH_gv.Columns[3].Name = "Tổng tiền";

            //duyệt btn column
            var approval = new DataGridViewButtonColumn();
            approval.Name = "dataGridView_approval_Button";
            approval.HeaderText = "Duyệt đơn đặt hàng";
            approval.Text = "Duyệt";
            approval.UseColumnTextForButtonValue = true;
            this.DuyetDH_gv.Columns.Add(approval);
            DuyetDH_gv.CellClick -= DataGridViewUser_approvalCellClick;
            DuyetDH_gv.CellClick += DataGridViewUser_approvalCellClick;

            reload_DS_duyet_grid();




        }
        private void reload_DS_duyet_grid()
        {
            list_DH = DonDatHang_DB.DanhSach_ChuaDuyet();
            foreach (var dh in list_DH)
            {
                //add selected item to gridview
                int index = DuyetDH_gv.Rows.Add();

                DuyetDH_gv.Rows[index].Cells["Số thứ tự"].Value = index + 1;
                DuyetDH_gv.Rows[index].Cells["Mã đơn đặt hàng"].Value = dh.MaDonDH;
                DuyetDH_gv.Rows[index].Cells["Mã hóa đơn"].Value = dh.MaHD;
                DuyetDH_gv.Rows[index].Cells["Tổng tiền"].Value = dh.TongTien.ToString("#,0.###") + " vnđ";

            }
        }
        private void reload_STT_gridView()
        {
            foreach (DataGridViewRow row in DuyetDH_gv.Rows)
            {
                if (row.Cells["Số thứ tự"].Value != null)
                {

                    row.Cells["Số thứ tự"].Value = row.Index + 1;
                }
            }
        }
        private void DataGridViewUser_approvalCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == DuyetDH_gv.NewRowIndex || e.RowIndex < 0) { return; };

            string MaDonDH = DuyetDH_gv.Rows[e.RowIndex].Cells["Mã đơn đặt hàng"].Value.ToString();

            //Check if click is on specific column 
            if (e.ColumnIndex == DuyetDH_gv.Columns["dataGridView_approval_Button"].Index)
            {
                DonDatHang_DB.DuyetDonDH(MaDonDH);
                DuyetDH_gv.Rows.RemoveAt(e.RowIndex);
                reload_STT_gridView();
            }
        }
    }
}
