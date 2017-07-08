using DevExpress.XtraBars.Ribbon;
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
    public partial class FrmChonSoLuong : RibbonForm
    {
        public static string DonVi;
        public static string Ten;
        public static int SoLuong = 0;
        public FrmChonSoLuong()
        {
            InitializeComponent();
        }

        private void FrmChonSoLuong_Load(object sender, EventArgs e)
        {
            lblThongBao.Text = "";
            lblMon.Text = Ten;
            if(DonVi.Equals("Miếng"))
            {
                if("Nem thêm".Equals(Ten))
                {
                    lblDonVi.Text = DonVi + " (1 dĩa có 7 miếng)";
                    txtSL.Text = "7";
                }
                else
                {
                    lblDonVi.Text = DonVi + " (1 dĩa có 3 miếng)";
                    txtSL.Text = "3";
                }
            }
            else
            {
                lblDonVi.Text = DonVi;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try {
                SoLuong = int.Parse(txtSL.Text);
                if (SoLuong > 0)
                {
                    this.Close();
                }
                else
                {
                    lblThongBao.Text = "Số lượng > 0";
                    txtSL.Focus();
                }
            }
            catch { }
        }
    }
}
