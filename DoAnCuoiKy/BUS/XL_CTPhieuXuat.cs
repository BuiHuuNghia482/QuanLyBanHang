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
    public class XL_CTPhieuXuat
    {
        public static DataTable LayCTPhieuXuat()
        {
            return DL_CTPhieuXuat.DuLieuCTPhieuXuat();
        }
        public static List<CTPhieuXuat> ChuyenDoiDTOCTPhieuXuat(DataTable bang)
        {
            List<CTPhieuXuat> kq = new List<CTPhieuXuat>();
            foreach (DataRow dong in bang.Rows)
            {
                CTPhieuXuat a = new CTPhieuXuat();
                a.MaChiTietXuat = dong["MaChiTietXuat"].ToString();
                a.MaPhieuXuat = dong["MaPhieuXuat"].ToString();
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
        public static bool ThemCTPhieuXuat(string MaChiTietXuat, string MaPhieuXuat, string MaSP, string MaKho, float DonGiaSP, double ThanhTien, float Thue, int SoLuongMua)
        {
            return DL_CTPhieuXuat.CTPhieuXuatThem(MaChiTietXuat, MaPhieuXuat, MaSP, MaKho, DonGiaSP, ThanhTien, Thue, SoLuongMua);
        }

    }
}
