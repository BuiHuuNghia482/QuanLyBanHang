using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_NhanVien
    {
        public static DataTable DuLieuNhanVien()
        {
            return DL_LayDuLieu.LayDuLieuTuBang("NHANVIEN");
        }
        //them 
        public static bool NhanVienThem(string ma, string ten, string phai, string ngaysinh, string dienthoai, string mabophan)
        {
            string sql = string.Format("Insert into NHANVIEN(MaNV,HoTen,GioiTinh,NgaySinh,DienThoai,MaBP) Values('{0}','{1}','{2}','{3}','{4}','{5}')", ma, ten, phai, ngaysinh, dienthoai, mabophan);
            return DL_LayDuLieu.InsertSQL(sql);
        }
        //sua
        public static bool NhanVienSua(string ma, string ten, string phai, string ngaysinh, string dienthoai, string mabophan)
        {
            string sql = string.Format("Update NHANVIEN set HoTen='{0}',GioiTinh='{1}',NgaySinh='{2}',DienThoai='{3}',MaBP='{4}' Where MaNV='{5}'", ten, phai, ngaysinh, dienthoai, mabophan, ma);
            return DL_LayDuLieu.UpdateSQL(sql);
        }
        //xoa
        public static bool NhanVienXoa(string ma)
        {
            string sql = string.Format("Delete From NHANVIEN Where MaNV='{0}'", ma);
            return DL_LayDuLieu.DeleteSQL(sql);
        }

    }
}
