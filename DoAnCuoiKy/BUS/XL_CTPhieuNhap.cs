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
    public class XL_CTPhieuNhap
    {
        public static DataTable LayCTPhieuNhap()
        {
            return DL_CTPhieuNhap.DuLieuCTPhieuNhap();
        }
        public static DataTable LayDuLieuSPTheoMaSP(string maSP)
        {
            return DL_CTPhieuNhap.DuLieuSPTheoMaSP(maSP);
        }
        public static List<SanPham> ChuyenDoiDTOCTPhieuNhap_SP(DataTable bang)
        {
            List<SanPham> kq = new List<SanPham>();
            foreach (DataRow dong in bang.Rows)
            {
                SanPham a = new SanPham();
                a.MaSP = dong["MaSP"].ToString();
                a.TenSP = dong["TenSP"].ToString();
                a.XuatXu= dong["XuatXu"].ToString();
                a.MaDonViTinh= dong["MaDonViTinh"].ToString();
                a.GiaLucNhap = float.Parse(dong["GiaLucNhap"].ToString());
                a.HinhAnh = dong["HinhAnh"].ToString();
                kq.Add(a);
            }
            return kq;
        }
        public static List<CTPhieuNhap> ChuyenDoiDTOCTPhieuNhap(DataTable bang)
        {
            List<CTPhieuNhap> kq = new List<CTPhieuNhap>();
            foreach (DataRow dong in bang.Rows)
            {
                CTPhieuNhap a = new CTPhieuNhap();
                a.MaChiTietNhap = dong["MaChiTietNhap"].ToString();
                a.MaPhieuNhap = dong["MaPhieuNhap"].ToString();
                a.MaSP = dong["MaSP"].ToString();
                a.DonGiaSP = float.Parse(dong["DonGiaSP"].ToString());
                a.ThanhTien = float.Parse(dong["ThanhTien"].ToString());
                a.Thue = float.Parse(dong["Thue"].ToString());
                a.SoLuongMua = int.Parse(dong["SoLuongMua"].ToString());
                kq.Add(a);
            }
            return kq;
        }
        //them
        public static bool ThemCTPhieuNhap(string MaChiTietNhap, string MaPhieuNhap, string MaSP,float DonGiaSP, float ThanhTien, float Thue, int SoLuongMua)
        {
            return DL_CTPhieuNhap.CTPhieuNhapThem(MaChiTietNhap, MaPhieuNhap, MaSP, DonGiaSP, ThanhTien, Thue, SoLuongMua);
        }
        //capnhat sp
        public static bool CapNhatSanPham(string makho, string MaSP, int SoLuongMua)
        {
            return DL_CTPhieuNhap.SanPhamCapNhat(makho, MaSP, SoLuongMua);
        }

    }
}
