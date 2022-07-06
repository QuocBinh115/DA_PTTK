using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTiemChung
{
    class HoaDon_1912640
    {
        public string MaHD;
        public string LoaiHD;
        public string MaKH;
        public DateTime NgayHen;
        public string NguoiLap;
        public int TongTien;

        public DonDatHang donDatHang;//chứa thông tin đơn hàng và danh sách chi tiết đơn hàng
        
        
        //sau khi thay đổi thông tin về người lập, ngày hẹn thì sử dụng phương thức này
        //để TỰ ĐỘNNG THÊM
        //hóa đơn, đơn đặt hàng, chi tiết đơn đặt tương ứng
        //TRẢ VỀ: mã hóa đơn đã tạo tương ứng
        public string TaoHoaDonMoi_Cho_DonHang()
        {
            MaHD = HoaDon_DB_19120640.TaoHoaDon(LoaiHD, MaKH, NgayHen, "NV00000000");
            donDatHang.TaoDonHangMoi(MaHD);
            return MaHD;
        }
    }
}
