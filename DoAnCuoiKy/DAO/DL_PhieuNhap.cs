using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_PhieuNhap
    {
        public static DataTable DuLieuPhieuNhap()
        {
            return DL_LayDuLieu.LayDuLieuTuBang("PHIEUNHAP");
        }
        //them
        public static bool PhieuNhapThem(string maphieunhap, string ngaynhap, string manhanvien, string kho, string manhacungcap, string hinhthucthanhtoan, string dieukhoan, double tongtien, string hanthanhtoan, string tientratruoc)
        {
            string sql = string.Format("Insert Into PHIEUNHAP(MaPhieuNhap,NgayNhap,MaNV,MaKho,MaNhaCungCap,MaHinhThucThanhToan,MaDKThanhToan,TongTienThanhToan,HanThanhToan,TienTraTruoc) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", maphieunhap, ngaynhap, manhanvien, kho, manhacungcap, hinhthucthanhtoan, dieukhoan, tongtien, hanthanhtoan, tientratruoc);
            return DL_LayDuLieu.InsertSQL(sql);
        }
    }

}
