using DoAnCuoiKy.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.BUS
{
    public class XL_Backup_Restore
    {
        //backup
        public static bool SaoLuuDuLieu(string duongdan)
        {
            return DL_Backup_Restore.DuLieuSaoLuu(duongdan);
        }
        //restore
        public static bool PhucHoiDuLieu(string duongdan)
        {
            return DL_Backup_Restore.DuLieuPhucHoi(duongdan);
        }
    }
}
