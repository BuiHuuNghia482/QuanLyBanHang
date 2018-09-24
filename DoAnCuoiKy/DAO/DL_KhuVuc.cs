using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_KhuVuc
    {
        // lay du lieu tu ban khu vuc
        public static DataTable DuLieuKhuVuc()
        {
            return DL_LayDuLieu.LayDuLieuTuBang("KHUVUC");
        }
        //them khu vuc
        public static bool KhuVucMoi(string maKhuVuc, string tenKhuVuc)
        {
            string sql = string.Format("Insert into KHUVUC(MaKhuVuc,TenKhuVuc) Values('{0}','{1}')", maKhuVuc, tenKhuVuc);
            return DL_LayDuLieu.InsertSQL(sql);
        }
        //sua khu vuc
        public static bool KhuVucSua(string maKhuVuc, string tenKhuVuc)
        {
            string sql = string.Format("Update KHUVUC set TenKhuVuc='{0}' where MaKhuVuc='{1}'", tenKhuVuc, maKhuVuc);
            return DL_LayDuLieu.UpdateSQL(sql);
        }
        //xoa khu vuc
        public static bool KhuVucXoa(string maKhuVuc)
        {
            string sql = string.Format("Delete From KHUVUC where MaKhuVuc='{0}'", maKhuVuc);
            return DL_LayDuLieu.DeleteSQL(sql);
        }

    }
}
