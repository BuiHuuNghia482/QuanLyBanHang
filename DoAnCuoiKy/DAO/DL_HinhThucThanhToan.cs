using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DAO
{
    public class DL_HinhThucThanhToan
    {
        public static DataTable DuLieuHinhThucThanhToan()
        {
            return DL_LayDuLieu.LayDuLieuTuBang("HINHTHUCTHANHTOAN");
        }
    }
}
