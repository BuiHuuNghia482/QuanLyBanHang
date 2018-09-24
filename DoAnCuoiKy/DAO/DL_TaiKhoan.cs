using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_TaiKhoan
    {
        //lay thong tin tai khoan
        public static DataTable LayThongTinTaiKhoan(string tk)
        {
            string sql = string.Format("Select * from TAIKHOAN Where TenTaiKhoan = '{0}'", tk);
            return DL_LayDuLieu.LayDuLieuSQL(sql);
        }


    }
}
