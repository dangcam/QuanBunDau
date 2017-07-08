using System;

namespace QuanBunDauTienHai.VO
{
    class HoaDonVO
    {
        private int maHoaDon;
        private string banAn;
        private DateTime ngay;
        private string gioDat;
        private string gioThanhToan;
        private int tongTien;
        private int TinhTrang;
        private string lyDoHuy;
        private string nguoiLap;
        private string nguoiTT;

        public int MaHoaDon
        {
            get
            {
                return maHoaDon;
            }

            set
            {
                maHoaDon = value;
            }
        }

        public string BanAn
        {
            get
            {
                return banAn;
            }

            set
            {
                banAn = value;
            }
        }

        public DateTime Ngay
        {
            get
            {
                return ngay;
            }

            set
            {
                ngay = value;
            }
        }

        public string GioDat
        {
            get
            {
                return gioDat;
            }

            set
            {
                gioDat = value;
            }
        }

        public string GioThanhToan
        {
            get
            {
                return gioThanhToan;
            }

            set
            {
                gioThanhToan = value;
            }
        }

        public int TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }

        public int TinhTrang1
        {
            get
            {
                return TinhTrang;
            }

            set
            {
                TinhTrang = value;
            }
        }

        public string LyDoHuy
        {
            get
            {
                return lyDoHuy;
            }

            set
            {
                lyDoHuy = value;
            }
        }

        public string NguoiLap
        {
            get
            {
                return nguoiLap;
            }

            set
            {
                nguoiLap = value;
            }
        }

        public string NguoiTT
        {
            get
            {
                return nguoiTT;
            }

            set
            {
                nguoiTT = value;
            }
        }
    }
}
