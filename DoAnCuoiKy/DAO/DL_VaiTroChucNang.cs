using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_VaiTroChucNang
    {
        //lay du lieu bang VAITROCHUCNANG
        public static DataTable LayThongTinVaiTroChucNang(string MaVaiTro)
        {
            string sql = string.Format("Select vt.*,cn.TenTrongHeThong from VAITROCHUCNANG vt, CHUCNANG cn Where MaVaiTro='{0}' and vt.MaChucNang=cn.id", MaVaiTro);
            return DL_LayDuLieu.LayDuLieuSQL(sql);
        }


    }
}
