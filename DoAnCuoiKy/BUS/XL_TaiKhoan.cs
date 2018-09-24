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
    public class XL_TaiKhoan
    {
        //ktra taikhoan de thaydoimatkhau
        public static DataTable KtraTaiKhoan(string tk)
        {
            return DL_TaiKhoan.LayThongTinTaiKhoan(tk);
        }
        //chuyen bang thanh tai khoan
        public static TaiKhoan ChuyenDoiDTOTaiKhoan(DataTable bang)
        {
            TaiKhoan kq = new TaiKhoan();
            foreach (DataRow dong in bang.Rows)
            {
                kq.TenTaiKhoan = dong["TenTaiKhoan"].ToString();
                kq.MatKhau = dong["MatKhau"].ToString();
                kq.MaNV = dong["MaNV"].ToString();
                kq.MaVaiTro = dong["MaVaiTro"].ToString();
                kq.NhoTaiKhoan = bool.Parse(dong["NhoTaiKhoan"].ToString());
            }
            return kq;
        }
    }
}
