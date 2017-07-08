using System.Data;
using System.Data.SqlClient;

namespace QuanBunDauTienHai.DAO
{
    class ChiTietHoaDonDAO
    {
        Connection db = null;
        public ChiTietHoaDonDAO()
        {
            db = new Connection();
        }
        public DataTable HoaDon(string BanAn)
        {
            return db.ExcuteQuery("Select  * From getHoaDon(N'"+BanAn+"')",
                CommandType.Text, null);
        }
        public DataTable DSMon()
        {
            return db.ExcuteQuery("Select  * From MatHang ORDER BY LoaiMatHang ASC",
                CommandType.Text, null);
        }
        public DataTable DSChiTietHoaDon(int MaHoaDon)
        {
            return db.ExcuteQuery("Select  * From getHoaDonChiTiet('"+MaHoaDon+"')",
                CommandType.Text, null);
        }
        public bool ThemChiTietHoaDon(ref string err, int MaHoaDon, string TenMatHang, int SoLuong, int Gia)
        {
            return db.MyExecuteNonQuery("SpThemChiTietHoaDon",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHoaDon", MaHoaDon),
                new SqlParameter("@TenMatHang", TenMatHang),
                new SqlParameter("@SoLuong", SoLuong),
                new SqlParameter("@Gia", Gia));
        }
        public bool SuaSoLuongHoaDon(ref string err, int MaHoaDon, string TenMatHang, int SoLuong)
        {
            return db.MyExecuteNonQuery("SpSuaSoLuongHoaDon",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHoaDon", MaHoaDon),
                new SqlParameter("@TenMatHang", TenMatHang),
                new SqlParameter("@SoLuong", SoLuong));
        }
        public bool XoaChiTietHoaDon(ref string err, int MaHoaDon, string TenMatHang)
        {
            return db.MyExecuteNonQuery("SpXoaChiTietHoaDon",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHoaDon", MaHoaDon),
                new SqlParameter("@TenMatHang", TenMatHang));
        }
        public bool TinhTienHoaDon(ref string err, int MaHoaDon, string BanAn, string GioThanhToan, long TongTien, string NguoiTT)
        {
            return db.MyExecuteNonQuery("SpTinhTienHoaDon",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHoaDon", MaHoaDon),
                new SqlParameter("@BanAn", BanAn),
                new SqlParameter("@GioThanhToan", GioThanhToan),
                new SqlParameter("@TongTien", TongTien),
                new SqlParameter("@NguoiTT", NguoiTT));
        }
        public bool HuyHoaDon(ref string err, int MaHoaDon, string BanAn, string GioThanhToan, long TongTien,string LyDoHuy, string NguoiTT)
        {
            return db.MyExecuteNonQuery("SpHuyHoaDon",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaHoaDon", MaHoaDon),
                new SqlParameter("@BanAn", BanAn),
                new SqlParameter("@GioThanhToan", GioThanhToan),
                new SqlParameter("@TongTien", TongTien),
                new SqlParameter("@LyDoHuy", LyDoHuy),
                new SqlParameter("@NguoiTT", NguoiTT));
        }
    }
}
