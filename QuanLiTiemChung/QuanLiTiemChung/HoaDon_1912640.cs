using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiTiemChung
{
    class HoaDon_1912640
    {
        public static string MaHD;
        public static string LoaiHD;
        public static string MaKH;
        public static DateTime NgayHen;
        public static string NguoiLap;
        public static int TongTien;

        public static DonDatHang donDatHang;//chứa thông tin đơn hàng và danh sách chi tiết đơn hàng
        
        
        //sau khi thay đổi thông tin về người lập, ngày hẹn thì sử dụng phương thức này
        //để TỰ ĐỘNNG THÊM
        //hóa đơn, đơn đặt hàng, chi tiết đơn đặt tương ứng
        //TRẢ VỀ: mã hóa đơn đã tạo tương ứng
        public static string TaoHoaDonMoi_Cho_DonHang()
        {
            MaHD = HoaDon_DB_19120640.TaoHoaDon(LoaiHD, MaKH, NgayHen, NguoiLap);
            donDatHang.TaoDonHangMoi(MaHD);
            return MaHD;
        }


        //Hàm này dùng để lấy data table từ đơn hàng
        public static DataTable LayDatatable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Tên Vaccine");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Đơn Giá");
            int count = 0;
            foreach (var ctdh in donDatHang.list_ctDatHang)
            {
                DataRow dRow = dt.NewRow();
                count += 1;
                dRow[0] = count;
                dRow[1] = Vaccine_DB_19120640.LayTenVaccine(ctdh.MaVX);
                dRow[2] = ctdh.Soluong;
                dRow[3] = Vaccine_DB_19120640.LayGiaVaccine(ctdh.MaVX);
                dt.Rows.Add(dRow);
            }
            return dt;
            
        }
    }
}
