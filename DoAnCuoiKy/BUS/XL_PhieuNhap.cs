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
    public class XL_PhieuNhap
    {
        public static DataTable LayDuLieuPhieuNhap()
        {
            return DL_PhieuNhap.DuLieuPhieuNhap();
        }
        public static List<PhieuNhap> ChuyenDoiDTOPhieuNhap(DataTable bang)
        {
            List<PhieuNhap> kq = new List<PhieuNhap>();
            foreach (DataRow dong in bang.Rows)
            {
                PhieuNhap a = new PhieuNhap();
                a.MaPhieuNhap = dong["MaPhieuNhap"].ToString();
                kq.Add(a);
            }
            return kq;
        }
        //them
        public static bool ThemPhieuNhap(string maphieunhap,string ngaynhap,string manhanvien,string kho,string manhacungcap,string hinhthucthanhtoan,string dieukhoan,double tongtien,string hanthanhtoan,string tientratruoc)
        {
            return DL_PhieuNhap.PhieuNhapThem(maphieunhap, ngaynhap, manhanvien, kho, manhacungcap, hinhthucthanhtoan, dieukhoan, tongtien, hanthanhtoan, tientratruoc);
        }
    }
}
