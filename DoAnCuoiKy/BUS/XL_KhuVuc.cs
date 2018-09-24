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
    public class XL_KhuVuc
    {
        public static  DataTable LayDuLieuKhuVuc()
        {
            return DL_KhuVuc.DuLieuKhuVuc();
        }
        //chuyen bang thanh list
        public static List<KhuVuc> ChuyenDoiDTOKhuVuc(DataTable bang)
        {
            List<KhuVuc> kq = new List<KhuVuc>();
            foreach (DataRow dong in bang.Rows)
            {
                KhuVuc a = new KhuVuc();
                a.MaKhuVuc = dong["MaKhuVuc"].ToString();
                a.TenKhuVuc = dong["TenKhuVuc"].ToString();
                kq.Add(a);
            }
            return kq;
        }
        //them khu vuc
        public static bool ThemKhuVuc(string maKhuVuc,string tenKhuVuc)
        {
            return DL_KhuVuc.KhuVucMoi(maKhuVuc, tenKhuVuc);
        }
        //sua khu vuc
        public static bool SuaKhuVuc(string maKhuVuc, string tenKhuVuc)
        {
            return DL_KhuVuc.KhuVucSua(maKhuVuc, tenKhuVuc);
        }
        //xoa khu vuc
        public static bool XoaKhuVuc(string maKhuVuc)
        {
            return DL_KhuVuc.KhuVucXoa(maKhuVuc);
        }

    }
}
