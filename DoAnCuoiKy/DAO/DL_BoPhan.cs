using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_BoPhan
    {
        // lay du lieu tu ban khu vuc
        public static DataTable DuLieuBoPhan()
        {
            return DL_LayDuLieu.LayDuLieuTuBang("BOPHAN");
        }
        //them
        public static bool BoPhanThem(string maBoPhan, string TenBoPhan)
        {
            string sql = string.Format("Insert into BOPHAN(MABP,TENBP) Values('{0}','{1}')", maBoPhan, TenBoPhan);
            return DL_LayDuLieu.InsertSQL(sql);
        }
        //sua
        public static bool BoPhanSua(string maBoPhan, string TenBoPhan)
        {
            string sql = string.Format("Update BOPHAN set TenBP='{0}' where MaBP='{1}'", TenBoPhan, maBoPhan);
            return DL_LayDuLieu.UpdateSQL(sql);
        }
        //xoa
        public static bool BoPhanXoa(string maBoPhan)
        {
            string sql = string.Format("Delete From BOPHAN where MaBP='{0}'", maBoPhan);
            return DL_LayDuLieu.DeleteSQL(sql);
        }

    }
}
