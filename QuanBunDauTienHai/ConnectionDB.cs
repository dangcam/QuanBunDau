using System.Data.SqlClient;

namespace QuanBunDauTienHai
{
    class ConnectionDB
    {
        public static SqlConnection get()
        {
            SqlConnection conn = new SqlConnection();
                          conn.ConnectionString = "Data Source="+AppConfig.SerVer+";"
                          + "Initial Catalog="+AppConfig.DataBase+";"
                          + "Integrated Security=True";
            return conn;
        }
    }
}
