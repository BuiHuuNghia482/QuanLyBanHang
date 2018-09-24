using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_NhomHang
    {
        public static DataTable DuLieuKhoHang()
        {
            return DL_LayDuLieu.LayDuLieuTuBang("NHOMHANG");
        }
        //them nhom hang
        public static bool NhomHangThem(string ma, string ten)
        {
            string sql = string.Format("Insert into NHOMHANG(MaNhomHang,TenNhomHang) Values('{0}','{1}')", ma, ten);
            return DL_LayDuLieu.InsertSQL(sql);
        }
        //sua nhom hang
        public static bool NhomHangSua(string ma, string ten)
        {
            string sql = string.Format("Update NHOMHANG set TenNhomHang='{0}' where MaNhomHang='{1}'", ten, ma);
            return DL_LayDuLieu.UpdateSQL(sql);
        }
        //xoa
        public static bool NhomHangXoa(string ma)
        {
            string sql = string.Format("Delete From NHOMHANG where MaNhomHang='{0}'", ma);
            return DL_LayDuLieu.DeleteSQL(sql);
        }
    }
}
