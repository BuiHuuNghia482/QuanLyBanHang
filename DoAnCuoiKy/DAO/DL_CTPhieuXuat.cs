using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_CTPhieuXuat
    {
        public static DataTable DuLieuCTPhieuXuat()
        {
            return DL_LayDuLieu.LayDuLieuTuBang("CTPHIEUXUAT");
        }
        //them
        public static bool CTPhieuXuatThem(string MaChiTietXuat, string MaPhieuXuat, string MaSP, string MaKho, float DonGiaSP, double ThanhTien, float Thue, int SoLuongMua)
        {
            string sql = string.Format("Insert into CTPHIEUXUAT(MaChiTietXuat,MaPhieuXuat,MaSP,MaKho,DonGiaSP,ThanhTien,Thue,SoLuongMua) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", MaChiTietXuat, MaPhieuXuat, MaSP, MaKho, DonGiaSP, ThanhTien, Thue, SoLuongMua);
            return DL_LayDuLieu.InsertSQL(sql);
        }
    }
}
