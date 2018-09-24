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
    public class XL_VaiTro
    {
        //kiemtra vaitro
        public static DataTable KiemTraVaiTro(string MaVaiTro)
        {
            return DL_VaiTro.LayThongTinVaiTro(MaVaiTro);
        }
        //chuyen bang thanh vai tro
        public static VaiTro ChuyenDoiDTOVaiTro(DataTable bang)
        {
            VaiTro kq = new VaiTro();
            foreach (DataRow dong in bang.Rows)
            {
                kq.MaVaiTro = dong["MaVaiTro"].ToString();
                kq.TenVaiTro = dong["TenVaiTro"].ToString();
            }
            return kq;
        }

    }
}
