using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_TyGia
    {
        public static DataTable DuLieuTyGia()
        {
            return DL_LayDuLieu.LayDuLieuTuBang("TYGIA");
        }
        //them
        public static bool TyGiaThem(string ma, string ten, string quydoi)
        {
            string sql = string.Format("Insert into TYGIA(MaTyGia,TenTyGia,QuyDoiTienViet) Values('{0}','{1}','{2}')", ma, ten, quydoi);
            return DL_LayDuLieu.InsertSQL(sql);
        }
        //sua
        public static bool TyGiaSua(string ma, string ten, string quydoi)
        {
            string sql = string.Format("Update TYGIA set TenTyGia='{0}',QuyDoiTienViet='{1}' Where MaTyGia='{2}'", ten, quydoi, ma);
            return DL_LayDuLieu.UpdateSQL(sql);
        }
        //xoa
        public static bool TyGiaXoa(string ma)
        {
            string sql = string.Format("Delete From TYGIA Where MaTyGia='{0}'", ma);
            return DL_LayDuLieu.DeleteSQL(sql);
        }
    }
}
