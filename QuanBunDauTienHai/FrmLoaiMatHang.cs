
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QuanBunDauTienHai.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanBunDauTienHai
{
    public partial class FrmLoaiMatHang : RibbonForm
    {
        LoaiMatHangDAO mh = null;
        DataTable dt = null;
        DataRow dr = null;
        public FrmLoaiMatHang()
        {
            InitializeComponent();
            mh = new LoaiMatHangDAO();
        }
        void LoadData()
        {
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            gridControl.DataSource = dt;
            gridView_RowClick(null, null);
        }
        private void FrmLoaiMatHang_Load(object sender, EventArgs e)
        {
            dt = mh.DSLoaiMatHang();
            LoadData();
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                dr = null;
                dr = gridView.GetFocusedDataRow();
                txtLoaiMatHang.Text = dr[0].ToString();
            }
            catch
            {
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtLoaiMatHang.Text = "";
           
            txtLoaiMatHang.Focus();

            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if (mh.ThemLoaiMatHang(ref err, txtLoaiMatHang.Text))
                {
                    dr = dt.NewRow();
                    dr[0] = txtLoaiMatHang.Text;

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

        private void btnXoa_Click(object sender, EventArgs e)
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
                        if (mh.XoaLoaiMatHang(ref err, dr[0].ToString()))
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
    }
}
