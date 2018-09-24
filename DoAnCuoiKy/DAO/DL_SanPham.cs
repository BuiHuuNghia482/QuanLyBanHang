using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_SanPham
    {
        public static DataTable DuLieuSanPham()
        {
            string sql = string.Format("Select DISTINCT(MaSP),TenSP,MaDonViTinh,XuatXu,GiaLucNhap,HinhAnh From SANPHAM");
            return DL_LayDuLieu.LayDuLieuSQL(sql);
        }
        public static DataTable DuLieuSanPhamTheoSP(string masp)
        {
            string sql = string.Format("Select MaKho From SANPHAM Where MaSP='{0}'", masp);
            return DL_LayDuLieu.LayDuLieuSQL(sql);
        }

        public static bool SanPhamCapNhat(string kho, string MaSP, int SoLuongMua)
        {
            string sql = string.Format("Update SANPHAM set SoLuongTon=SoLuongTon-{0} Where MaKho='{1}' and MaSP='{2}'", SoLuongMua, kho, MaSP);
            return DL_LayDuLieu.UpdateSQL(sql);
        }

    }
}
