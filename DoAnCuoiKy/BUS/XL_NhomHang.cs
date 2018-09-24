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
    public class XL_NhomHang
    {
        //lay data kho
        public static DataTable LayDuLieunNhomHang()
        {
            return DL_NhomHang.DuLieuKhoHang();
        }
        //chuyen thanh list
        public static List<NhomHang> ChuyenDoiDTONhomHang(DataTable bang)
        {
            List<NhomHang> kq = new List<NhomHang>();
            foreach (DataRow dong in bang.Rows)
            {
                NhomHang a = new NhomHang();
                a.MaNhomHang = dong["MaNhomHang"].ToString();
                a.TenNhomHang = dong["TenNhomHang"].ToString();
                kq.Add(a);
            }
            return kq;
        }
        //them nhom hang
        public static bool ThemNhomHang(string ma,string ten)
        {
            return DL_NhomHang.NhomHangThem(ma, ten);
        }
        //sua nhom hang
        public static bool SuaNhomHang(string ma, string ten)
        {
            return DL_NhomHang.NhomHangSua(ma, ten);
        }
        //xoa
        public static bool XoaNhomHang(string ma)
        {
            return DL_NhomHang.NhomHangXoa(ma);
        }


    }
}
