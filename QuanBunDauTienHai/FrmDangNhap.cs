using DevExpress.XtraBars.Ribbon;
using QuanBunDauTienHai.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanBunDauTienHai
{
    public partial class FrmDangNhap : RibbonForm
    {
        NhanVienDAO nv = null;
        ReadConfig readConfig = new ReadConfig();
        FrmMain frm;
        public FrmDangNhap()
        {
            InitializeComponent();
            readConfig.Read();
            nv = new NhanVienDAO();
            frm = new FrmMain(this);
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            
            AppConfig.TenDN = null;
            AppConfig.Ten = null;
            AppConfig.MatKhau = null;
            lblThongBao.Hide();
        }
        private bool check(string TenDN, string MatKhau)
        {
            DataTable dt = null;
            dt = nv.DangNhap(TenDN, MatKhau);
            if(dt.Rows.Count!=0)
            {
                return true;
            }
            return false;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(check(txtTenDN.Text,txtMatKhau.Text))
            {
                // Đăng nhập
                lblThongBao.Hide();
                this.Hide();
                AppConfig.MatKhau = txtMatKhau.Text;
                AppConfig.TenDN = txtTenDN.Text;
 
                frm.ShowDialog();
                // Thoát
                AppConfig.TenDN = null;
                AppConfig.Ten = null;
                AppConfig.MatKhau = null;
                txtMatKhau.Text = "";
            }
            else
            {
                lblThongBao.Show();
            }
        }
    }
}
