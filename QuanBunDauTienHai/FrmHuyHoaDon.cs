using DevExpress.XtraBars.Ribbon;
using System;

namespace QuanBunDauTienHai
{
    public partial class FrmHuyHoaDon : RibbonForm
    {
        public static string BanAn = null;
        public static string LyDoHuy = null;
        public FrmHuyHoaDon()
        {
            InitializeComponent();
        }

        private void FrmHuyHoaDon_Load(object sender, EventArgs e)
        {
            lblBanAn.Text = BanAn;
            lblThongBao.Text = "";
            memoLyDo.Text = "";
            LyDoHuy = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(memoLyDo.Text.Length>10)
            {
                LyDoHuy = memoLyDo.Text;
                this.Close();
            }
            else
            {
                lblThongBao.Text = "Lý do hủy phải > 10 ký tự.";
                memoLyDo.Focus();
            }
        }
    }
}
