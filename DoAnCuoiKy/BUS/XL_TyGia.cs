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
    public class XL_TyGia
    {
        public static DataTable LayDuLieuTyGia()
        {
            return DL_TyGia.DuLieuTyGia();
        }
        //chuyen bang thanh list
        public static List<TyGia> ChuyenDoiDTOTyGia(DataTable bang)
        {
            List<TyGia> kq = new List<TyGia>();
            foreach (DataRow dong in bang.Rows)
            {
                TyGia a = new TyGia();
                a.MaTyGia = dong["MaTyGia"].ToString();
                a.TenTyGia = dong["TenTyGia"].ToString();
                a.QuyDoiTienViet = dong["QuyDoiTienViet"].ToString();
                kq.Add(a);
            }
            return kq;
        }
        //them
        public static bool ThemTyGia(string ma,string ten,string quydoi)
        {
            return DL_TyGia.TyGiaThem(ma, ten, quydoi);
        }
        //sua
        public static bool SuaTyGia(string ma, string ten, string quydoi)
        {
            return DL_TyGia.TyGiaSua(ma, ten, quydoi);
        }
        //Xoa
        public static bool XoaTyGia(string ma)
        {
            return DL_TyGia.TyGiaXoa(ma);
        }
    }
}
