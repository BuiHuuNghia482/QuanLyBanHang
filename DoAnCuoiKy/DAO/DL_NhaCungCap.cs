using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_NhaCungCap
    {
        public static DataTable DuLieuNhaCungCap()
        {
            return DL_LayDuLieu.LayDuLieuTuBang("NHACUNGCAP");
        }
        //them nha cung cap
        public static bool NhaCungCapThem(string ma, string ten, string diachi, string dienthoai, string maKhuVuc)
        {
            string sql = string.Format("Insert Into NHACUNGCAP(MaNhaCungCap,TenNhaCungCap,DiaChi,DienThoai,MaKhuVuc) Values('{0}','{1}','{2}','{3}','{4}')", ma, ten, diachi, dienthoai, maKhuVuc);
            return DL_LayDuLieu.InsertSQL(sql);
        }
        //sua nha cung cap
        public static bool NhaCungCapSua(string ma, string ten, string diachi, string dienthoai, string makhuvuc)
        {
            string sql = string.Format("Update NHACUNGCAP set TenNhaCungCap='{0}',DiaChi='{1}',DienThoai='{2}',MaKhuVuc='{3}' where MaNhaCungCap='{4}' ", ten, diachi, dienthoai, makhuvuc, ma);
            return DL_LayDuLieu.UpdateSQL(sql);
        }
        // xoa nha cung cap
        public static bool NhaCungCapXoa(string ma)
        {
            string sql = string.Format("Delete From NHACUNGCAP Where MaNhaCungCap='{0}'", ma);
            return DL_LayDuLieu.DeleteSQL(sql);
        }


    }
}
