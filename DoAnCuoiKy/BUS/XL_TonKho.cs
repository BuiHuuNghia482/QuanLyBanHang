using DoAnCuoiKy.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.BUS
{
    public class XL_TonKho
    {
        //nhieu bang
        public static DataTable LayDuLieuTonKho()
        {
            return DL_TonKho.DuLieuTonKho();
        }
    }
}
