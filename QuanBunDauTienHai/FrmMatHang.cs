using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QuanBunDauTienHai.DAO;
using QuanBunDauTienHai.VO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanBunDauTienHai
{
    public partial class FrmMatHang : RibbonForm
    {
        DataTable dt = null;
        DataRow dr = null;
        MatHangDAO mh = null;
        MatHangVO mathang = null;
        bool them = false;
        public FrmMatHang()
        {
            InitializeComponent();
            mh = new MatHangDAO();
            mathang = new MatHangVO();
        }
        void LoadData()
        {

            gridControl.DataSource = dt;
            gridView_RowClick(null, null);
        }
        private void FrmMatHang_Load(object sender, EventArgs e)
        {
            dt = mh.DSMatHang();
            lookUpLoai.Properties.DataSource = mh.DSLoaiMatHang();
            lookUpLoai.Properties.ValueMember = "LoaiMatHang";
            lookUpLoai.Properties.DisplayMember = "LoaiMatHang";
            //lookUpLoai.ItemIndex = 0;
            LoadData();
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            them = false;
            btnXoa.Enabled = true;
            txtTenMatHang.Enabled = false;
            try
            {
                dr = null;
                dr = gridView.GetFocusedDataRow();
                txtTenMatHang.Text = dr[0].ToString();
                lookUpLoai.EditValue = dr[1].ToString();
                txtDonVi.Text = dr[2].ToString();
                txtGia.Text = dr[3].ToString();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenMatHang.Enabled = true;
            txtTenMatHang.Text = "";
            txtTenMatHang.Focus();
            //txtDonVi.Text = "";
            txtGia.Text = "";

            them = true;
            btnXoa.Enabled = false;
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                mathang.TenMatHang = txtTenMatHang.Text;
                mathang.DonVi = txtDonVi.Text;
                mathang.Gia = int.Parse(txtGia.Text);
                mathang.LoaiMatHang = lookUpLoai.EditValue.ToString();
                if(them)
                {
                    if(mh.ThemMatHang(ref err,mathang))
                    {
                        dr = dt.NewRow();
                        dr[0] = mathang.TenMatHang;
                        dr[1] = mathang.LoaiMatHang;
                        dr[2] = mathang.DonVi;
                        dr[3] = mathang.Gia;
                        dt.Rows.Add(dr);
                        LoadData();
                    }
                    else
                    {
                        XtraMessageBox.Show("Không thêm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if(mh.SuaMatHang(ref err,mathang))
                    {
                        int index = dt.Rows.IndexOf(dr);
                        dt.Rows[index][1] = mathang.LoaiMatHang;
                        dt.Rows[index][2] = mathang.DonVi;
                        dt.Rows[index][3] = mathang.Gia;
                    }
                    else
                    {
                        XtraMessageBox.Show("Không sửa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                        if (mh.XoaMatHang(ref err,dr[0].ToString()))
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
