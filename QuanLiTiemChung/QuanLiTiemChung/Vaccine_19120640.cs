using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTiemChung
{
    class Vaccine_19120640
    {
        public string MaVX;
        public string TenVX;
        public string NSX;
        public DateTime HSD;
        Vaccine_DB_19120640 vaccine_DB = new Vaccine_DB_19120640();
        public static Dictionary<string, string> Lay_thong_tin_Vaccine()
        {
            return Vaccine_DB_19120640.getAllvaccine();
        }

        public string ThemVaccinemoi()
        {
            MaVX = Vaccine_DB_19120640.ThemVaccine(TenVX, NSX, HSD);
            return MaVX;
        }
    }
}
