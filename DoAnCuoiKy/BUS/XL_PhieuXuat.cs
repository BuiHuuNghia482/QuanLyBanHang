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
    public class XL_PhieuXuat
    {
        public static DataTable LayDuLieuPhieuXuat()
        {
            return DL_PhieuXuat.DuLieuPhieuXuat();
        }
        public static List<PhieuXuat> ChuyenDoiDTOPhieuXuat(DataTable bang)
        {
            List<PhieuXuat> kq = new List<PhieuXuat>();
            foreach (DataRow dong in bang.Rows)
            {
                PhieuXuat a = new PhieuXuat();
                a.MaPhieuXuat = dong["MaPhieuXuat"].ToString();
                kq.Add(a);
            }
            return kq;
        }
        //them 
        public static bool ThemPhieuXuat(string maphieuxuat,string ngayxuat,string manhanvien,string khachang,string hinhthucthanhtoan,string dieukhoan,double TongTien,string hanthanhtoan,string tientratruoc,string ngaygiao)
        {
            return DL_PhieuXuat.PhieuXuatThem(maphieuxuat, ngayxuat, manhanvien, khachang, hinhthucthanhtoan, dieukhoan, TongTien, hanthanhtoan, tientratruoc, ngaygiao);
        }

    }
}
