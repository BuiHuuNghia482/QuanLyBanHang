using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_KhoHang
    {
        //lay du lieu tu kho
        public static DataTable DuLieuKhoHang()
        {
            return DL_LayDuLieu.LayDuLieuTuBang("KHO");
        }
        //them kho hang
        public static bool KhachHangThem(string ma, string ten, string makhuvuc)
        {
            string sql = string.Format("Insert into KHO(MaKho,TenKho,MaKhuVuc) Values('{0}','{1}','{2}')", ma, ten, makhuvuc);
            return DL_LayDuLieu.InsertSQL(sql);
        }
        //sua kho hang
        public static bool KhoHangSua(string ma, string ten, string makhuvuc)
        {
            string sql = string.Format("Update KHO Set TenKho='{0}',MaKhuVuc='{1}' Where MaKho='{2}'", ten, makhuvuc, ma);
            return DL_LayDuLieu.UpdateSQL(sql);
        }
        //xoa kho hang
        public static bool KhoHangXoa(string ma)
        {
            string sql = string.Format("Delete From KHO Where MaKho='{0}'", ma);
            return DL_LayDuLieu.DeleteSQL(sql);
        }

    }
}
