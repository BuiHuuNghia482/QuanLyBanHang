using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_VaiTro
    {
        //lay du lieu bang vai tro
        public static DataTable LayThongTinVaiTro(string MaVaiTro)
        {
            string sql = string.Format("Select * from VAITRO Where MaVaiTro='{0}'", MaVaiTro);
            return DL_LayDuLieu.LayDuLieuSQL(sql);
        }
    }
}
