using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBunDauTienHai.DAO
{
    class BanAnDAO
    {
        Connection db = null;
        public BanAnDAO()
        {
            db = new Connection();
        }
        public DataTable DSBanAn()
        {
            return db.ExcuteQuery("Select  * From BanAn",
                CommandType.Text, null);
        }
        public DataTable DSBanAnTrong()
        {
            return db.ExcuteQuery("Select  BanAn From BanAn Where TrangThai=0",
                CommandType.Text, null);
        }
        public DataTable DSBanAnCoKhach()
        {
            return db.ExcuteQuery("Select  BanAn From BanAn Where TrangThai=1",
                CommandType.Text, null);
        }
        public bool ThemBanAn(ref string err,string BanAn, int Tang)
        {
            return db.MyExecuteNonQuery("SpThemBanAn",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@BanAn", BanAn),
                new SqlParameter("@Tang",Tang));
        }
        public bool XoaBanAn(ref string err, string BanAn)
        {
            return db.MyExecuteNonQuery("SpXoaBanAn",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@BanAn", BanAn));
        }
        public bool ChuyenBanAn(ref string err, string BanAnTrong, string BanAnCoKhach)
        {
            return db.MyExecuteNonQuery("SpChuyenBanAn",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@BanAnTrong", BanAnTrong),
                new SqlParameter("@BanAnCoKhach", BanAnCoKhach));
        }
    }
}
