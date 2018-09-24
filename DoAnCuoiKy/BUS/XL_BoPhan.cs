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
    public class XL_BoPhan
    {
        public static DataTable LayDuLieuBoPhan()
        {
            return DL_BoPhan.DuLieuBoPhan();
        }
        //chuyen bang thanh list
        public static List<BoPhan> ChuyenDoiDTOBoPhan(DataTable bang)
        {
            List<BoPhan> kq = new List<BoPhan>();
            foreach (DataRow dong in bang.Rows)
            {
                BoPhan a = new BoPhan();
                a.MaBP = dong["MaBP"].ToString();
                a.TenBP = dong["TenBP"].ToString();
                kq.Add(a);
            }
            return kq;
        }
        //them
        public static bool ThemBoPhan(string ma,string ten)
        {
            return DL_BoPhan.BoPhanThem(ma, ten);
        }
        //sua
        public static bool SuaBoPhan(string ma, string ten)
        {
            return DL_BoPhan.BoPhanSua(ma, ten);
        }
        //xoa khu vuc
        public static bool XoaBoPhan(string maKhuVuc)
        {
            return DL_BoPhan.BoPhanXoa(maKhuVuc);
        }


    }
}
