using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QuanBunDauTienHai.DAO;
using System.Data;
using System.Windows.Forms;

namespace QuanBunDauTienHai
{
    public partial class FrmBanAn : RibbonForm
    {
        BanAnDAO ba = null;
        DataTable dt = null;
        DataRow dr = null;
        public FrmBanAn()
        {
            InitializeComponent();
            ba = new BanAnDAO();
        }
        void LoadData()
        {
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            gridControl.DataSource = dt;
            gridView_RowClick(null, null);
        }
        private void FrmBanAn_Load(object sender, System.EventArgs e)
        {
            dt = ba.DSBanAn();
            LoadData();
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            txtBan.Text = "";
            txtTang.Text = "";
            txtBan.Focus();
            
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, System.EventArgs e)
        {
            try
            {
                string err = "";
                if(ba.ThemBanAn(ref err,txtBan.Text,int.Parse(txtTang.Text)))
                {
                    dr = dt.NewRow();
                    dr[0] = txtBan.Text;
                    dr[1] = txtTang.Text;
                    dt.Rows.Add(dr);
                    LoadData();
                }
                else
                {
                    XtraMessageBox.Show("Không thêm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
        }

        private void simpleButton2_Click(object sender, System.EventArgs e)
        {
            try
            {
                DialogResult traloi;
                string err = "";
                // Hiện hộp thoại hỏi đáp 
                DataRow drRow = gridView.GetFocusedDataRow();

                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                try
                {
                    if (traloi == DialogResult.Yes)
                    {
                        if (ba.XoaBanAn(ref err, dr[0].ToString()))
                        {
                            XtraMessageBox.Show("Xóa thành công!");
                            int index = dt.Rows.IndexOf(drRow);
                            dt.Rows[index].Delete();
                            LoadData();
                        }
                        else
                        {
                            XtraMessageBox.Show("Không thể xóa mẫu tin này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                catch { }
            }
            catch { }
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                //btnLuu.Enabled = true;
                dr = null;
                dr = gridView.GetFocusedDataRow();
                txtBan.Text = dr[0].ToString();
                txtTang.Text = dr[1].ToString();
            }
            catch
            {
            }
        }
    }
}
