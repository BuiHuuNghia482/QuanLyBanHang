using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_KhachHang
    {
        public static DataTable DuLieuKhachHang()
        {
            return DL_LayDuLieu.LayDuLieuTuBang("KHACHHANG");
        }
        //them khach hang
        public static bool KhachHangThem(string maKhachHang, string TenKhachHang, string DiaChi, string dienthoai, string makhuvuc)
        {
            string sql = string.Format("Insert Into KHACHHANG(MaKhachHang,TenKhachHang,DiaChi,DienThoai,MaKhuVuc) Values('{0}','{1}','{2}','{3}','{4}')", maKhachHang, TenKhachHang, DiaChi, dienthoai, makhuvuc);
            return DL_LayDuLieu.InsertSQL(sql);
        }
        //sua khach hang
        public static bool KhachHangSua(string makhachhang, string ten, string diachi, string dienthoai, string makhuvuc)
        {
            string sql = string.Format("Update KHACHHANG set TenKhachHang='{0}',DiaChi='{1}',DienThoai'{2}',MaKhuVuc='{3}' where MaKhachHang='{4}'", ten, diachi, dienthoai, makhuvuc, makhachhang);
            return DL_LayDuLieu.UpdateSQL(sql);
        }
        //xoa khach hang
        public static bool KhachHangXoa(string makhachhang)
        {
            string sql = string.Format("Delete From KHACHHANG Where MaKhachHang='{0}'", makhachhang);
            return DL_LayDuLieu.DeleteSQL(sql);
        }
    }
}
