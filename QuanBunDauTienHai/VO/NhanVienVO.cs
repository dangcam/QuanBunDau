using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBunDauTienHai.VO
{
    class NhanVienVO
    {
        private string tenDN;
        private string matKhau;
        private string tenNV;
        private string sDT;

        public string TenDN
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

        public string MatKhau
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

        public string TenNV
        {
            get
            {
                return tenNV;
            }

            set
            {
                tenNV = value;
            }
        }

        public string SDT
        {
            get
            {
                return sDT;
            }

            set
            {
                sDT = value;
            }
        }
    }
}
