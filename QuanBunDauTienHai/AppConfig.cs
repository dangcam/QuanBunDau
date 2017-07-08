using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBunDauTienHai
{
    class AppConfig
    {
        private static string tenDN;
        private static string ten;
        private static string matKhau;
        private static string serVer;
        private static string dataBase;
        private static string path;
        public static string TenDN
        {
            get
            {
                return tenDN;
            }

            set
            {
                tenDN = value;
            }
        }

        public static string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public static string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public static string SerVer
        {
            get
            {
                return serVer;
            }

            set
            {
                serVer = value;
            }
        }

        public static string DataBase
        {
            get
            {
                return dataBase;
            }

            set
            {
                dataBase = value;
            }
        }

        public static string Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }
    }
}
