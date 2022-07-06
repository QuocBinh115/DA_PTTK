using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTiemChung
{
    class ctHSBN
    {
        public static string[] benhs = { "Tiền sử rõ ràng phản vệ với vắc xin phòng COVID-19 lần trước",
        "Tiền sử rõ ràng bị COVID-19 trong vòng 6 tháng", "Đang mắc bệnh cấp tính",
        "Phụ nữ mang thai", "Phản vệ độ 3 trở lên với bất kì dị nguyên nào", "Đang bị suy giảm miễn dịch nặng, ung thư giai đoạn cuối","Tiền sử dị ứng với bất kì dị nguyên nào",
        "Tiền sử rối loạn đông máu/ cầm máu", "Rồi loạn tri giác, rối loạn hành vi"};
        public static bool them(string maBn, string ngayKham, string maNv, int[] sicks)
        {
            bool result= true;
            foreach(int i in sicks)
            {
                if(i != 0)
                result = result && ctHSBNDB.them(maBn, ngayKham, maNv, i, benhs[i - 1]);
            }

            return result;
        }
    }
}
