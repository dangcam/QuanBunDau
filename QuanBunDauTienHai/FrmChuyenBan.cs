using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QuanBunDauTienHai.DAO;
using System;
using System.Windows.Forms;

namespace QuanBunDauTienHai
{
    public partial class FrmChuyenBan : RibbonForm
    {
        BanAnDAO ba = null;
        public FrmChuyenBan()
        {
            InitializeComponent();
            ba = new BanAnDAO();
        }

        private void FrmChuyenBan_Load(object sender, EventArgs e)
        {
            lookUpBanCoKhach.Properties.DataSource = ba.DSBanAnCoKhach();
            lookUpBanCoKhach.Properties.ValueMember = "BanAn";
            lookUpBanCoKhach.Properties.DisplayMember = "BanAn";
            lookUpBanCoKhach.ItemIndex = 0;
            lookUpBanTrong.Properties.DataSource = ba.DSBanAnTrong();
            lookUpBanTrong.Properties.ValueMember = "BanAn";
            lookUpBanTrong.Properties.DisplayMember = "BanAn";
            lookUpBanTrong.ItemIndex = 0;
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            string err = "";
            if(ba.ChuyenBanAn(ref err,lookUpBanTrong.EditValue.ToString(),lookUpBanCoKhach.EditValue.ToString()))
            {
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Không chuyển được! "+ err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
