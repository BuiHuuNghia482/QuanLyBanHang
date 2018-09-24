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
    public class XL_NhaCungCap
    {
        public static DataTable LayDuLieuNhaCungCap()
        {
            return DL_NhaCungCap.DuLieuNhaCungCap();
        }
        //chuyen bang thanh class
        public static List<NhaCungCap> ChuyenDoiDTONhaCungCap(DataTable bang)
        {
            List<NhaCungCap> kq = new List<NhaCungCap>();
            foreach (DataRow dong in bang.Rows)
            {
                NhaCungCap a = new NhaCungCap();
                a.MaNhaCungCap = dong["MaNhaCungCap"].ToString();
                a.TenNhaCungCap = dong["TenNhaCungCap"].ToString();
                a.DiaChi = dong["DiaChi"].ToString();
                a.DienThoai = dong["DienThoai"].ToString();
                a.MaKhuVuc = dong["MaKhuVuc"].ToString();
                kq.Add(a);
            }
            return kq;
        }
        //them  nha cung cap
        public static bool ThemNhaCungCap(string ma,string ten,string diachi,string dienthoai,string maKhuVuc)
        {
            return DL_NhaCungCap.NhaCungCapThem(ma, ten, diachi, dienthoai, maKhuVuc);
        }
        //sua nha cung cap
        public static bool SuaNhaCungCap(string ma, string ten, string diachi, string dienthoai,string makhuvuc)
        {
            return DL_NhaCungCap.NhaCungCapSua(ma, ten, diachi, dienthoai, makhuvuc);
        }
        //xoa nha cung cap
        public static bool XoaNhaCungCap(string ma)
        {
            return DL_NhaCungCap.NhaCungCapXoa(ma);
        }



    }
}
