using QuanBunDauTienHai.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBunDauTienHai.DAO
{
    class MatHangDAO
    {
        Connection db = null;
        public MatHangDAO()
        {
            db = new Connection();
        }
        public DataTable DSLoaiMatHang()
        {
            return db.ExcuteQuery("Select  * From LoaiMatHang",
                CommandType.Text, null);
        }
        public DataTable DSMatHang()
        {
            return db.ExcuteQuery("Select  * From MatHang",
                CommandType.Text, null);
        }
        public bool ThemMatHang(ref string err, MatHangVO mathang)
        {
            return db.MyExecuteNonQuery("SpThemMatHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenMatHang", mathang.TenMatHang),
                new SqlParameter("@LoaiMatHang", mathang.LoaiMatHang),
                new SqlParameter("@DonVi", mathang.DonVi),
                new SqlParameter("@Gia", mathang.Gia));
        }
        public bool SuaMatHang(ref string err, MatHangVO mathang)
        {
            return db.MyExecuteNonQuery("SpSuaMatHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenMatHang", mathang.TenMatHang),
                new SqlParameter("@LoaiMatHang", mathang.LoaiMatHang),
                new SqlParameter("@DonVi", mathang.DonVi),
                new SqlParameter("@Gia", mathang.Gia));
        }
        public bool XoaMatHang(ref string err, string MatHang)
        {
            return db.MyExecuteNonQuery("SpXoaMatHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenMatHang", MatHang));
        }
    }
}
