using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBunDauTienHai.DAO
{
    class BieuDoDAO
    {
        Connection db = null;
        public BieuDoDAO()
        {
            db = new Connection();
        }
        public DataTable BieuDoThang(string Thang, string Nam)
        {
            return db.ExcuteQuery("SELECT NGAY,SUM(TongTien) AS TONG FROM"+
                                    " (SELECT DAY(Ngay) AS NGAY, TongTien"+
                                    " FROM HoaDon"+
                                    " WHERE MONTH(Ngay) = '"+Thang+"' AND YEAR(Ngay) = '"+Nam+"' AND TinhTrang = 1) AS THANG"+
                                    " GROUP BY NGAY",
                                    CommandType.Text, null);
        }
        public DataTable BieuDoNam(string Nam)
        {
            return db.ExcuteQuery("SELECT THANG,SUM(TongTien) AS TONG FROM" +
                                    " (SELECT MONTH(Ngay) AS THANG, TongTien" +
                                    " FROM HoaDon" +
                                    " WHERE YEAR(Ngay) = '" + Nam + "' AND TinhTrang = 1) AS NAM" +
                                    " GROUP BY THANG",
                                    CommandType.Text, null);
        }
    }
}
