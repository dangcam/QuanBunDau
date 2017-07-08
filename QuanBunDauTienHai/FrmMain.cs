using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QuanBunDauTienHai.DAO;
using QuanBunDauTienHai.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanBunDauTienHai
{
    public partial class FrmMain : RibbonForm
    {
        DataTable dt = null;
        DataRow dr = null;
        HoaDonDAO hd = null;
        DataBaseDAO data = null;
        int d = 0, t = 0;
        Form frmDN;
        FrmHoaDon frmHoaDon;
        public FrmMain(Form _frm)
        {
            InitializeComponent();
            InitSkinGallery();
            hd = new HoaDonDAO();
            data = new DataBaseDAO();
            frmDN = _frm;
            frmHoaDon = new FrmHoaDon();
        }
        private void InitSkinGallery()
        {

            DevExpress.Skins.SkinContainerCollection skinCollection = DevExpress.Skins.SkinManager.Default.Skins;
           // DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinCollection[4].SkinName);
            SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem, true);
        }
        private void LoadData()
        {
            dt = hd.DSBanAn();
            dt.Columns.Add("TrangThaiHinh", typeof(Image));
            d = 0;
            for(int i = 0; i<dt.Rows.Count;i++)
            {
                if(!bool.Parse(dt.Rows[i][1].ToString()))
                {
                    dt.Rows[i][4] = Resources.Trong;
                }
                else
                {
                    dt.Rows[i][4] = Resources.CoKhach;
                    d++;
                }
            }
            t = dt.Rows.Count;
            progressBarControl.Properties.Maximum = t;
            progressBarControl.Position = d;
            lblTinhTrang.Text = "Tình trạng sử dụng: " + d + "/" + t;
            gridControl.DataSource = dt;
            
        }
        private void LoadDataHoaDon()
        {
            dt = null;
            dt = hd.DSHoaDonNgay(DateTime.Now.ToString("yyyy-MM-dd"));
            dt.Columns.Add("TinhTrangHinh", typeof(Image));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ("1".Equals(dt.Rows[i][4].ToString()))
                {
                    dt.Rows[i][5] = Resources.apply_icon;
                }
                else
                {
                    dt.Rows[i][5] = Resources.delete_icon;
                }
            }
            gridControlHoaDon.DataSource = dt;
        }
        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            lblHomNay.Text = DateTime.Now.ToShortDateString();
            lblChao.Text = "Chào, " + AppConfig.TenDN;
            LoadData();
            LoadDataHoaDon();
            // kiểm tra quyền hạn
            barButtonItemLoaiMatHang.Enabled = false;
            barButtonItemMatHang.Enabled = false;
            barButtonItemNhanVien.Enabled = false;
            barButtonItemBanAn.Enabled = false;
            barButtonItemPhucHoi.Enabled = false;
            barButtonItemSaoLuu.Enabled = false;
            barButtonItemHoaDon.Enabled = false;
            barButtonItemBieuDo.Enabled = false;
            if ("admin".Equals(AppConfig.TenDN)||"anhtuyet".Equals(AppConfig.TenDN))
            {
                barButtonItemLoaiMatHang.Enabled = true;
                barButtonItemMatHang.Enabled = true;
                barButtonItemNhanVien.Enabled = true;
                barButtonItemBanAn.Enabled = true;
                barButtonItemPhucHoi.Enabled = true;
                barButtonItemSaoLuu.Enabled = true;
                barButtonItemHoaDon.Enabled = true;
                barButtonItemBieuDo.Enabled = true;
            }
            

        }
        private void barButtonItemBanAn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBanAn frm = new FrmBanAn();
            frm.ShowDialog();
            LoadData();
        }

        private void barButtonItemLoaiMatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLoaiMatHang frm = new FrmLoaiMatHang();
            frm.ShowDialog();
        }

        private void barButtonItemMatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMatHang frm = new FrmMatHang();
            frm.ShowDialog();
        }

      
        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }

        private void gridView_DoubleClick(object sender, System.EventArgs e)
        {
            try
            {
                DialogResult traloi;
                string err = "";
                // Hiện hộp thoại hỏi đáp 
                dr = gridView.GetFocusedDataRow();
                if (!bool.Parse(dr[1].ToString()))
                {
                    traloi = XtraMessageBox.Show("Bạn có muốn chuyển bàn này sang có khách?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    try
                    {
                        if (traloi == DialogResult.Yes)
                        {
                            if (hd.DatBanAn(ref err,dr[0].ToString(), DateTime.Now.ToString("HH:mm"),DateTime.Now,AppConfig.TenDN))
                            {
                                
                                FrmHoaDon.BANAN = dr[0].ToString();
                                frmHoaDon.ShowDialog();
                                LoadData();
                                LoadDataHoaDon();
                            }
                            else
                            {
                                XtraMessageBox.Show("Không thêm hóa đơn được cho bàn này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    catch { }
                }
                else
                {
                    
                    FrmHoaDon.BANAN = dr[0].ToString();
                    frmHoaDon.ShowDialog();
                    LoadData();
                    LoadDataHoaDon();
                }
            }
            catch { }
        }

        private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle>=0)
            {
                string ban = View.GetRowCellDisplayText(e.RowHandle, View.Columns["BanAn"]);
                dr = gridView.GetFocusedDataRow();
                if (dr[0].ToString().Equals(ban))
                {
                    e.Appearance.BackColor = Color.BurlyWood;
                    //e.Appearance.BackColor2 = Color.LightCyan;
                }
            }
        }

        private void gridViewHoaDon_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string hoadon = View.GetRowCellDisplayText(e.RowHandle, View.Columns["MaHoaDon"]);
                dr = gridViewHoaDon.GetFocusedDataRow();
                if (dr[0].ToString().Equals(hoadon))
                {
                    e.Appearance.BackColor = Color.CornflowerBlue;

                }
            }
        }

        private void gridViewHoaDon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                dr = null;
                dr = gridViewHoaDon.GetFocusedDataRow();
                FrmHoaDonChiTiet frm = new FrmHoaDonChiTiet();
                FrmHoaDonChiTiet.MaHoaDon = int.Parse(dr[0].ToString());
                frm.ShowDialog();
            }
            catch { }
        }

        private void barButtonItemHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDSHoaDon frm = new FrmDSHoaDon();
            frm.ShowDialog();
        }

        private void barButtonItemBieuDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBieuDo frm = new FrmBieuDo();
            frm.ShowDialog();
        }

        private void barButtonItemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQuanLyNhanVien frm = new FrmQuanLyNhanVien();
            frm.ShowDialog();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDN.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barButtonItemSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sqlRestore = "BACKUP DATABASE["+AppConfig.DataBase+"] TO DISK = '"+AppConfig.Path+"'";
            try
            {
                string err = "";
                if(data.BackUpOrRestore(ref err,sqlRestore))
                {
                    XtraMessageBox.Show("Dữ liệu đã được sao lưu!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Dữ liệu không được sao lưu, "+err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                XtraMessageBox.Show("Có lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItemPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = XtraMessageBox.Show("Nên sao lưu dữ liệu trước khi phục hồi, có chắc phục hồi dữ liệu?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                string sqlRestore = "Use master ALTER DATABASE " + AppConfig.DataBase +
            " SET SINGLE_USER WITH ROLLBACK IMMEDIATE Restore Database [" + AppConfig.DataBase + "] from disk='" + AppConfig.Path + "'";
                try
                {
                    string err = "";
                    if (data.BackUpOrRestore(ref err, sqlRestore))
                    {
                        XtraMessageBox.Show("Dữ liệu đã được phục hồi!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Dữ liệu không được phục hồi, " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Có lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if(d == 0)
            {
                XtraMessageBox.Show("Không có bàn có khách để thực hiện chuyển","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                if(d==t)
            {
                XtraMessageBox.Show("Không còn bàn trống để thực hiện chuyển", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmChuyenBan frm = new FrmChuyenBan();
                frm.ShowDialog();
                LoadData();
            }
        }
    }
}
