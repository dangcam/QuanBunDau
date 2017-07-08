using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBunDauTienHai.DAO
{
    class LoaiMatHangDAO
    {
        Connection db = null;
        public LoaiMatHangDAO()
        {
            db = new Connection();
        }
        public DataTable DSLoaiMatHang()
        {
            return db.ExcuteQuery("Select  * From LoaiMatHang",
                CommandType.Text, null);
        }
        public bool ThemLoaiMatHang(ref string err, string LoaiMatHang)
        {
            return db.MyExecuteNonQuery("SpThemLoaiMatHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@LoaiMatHang", LoaiMatHang));
        }
        public bool XoaLoaiMatHang(ref string err, string LoaiMatHang)
        {
            return db.MyExecuteNonQuery("SpXoaLoaiMatHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@LoaiMatHang", LoaiMatHang));
        }
    }
}
