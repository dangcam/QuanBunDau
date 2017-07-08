using QuanBunDauTienHai.VO;
using System.Data;
using System.Data.SqlClient;

namespace QuanBunDauTienHai.DAO
{
    class NhanVienDAO
    {
        Connection db = null;
        public NhanVienDAO()
        {
            db = new Connection();
        }
        public DataTable DSNhanVien()
        {
            return db.ExcuteQuery("Select  * From NhanVien",
                CommandType.Text, null);
        }
        public DataTable DangNhap(string TenDN, string MatKhau)
        {
            return db.ExcuteQuery("Select  * From NhanVien Where TenDN=N'"+TenDN+"' AND MatKhau='"+MatKhau+"'",
                CommandType.Text, null);
        }
        public bool ThemNhanVien(ref string err, NhanVienVO nhanvien)
        {
            return db.MyExecuteNonQuery("SpThemNhanVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenDN", nhanvien.TenDN),
                new SqlParameter("@MatKhau", nhanvien.MatKhau),
                new SqlParameter("@TenNV", nhanvien.TenNV),
                new SqlParameter("@SDT", nhanvien.SDT));
        }
        public bool SuaNhanVien(ref string err, NhanVienVO nhanvien)
        {
            return db.MyExecuteNonQuery("SpSuaNhanVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenDN", nhanvien.TenDN),
                new SqlParameter("@MatKhau", nhanvien.MatKhau),
                new SqlParameter("@TenNV", nhanvien.TenNV),
                new SqlParameter("@SDT", nhanvien.SDT));
        }
        public bool XoaNhanVien(ref string err, string TenDN)
        {
            return db.MyExecuteNonQuery("SpXoaNhanVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenDN", TenDN));
        }
        public bool SuaMatKhau(ref string err, string TenDN,string MatKhau)
        {
            return db.MyExecuteNonQuery("SpSuaMatKhau",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@TenDN", TenDN),
                new SqlParameter("@MatKhau", MatKhau));
        }
    }
}
