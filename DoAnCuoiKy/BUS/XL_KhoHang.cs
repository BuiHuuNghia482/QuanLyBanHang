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
    public class XL_KhoHang
    {
        //lay data kho
        public static DataTable LayDuLieuKhoHang()
        {
            return DL_KhoHang.DuLieuKhoHang();
        }
        //chuyen bang thanh vai tro
        public static List<KhoHang> ChuyenDoiDTOKhoHang(DataTable bang)
        {
            List<KhoHang> kq = new List<KhoHang>();
            foreach (DataRow dong in bang.Rows)
            {
                KhoHang a = new KhoHang();
                a.MaKho = dong["MaKho"].ToString();
                a.TenKho = dong["TenKho"].ToString();
                a.MaKhuVuc = dong["MaKhuVuc"].ToString();
                kq.Add(a);
            }
            return kq;
        }
        //them kho hang
        public static bool ThemKhoHang(string ma, string ten,string makhuvuc)
        {
            return DL_KhoHang.KhachHangThem(ma, ten, makhuvuc);
        }
        //sua kho hang
        public static bool SuaKhoHang(string ma, string ten,string makhuvuc)
        {
            return DL_KhoHang.KhoHangSua(ma, ten, makhuvuc);
        }
        //xoa kho hang
        public static bool XoaKhoHang(string ma)
        {
            return DL_KhoHang.KhoHangXoa(ma);
        }

    }
}
