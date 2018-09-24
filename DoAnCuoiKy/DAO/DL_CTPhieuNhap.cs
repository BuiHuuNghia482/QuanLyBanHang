using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_CTPhieuNhap
    {
        public static DataTable DuLieuCTPhieuNhap()
        {
            return DL_LayDuLieu.LayDuLieuTuBang("CTPHIEUNHAP");
        }
        public static DataTable DuLieuSPTheoMaSP(string maSP)
        {
            string sql = string.Format("Select sp.MaSP,sp.TenSP,sp.XuatXu,sp.MaDonViTinh,sp.GiaLucNhap,sp.HinhAnh " +
                "From SANPHAM sp Where sp.MaSP = N'{0}' ", maSP);
            return DL_LayDuLieu.LayDuLieuSQL(sql);
        }
        //them
        public static bool CTPhieuNhapThem(string MaChiTietNhap, string MaPhieuNhap, string MaSP, float DonGiaSP, float ThanhTien, float Thue, int SoLuongMua)
        {
            string sql = string.Format("Insert into CTPHIEUNHAP(MaChiTietNhap,MaPhieuNhap,MaSP,DonGiaSP,ThanhTien,Thue,SoLuongMua) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", MaChiTietNhap, MaPhieuNhap, MaSP, DonGiaSP, ThanhTien, Thue, SoLuongMua);
            return DL_LayDuLieu.InsertSQL(sql);
        }
        //capnhat sp
        public static bool SanPhamCapNhat(string makho, string MaSP, int SoLuongMua)
        {
            string sql = string.Format("Update SANPHAM set SoLuongTon=SoLuongTon+{0} Where MaSP='{1}' and MaKho='{2}'", SoLuongMua, MaSP, makho);
            return DL_LayDuLieu.UpdateSQL(sql);
        }
    }
}
