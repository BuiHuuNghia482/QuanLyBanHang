using DoAnCuoiKy.DAO;
using DoAnCuoiKy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.BUS
{
    public class XL_KhachHang
    {
        public static DataTable LayDuLieuKhachHang()
        {
            return DL_KhachHang.DuLieuKhachHang();
        }
        //chuyen bang thanh class
        public static List<KhachHang> ChuyenDoiDTOKhachHang(DataTable bang)
        {
            List<KhachHang> kq = new List<KhachHang>();
            foreach (DataRow dong in bang.Rows)
            {
                KhachHang a = new KhachHang();
                a.MaKhachHang = dong["MaKhachHang"].ToString();
                a.TenKhachHang = dong["TenKhachHang"].ToString();
                a.DiaChi = dong["DiaChi"].ToString();
                a.DienThoai = dong["DienThoai"].ToString();
                a.MaKhuVuc = dong["MaKhuVuc"].ToString();
                kq.Add(a);
            }
            return kq;
        }
        //them khach hang
        public static bool ThemKhachHang(string maKhachHang,string TenKhachHang,string DiaChi,string dienthoai,string makhuvuc)
        {
            return DL_KhachHang.KhachHangThem(maKhachHang, TenKhachHang, DiaChi, dienthoai, makhuvuc);
        }
        //sua khach hang
        public static bool SuaKhachHang(string makhachhang, string ten, string diachi, string dienthoai,string makhuvuc)
        {
            return DL_KhachHang.KhachHangSua(makhachhang, ten, diachi, dienthoai, makhuvuc);
        }
        //xoa khach hang
        public static bool XoaKhachHang(string makhachhang)
        {
            return DL_KhachHang.KhachHangXoa(makhachhang);
        }

    }
}
