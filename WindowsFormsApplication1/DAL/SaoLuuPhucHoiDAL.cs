using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApplication1.DAL;

namespace WindowsFormsApplication1.DAL
{
    public class SaoLuuPhucHoiDAL
    {
        //private DBConnect db1 =new DBConnect();
        public static bool saoLuu(string path)
        {
            try
            {
                string query = string.Format("backup database QLCuaHangKFC to disk = '{0}'", path);
                DBConnect db = new DBConnect();
                db.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool phucHoi(string path)
        {
            try
            {
                string ktraDB = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'QLCuaHangKFC') " +
                                    "BEGIN " +
                                    "CREATE DATABASE QLCuaHangKFC " +
                                    "END";

                DBConnect db = new DBConnect();
                db.AED(ktraDB);
                string phucHoi = string.Format(@"
                                    ALTER DATABASE QLCuaHangKFC SET SINGLE_USER WITH ROLLBACK IMMEDIATE
                                    USE master
                                    RESTORE DATABASE QLCuaHangKFC FROM DISK = '{0}' WITH REPLACE
                                    ALTER DATABASE QLCuaHangKFC SET MULTI_USER
                                    ", path);

                db.AED(phucHoi);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
