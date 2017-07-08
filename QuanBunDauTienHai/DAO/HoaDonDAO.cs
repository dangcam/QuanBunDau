using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanBunDauTienHai.DAO
{
    class HoaDonDAO
    {
        Connection db = null;
        public HoaDonDAO()
        {
            db = new Connection();
        }
        public DataTable DSBanAn()
        {
            return db.ExcuteQuery("Select  * From getBanAn() ORDER BY Tang,BanAn ASC",
                CommandType.Text, null);
        }
        public DataTable DSChiTietHoaDon(int MaHoaDon)
        {
            return db.ExcuteQuery("Select  * From getHoaDonChiTiet('" + MaHoaDon + "')",
                CommandType.Text, null);
        }
        public DataTable HoaDon(int MaHoaDon)
        {
            return db.ExcuteQuery("Select  * From HoaDon Where MaHoaDon="+MaHoaDon+"",
                CommandType.Text, null);
        }
        public bool DatBanAn(ref string err, string BanAn, string Gio, DateTime Ngay, string TenDN)
        {
            return db.MyExecuteNonQuery("SpDatBanAn",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@BanAn", BanAn),
                new SqlParameter("@Ngay", Ngay),
                new SqlParameter("@Gio", Gio),
                new SqlParameter("@TenDN", TenDN));
        }
        public DataTable DSHoaDonNgay(string date)
        {
            return db.ExcuteQuery("Select  * From getHoaDonNgay('"+date+ "') ORDER BY GioThanhToan ASC",
                CommandType.Text, null);
        }
    }
}
