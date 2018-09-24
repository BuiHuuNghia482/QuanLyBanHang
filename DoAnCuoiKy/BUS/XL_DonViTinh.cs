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
    public class XL_DonViTinh
    {
        public static DataTable LayDuLieuDonViTinh()
        {
            return DL_DonViTinh.DuLieuDonViTinh();
        }
        //chuyen bang thanh list
        public static List<DonViTinh> ChuyenDoiDTODonViTinh(DataTable bang)
        {
            List<DonViTinh> kq = new List<DonViTinh>();
            foreach (DataRow dong in bang.Rows)
            {
                DonViTinh a = new DonViTinh();
                a.MaDonViTinh = dong["MaDonViTinh"].ToString();
                a.TenDonViTinh = dong["TenDonViTinh"].ToString();
                kq.Add(a);
            }
            return kq;
        }
        //them
        public static bool ThemDonViTinh(string ma,string ten)
        {
            return DL_DonViTinh.DonViTinhThem(ma, ten);
        }
        //sua
        public static bool SuaDonViTinh(string ma,string ten)
        {
            return DL_DonViTinh.DonViTinhSua(ma, ten);
        }
        //xoa
        public static bool XoaDonViTinh(string ma)
        {
            return DL_DonViTinh.DonViTinhXoa(ma);
        }
    }
}
