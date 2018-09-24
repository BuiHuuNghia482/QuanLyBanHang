using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_DonViTinh
    {
        // lay du lieu tu ban khu vuc
        public static DataTable DuLieuDonViTinh()
        {
            return DL_LayDuLieu.LayDuLieuTuBang("DONVITINH");
        }
        //them
        public static bool DonViTinhThem(string ma, string ten)
        {
            string sql = string.Format("Insert into DONVITINH(MaDonViTinh,TenDonViTinh) Values('{0}','{1}')", ma, ten);
            return DL_LayDuLieu.InsertSQL(sql);
        }
        //sua
        public static bool DonViTinhSua(string ma, string ten)
        {
            string sql = string.Format("Update DONVITINH set TenDonViTinh='{0}' Where MaDonViTinh='{1}'", ten, ma);
            return DL_LayDuLieu.UpdateSQL(sql);
        }
        //xoa
        public static bool DonViTinhXoa(string ma)
        {
            string sql = string.Format("Delete From DONVITINH Where MaDonViTinh='{0}'", ma);
            return DL_LayDuLieu.DeleteSQL(sql);
        }
    }
}
