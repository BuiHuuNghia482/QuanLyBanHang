using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_PhieuXuat
    {
        public static DataTable DuLieuPhieuXuat()
        {
            return DL_LayDuLieu.LayDuLieuTuBang("PHIEUXUAT");
        }
        //them
        public static bool PhieuXuatThem(string maphieuxuat, string ngayxuat, string manhanvien, string khachang, string hinhthucthanhtoan, string dieukhoan, double TongTien, string hanthanhtoan, string tientratruoc, string ngaygiao)
        {
            string sql = string.Format("Insert Into PHIEUXUAT(MaPhieuXuat,NgayXuat,MaNV,MaKhachHang,MaHinhThucThanhToan,MaDKThanhToan,TongTienThanhToan,HanThanhToan,TienTraTruoc,NgayGiao) Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", maphieuxuat, ngayxuat, manhanvien, khachang, hinhthucthanhtoan, dieukhoan, TongTien, hanthanhtoan, tientratruoc, ngaygiao);
            return DL_LayDuLieu.InsertSQL(sql);
        }

    }
}
