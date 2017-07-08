using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBunDauTienHai.VO
{
    class MatHangVO
    {
        private string tenMatHang;
        private string loaiMatHang;
        private string donVi;
        private int gia;

        public string TenMatHang
        {
            get
            {
                return tenMatHang;
            }

            set
            {
                tenMatHang = value;
            }
        }

        public string LoaiMatHang
        {
            get
            {
                return loaiMatHang;
            }

            set
            {
                loaiMatHang = value;
            }
        }

        public string DonVi
        {
            get
            {
                return donVi;
            }

            set
            {
                donVi = value;
            }
        }

        public int Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }
    }
}
