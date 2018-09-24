using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_TonKho
    {
        public static DataTable DuLieuTonKho()
        {
            string sql= "select sp.MaSP,sp.TenSP,dv.TenDonViTinh,sp.XuatXu,sp.SoLuongTon,k.TenKho,nh.TenNhomHang" +
                " From SANPHAM sp,KHO k, NHOMHANG nh,DONVITINH dv " +
                "Where sp.MaDonViTinh = dv.MaDonViTinh and sp.MaKho = k.MaKho and sp.MaNhomHang = nh.MaNhomHang";
            return DL_LayDuLieu.LayDuLieuSQL(sql);
        }
    }
}
