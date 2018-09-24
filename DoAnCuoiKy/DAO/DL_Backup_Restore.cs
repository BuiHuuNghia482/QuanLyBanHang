using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DoAnCuoiKy.DAO
{
    public class DL_Backup_Restore
    {
        //tham khao http://dungcoj.blogspot.com/2011/05/backup-va-restore-db-sql-trong-lap.html
        //backup
        public static bool DuLieuSaoLuu(string duongdan)
        {
            string sql = string.Format("BACKUP DATABASE [QLBH_CK] TO DISK='{0}'", duongdan);
            return DL_LayDuLieu.Backup(sql);
        }
        //restore
        public static bool DuLieuPhucHoi(string filename)
        {
            string sql = string.Format("DROP DATABASE QLBH_CK Use master Restore Database [QLBH_CK] from disk='{0}'", filename);
            return DL_LayDuLieu.Restore(sql);
        }

    }
}