using DoAnCuoiKy.DAO;
using DoAnCuoiKy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DoAnCuoiKy.BUS
{
    public class XL_DangNhap
    {
        //dangnhap
        public static string KiemTraDangNhap(string tk, string mk)
        {
            if (tk == "" || mk == "")
            {
                string a = "";
                return a;
            }
            return DL_DangNhap.DangNhap(tk, mk);
        }
        //kiem tra doi mat khau
        public static bool DoiMatKhau(string tk,string mk)
        {
            return DL_DangNhap.MatKhauMoi(tk,mk);
        }


    }
}
