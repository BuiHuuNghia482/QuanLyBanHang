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
    public class XL_SanPham
    {
        public static DataTable LayDuLieuSanPham()
        {
            return DL_SanPham.DuLieuSanPham();
        }
        public static DataTable LayDuLieuSanPhamTheoSP(string masp)
        {
            return DL_SanPham.DuLieuSanPhamTheoSP(masp);
        }
        public static List<SanPham> ChuyenDoiDTOSanPham(DataTable bang)
        {
            List<SanPham> kq = new List<SanPham>();
            foreach (DataRow dong in bang.Rows)
            {
                SanPham a = new SanPham();
                a.MaSP = dong["MaSP"].ToString();
                a.TenSP = dong["TenSP"].ToString();
                a.MaDonViTinh = dong["MaDonViTinh"].ToString();
                a.XuatXu = dong["XuatXu"].ToString();
                a.GiaLucNhap = double.Parse(dong["GiaLucNhap"].ToString());
                a.HinhAnh = dong["HinhAnh"].ToString();
                kq.Add(a);
            }
            return kq;
        }

        public static bool CapNhatSanPham(string kho, string MaSP,int SoLuongMua)
        {
            return DL_SanPham.SanPhamCapNhat(kho, MaSP, SoLuongMua);
        }
    }
}
