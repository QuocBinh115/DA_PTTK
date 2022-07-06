using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLiTiemChung
{
    public partial class frm_DatMuaVaccine : Form

    {
        //danh sách đã thêm và số lượng
        Dictionary<string, int> list_VX_selected = new Dictionary<string, int>();
        //danh sách chưa thêm
        Dictionary<string,string> list_VX_unselected = new Dictionary<string, string>();
        
        public frm_DatMuaVaccine()
        {
            InitializeComponent();
        }

        private void frm_DatMuaVaccine_Load(object sender, EventArgs e)
        {
            //thêm header
            ChonVaccine_table.ColumnCount = 4;
            ChonVaccine_table.ColumnHeadersVisible = true;
            ChonVaccine_table.Columns[0].Name = "Số thứ tự";
            ChonVaccine_table.Columns[1].Name = "Tên Vaccine";
            ChonVaccine_table.Columns[2].Name = "Số lượng";
            ChonVaccine_table.Columns[3].Name = "Đơn giá";

            //thêm cột xóa btn
            var revokeButton = new DataGridViewButtonColumn();
            revokeButton.Name = "dataGridViewDel_CT_DH_Button";
            revokeButton.HeaderText = "Xóa chi tiết hóa đặt hàng";
            revokeButton.Text = "Xóa";
            revokeButton.UseColumnTextForButtonValue = true;
            this.ChonVaccine_table.Columns.Add(revokeButton);
            ChonVaccine_table.CellClick -= DataGridViewUser_RevokeCellClick;
            ChonVaccine_table.CellClick += DataGridViewUser_RevokeCellClick;

            Chon_SL_input.Minimum = 1;

            reloadload_combobox_chonVaccine();
        }

        private void reloadload_combobox_chonVaccine()
            //tải lại combobox mỗi khi thay đổi
        {

            list_VX_unselected = Vaccine_19120640.Lay_thong_tin_Vaccine();
            ChonVaccine_cbb.Items.Clear();
            //đọc từ dữ liệu db
            foreach (KeyValuePair<string, string> vaccine in list_VX_unselected)
            {
                //nếu đã được chọn thì không cần hiển thị
                if (!list_VX_selected.ContainsKey(vaccine.Value))
                {
                    ChonVaccine_cbb.Items.Add(vaccine.Key);
                }
            }

            //clear selected item
            ChonVaccine_cbb.SelectedItem = null;
            ChonVaccine_cbb.SelectedIndex = -1;
            ChonVaccine_cbb.Text = "";

            //clear Chon_SL_input
            Chon_SL_input.Value = 1;

        }

        private void reload_STT_gridView()
        {
            foreach (DataGridViewRow row in ChonVaccine_table.Rows)
            {
                if (row.Cells["Số thứ tự"].Value != null)
                {

                row.Cells["Số thứ tự"].Value = row.Index + 1;
                }
            }
        }

        private void ThemVaccine_btn_Click(object sender, EventArgs e)

        {
            //check if no item is selected
            if (ChonVaccine_cbb.SelectedIndex == -1) return;

            //add selected item to gridview
            int index = ChonVaccine_table.Rows.Add();
            string tenVX = ChonVaccine_cbb.SelectedItem.ToString();
            ChonVaccine_table.Rows[index].Cells["Số thứ tự"].Value = index+1;
            ChonVaccine_table.Rows[index].Cells["Tên Vaccine"].Value = tenVX;
            ChonVaccine_table.Rows[index].Cells["Số lượng"].Value = Chon_SL_input.Value;
            ChonVaccine_table.Rows[index].Cells["Đơn giá"].Value = Vaccine_DB_19120640.LayGiaVaccine(list_VX_unselected[tenVX]).ToString("#,0.###") + " vnđ";

            //add item selecte to list
            list_VX_selected.Add(list_VX_unselected[tenVX], decimal.ToInt32(Chon_SL_input.Value));
            reloadload_combobox_chonVaccine();

        }

        private void DataGridViewUser_RevokeCellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == ChonVaccine_table.NewRowIndex || e.RowIndex < 0) { return; };

            string tenVX = ChonVaccine_table.Rows[e.RowIndex].Cells["Tên Vaccine"].Value.ToString();

            //Check if click is on specific column 
            if (e.ColumnIndex == ChonVaccine_table.Columns["dataGridViewDel_CT_DH_Button"].Index)
            {
                list_VX_selected.Remove(list_VX_unselected[tenVX]);
                ChonVaccine_table.Rows.RemoveAt(e.RowIndex);
                reloadload_combobox_chonVaccine();
                reload_STT_gridView();
            }
        }

        private void ThemMoiVaccine_btn_Click(object sender, EventArgs e)
        {
            frm_ThemMoiVaccine frm_ThemMoiVaccine = new frm_ThemMoiVaccine();
            frm_ThemMoiVaccine.Show();
            frm_ThemMoiVaccine.Closed += (s, args) => {
                this.Show();
                reloadload_combobox_chonVaccine();
            };
            this.Hide();
        }

        private void DatMuaVaccine_btn_Click(object sender, EventArgs e)
        {
            if(list_VX_selected.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vaccine muốn đặt!", "Thông báo");
                return;
            }
            DonDatHang newdonDatHang = new DonDatHang();
            //HoaDon_1912640 newHoaDon = new HoaDon_1912640();
            //newHoaDon.TaoHoaDonMoi();
            //newdonDatHang.TaoDonHangMoi(newHoaDon.MaHD);
            ctDonDatHang newCT;
            foreach (KeyValuePair<string, int> list_ctDonDH in list_VX_selected)
            {
                //newCT.MaDonDH = newdonDatHang.MaDonDH;
                newCT = new ctDonDatHang();
                newCT.MaVX = list_ctDonDH.Key;
                newCT.Soluong = list_ctDonDH.Value;
                newCT.TinhThanhTien();
                newdonDatHang.list_ctDatHang.Add(newCT);
            }
            newdonDatHang.TinhTongTien();

            HoaDon_1912640.MaKH = User.current.MaKH;
            HoaDon_1912640.LoaiHD = "DH";
            HoaDon_1912640.donDatHang = new DonDatHang();
            HoaDon_1912640.donDatHang = newdonDatHang;
            HoaDon_1912640.TongTien = newdonDatHang.TongTien;
            HoaDon_1912640.TaoHoaDonMoi_Cho_DonHang();
            

        }
    }
}
