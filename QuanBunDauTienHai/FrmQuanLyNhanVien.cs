using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QuanBunDauTienHai.DAO;
using QuanBunDauTienHai.VO;
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
    public partial class FrmQuanLyNhanVien : RibbonForm
    {
        DataRow dr = null;
        NhanVienDAO nv = null;
        bool them = false;
        DataTable dt = null;
        NhanVienVO nhanvien = null;
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            nv = new NhanVienDAO();
            nhanvien = new NhanVienVO();
        }
        private void LoadData()
        {
            gridControl.DataSource = dt;

            txtTenDN.Enabled = false;
            them = false;
            btnXoa.Enabled = true;
        }
        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dt = nv.DSNhanVien();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenDN.Enabled = true;
            them = true;
            btnXoa.Enabled = false;

            txtTenDN.Text = "";
            txtMatKhau.Text = "";
            txtSDT.Text = "";
            txtTenNV.Text = "";

            txtTenDN.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                nhanvien.TenDN = txtTenDN.Text;
                nhanvien.TenNV = txtTenNV.Text;
                nhanvien.MatKhau = txtMatKhau.Text;
                nhanvien.SDT = txtSDT.Text;
                if (them)
                {
                    if (nv.ThemNhanVien(ref err, nhanvien))
                    {
                        dr = dt.NewRow();
                        dr[0] = nhanvien.TenDN;
                        dr[1] = nhanvien.MatKhau;
                        dr[2] = nhanvien.TenNV;
                        dr[3] = nhanvien.SDT;
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
                    if (nv.SuaNhanVien(ref err, nhanvien))
                    {
                        int index = dt.Rows.IndexOf(dr);
                        dt.Rows[index][1] = nhanvien.MatKhau;
                        dt.Rows[index][2] = nhanvien.TenNV;
                        dt.Rows[index][3] = nhanvien.SDT;
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
                DialogResult traloi;
                string err = "";
                // Hiện hộp thoại hỏi đáp 

                traloi = XtraMessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                try
                {
                    if (traloi == DialogResult.Yes)
                    {
                        if (!"admin".Equals(dr[0].ToString())&&nv.XoaNhanVien(ref err, dr[0].ToString()))
                        {
                            XtraMessageBox.Show("Xóa thành công!");
                            int index = dt.Rows.IndexOf(dr);
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

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                dr = gridView.GetFocusedDataRow();
                txtTenDN.Text = dr[0].ToString();
                txtMatKhau.Text = dr[1].ToString();
                txtTenNV.Text = dr[2].ToString();
                txtSDT.Text = dr[3].ToString();
            }
            catch { }
        }
    }
}
