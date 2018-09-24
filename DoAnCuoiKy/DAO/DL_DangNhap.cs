using DoAnCuoiKy.DAO;
using DoAnCuoiKy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_DangNhap
    {
        //ktra dang nhap neu co tra ve ma vai tro
        public static string DangNhap(string tk, string mk)
        {
            string sql = string.Format("Select MaVaiTro from TAIKHOAN Where TenTaiKhoan = '{0}' and MatKhau = '{1}'", tk, mk);
            return DL_LayDuLieu.ScalarKieuString(sql);
        }
        //doi mat khau
        public static bool MatKhauMoi(string tk,string mk)
        {
            string sql = string.Format("Update TAIKHOAN set MatKhau='{0}' where TenTaiKhoan='{1}'", mk, tk); 
            return DL_LayDuLieu.UpdateSQL(sql);
        }



    }
}
