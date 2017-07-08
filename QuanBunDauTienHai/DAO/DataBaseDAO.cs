using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanBunDauTienHai.DAO
{
    class DataBaseDAO
    {
        Connection db = null;
        public DataBaseDAO()
        {
            db = new Connection();
        }
        public bool BackUpOrRestore(ref string err, string strSQL)
        {
            return db.BackUpOrRestore(strSQL,ref err);
        }
    }
}
