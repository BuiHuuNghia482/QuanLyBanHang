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
    public class XL_NhanVien
    {
        public static DataTable LayDuLieuNhanVien()
        {
            return DL_NhanVien.DuLieuNhanVien();
        }
        //chuyen bang thanh class
        public static List<NhanVien> ChuyenDoiDTONhanVien(DataTable bang)
        {
            List<NhanVien> kq = new List<NhanVien>();
            foreach (DataRow dong in bang.Rows)
            {
                NhanVien a = new NhanVien();
                a.MaNV = dong["MaNV"].ToString();
                a.HoTen = dong["HoTen"].ToString();
                a.GioiTinh = dong["GioiTinh"].ToString();
                a.NgaySinh = dong["NgaySinh"].ToString();
                a.DienThoai = dong["DienThoai"].ToString();
                a.MaBP = dong["MaBP"].ToString();
                kq.Add(a);
            }
            return kq;
        }
        //them 
        public static bool ThemNhanVien(string ma, string ten,string  phai,string  ngaysinh,string dienthoai,string mabophan)
        {
            return DL_NhanVien.NhanVienThem(ma, ten, phai, ngaysinh, dienthoai, mabophan);
        }
        //sua
        public static bool SuaNhanVien(string ma, string ten, string phai, string ngaysinh, string dienthoai, string mabophan)
        {
            return DL_NhanVien.NhanVienSua(ma, ten, phai, ngaysinh, dienthoai, mabophan);
        }
        //xoa
        public static bool XoaKhachHang(string ma)
        {
            return DL_NhanVien.NhanVienXoa(ma);
        }

    }
}
