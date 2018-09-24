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
    public class XL_VaiTroChucNang
    {
        //kiem tra ma vai tro chuc nang
        public static DataTable KiemTraVaiTroChucNang(string MaVaiTro)
        {
            return DL_VaiTroChucNang.LayThongTinVaiTroChucNang(MaVaiTro);
        }
        //chuyen bang qua thanh list vai tro chuc nang
        public static List<VaiTroChucNang> ChuyenDoiDTOVaiTroChucNang(DataTable bang)
        {
            List<VaiTroChucNang> kq = new List<VaiTroChucNang>();
            foreach (DataRow dong in bang.Rows)
            {
                VaiTroChucNang dulieu = new VaiTroChucNang();
                dulieu.id = dong["id"].ToString();
                dulieu.MaVaiTro = dong["MaVaiTro"].ToString();
                dulieu.MaChucNang = dong["MaChucNang"].ToString();
                dulieu.TruyXuat = bool.Parse(dong["TruyXuat"].ToString());
                dulieu.Them = bool.Parse(dong["Them"].ToString());
                dulieu.Xoa = bool.Parse(dong["Xoa"].ToString());
                dulieu.Sua = bool.Parse(dong["Sua"].ToString());
                dulieu.TenTrongHeThong = dong["TenTrongHeThong"].ToString();
                kq.Add(dulieu);
            }
            return kq;
        }


    }
}
