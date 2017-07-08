using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBunDauTienHai.DAO
{
    class DSHoaDonDAO
    {
        Connection db = null;
        public DSHoaDonDAO()
        {
            db = new Connection();
        }
        public DataTable DSHoaDonNgay(string date)
        {
            return db.ExcuteQuery("Select * From HoaDon WHERE Ngay='"+date+"' AND (TinhTrang=1 OR TinhTrang=2)",
                CommandType.Text, null);
        }
        public DataTable DSHoaDonNhanVien(string date,string TenDN)
        {
            return db.ExcuteQuery("Select * From HoaDon WHERE Ngay='" + date + "' AND (TinhTrang=1 OR TinhTrang=2) AND NguoiTT='"+TenDN+"'",
                CommandType.Text, null);
        }
        public DataTable DSNhanVien()
        {
            return db.ExcuteQuery("Select TenDN From NhanVien",
                CommandType.Text, null);
        }
    }
}
