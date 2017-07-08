using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using QuanBunDauTienHai.DAO;
using QuanBunDauTienHai.VO;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace QuanBunDauTienHai
{
    public partial class FrmHoaDon : RibbonForm
    {
        ChiTietHoaDonDAO hd = null;
        DataTable dt = null;
        HoaDonVO hoadon = null;
        DataRow dr = null;
        long t = 0;
        Font font = new System.Drawing.Font("Arial", 9);
        public FrmHoaDon()
        {
            InitializeComponent();
            hd = new ChiTietHoaDonDAO();
            hoadon = new HoaDonVO();
        }
        public static string BANAN;
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            txtTienKhachTra.Text = "0";
            lblBanAn.Text = BANAN;
            lblTenDN.Text = AppConfig.TenDN;
            dt = hd.HoaDon(BANAN);
            if (dt.Rows.Count > 0)
            {         
                hoadon.MaHoaDon = int.Parse(dt.Rows[0][0].ToString());
                hoadon.BanAn = dt.Rows[0][1].ToString();
                hoadon.Ngay = DateTime.Parse(dt.Rows[0][2].ToString());
                hoadon.GioDat = dt.Rows[0][3].ToString();
                lblMaHoaDon.Text = hoadon.MaHoaDon.ToString();
                lblNgayLapHD.Text = hoadon.Ngay.ToShortDateString();         
            }
            lblGioVao.Text = hoadon.GioDat;
            lblGioRa.Text = DateTime.Now.ToString("HH:mm");
            gridControlDSMon.DataSource = hd.DSMon();
            // load data
            LoadData();
        }
        void LoadData()
        {
            //load data
            dt = hd.DSChiTietHoaDon(hoadon.MaHoaDon);
            gridControlHoaDon.DataSource = dt;
            t = 0;
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    t = t + int.Parse(dr[4].ToString());
                }
            }
            catch { }
            CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
            lblTongTien.Text = t.ToString("0,0", elGR);
        }
        private void gridViewDSMon_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string ten = View.GetRowCellDisplayText(e.RowHandle, View.Columns["TenMatHang"]);
                dr = gridViewDSMon.GetFocusedDataRow();
                if (dr[0].ToString().Equals(ten))
                {
                    e.Appearance.BackColor = Color.Chocolate;
                    //   e.Appearance.BackColor2 = Color.LightCyan;
                }
            }
        }
        private bool getColumn(DataTable dt, string tenMon)
        {
            foreach(DataRow dr in dt.Rows)
            {
                if(tenMon.Equals(dr[0].ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        private void gridViewDSMon_DoubleClick(object sender, EventArgs e)
        {
            dr = null;
            dr = gridViewDSMon.GetFocusedDataRow();
            if(getColumn(dt,dr[0].ToString()))
            {
                XtraMessageBox.Show("Tên món bạn chọn đã có trong hóa đơn! Xin hãy chọn lại số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmChonSoLuong frm = new FrmChonSoLuong();
                FrmChonSoLuong.Ten = dr[0].ToString();
                FrmChonSoLuong.DonVi = dr[2].ToString();
                frm.ShowDialog();
                string err = "";
                if(!hd.ThemChiTietHoaDon(ref err,hoadon.MaHoaDon, dr[0].ToString(),FrmChonSoLuong.SoLuong,int.Parse(dr[3].ToString())))
                {
                    XtraMessageBox.Show("Không thể thêm món này vào hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LoadData();
                }
            }
            
        }

        private void gridViewHoaDon_DoubleClick(object sender, EventArgs e)
        {
            dr = null;
            dr = gridViewHoaDon.GetFocusedDataRow();
            FrmChonSoLuong frm = new FrmChonSoLuong();
            FrmChonSoLuong.Ten = dr[0].ToString();
            FrmChonSoLuong.DonVi = dr[1].ToString();
            frm.ShowDialog();
            string err = "";
            if (!hd.SuaSoLuongHoaDon(ref err, hoadon.MaHoaDon, dr[0].ToString(), FrmChonSoLuong.SoLuong))
            {
                XtraMessageBox.Show("Không thể thay đổi số lượng món này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoadData();
            }
        }

        private void gridViewHoaDon_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string ten = View.GetRowCellDisplayText(e.RowHandle, View.Columns["TenMatHang"]);
                dr = gridViewHoaDon.GetFocusedDataRow();
                if (dr[0].ToString().Equals(ten))
                {
                    e.Appearance.BackColor = Color.LightBlue;
                    //   e.Appearance.BackColor2 = Color.LightCyan;
                }
            }
        }

        private void btnHuyMon_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = XtraMessageBox.Show("Có chắc hủy món?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (traloi == DialogResult.Yes)
                {
                    string err = "";
                    dr = null;
                    dr = gridViewHoaDon.GetFocusedDataRow();
                    if (!hd.XoaChiTietHoaDon(ref err, hoadon.MaHoaDon, dr[0].ToString()))
                    {
                        XtraMessageBox.Show("Không thể xóa món này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LoadData();
                    }
                }
            }
            catch { }
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            FrmHuyHoaDon frm = new FrmHuyHoaDon();
            FrmHuyHoaDon.BanAn = hoadon.BanAn;
            frm.ShowDialog();
            if(FrmHuyHoaDon.LyDoHuy!=null)
            {
                string err = "";
                if (hd.HuyHoaDon(ref err, hoadon.MaHoaDon, hoadon.BanAn, lblGioRa.Text, t, FrmHuyHoaDon.LyDoHuy, AppConfig.TenDN))
                {
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Không thể hủy hóa đơn này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void inHoaDon()
        {
            CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
            rptHoaDon rpt = new rptHoaDon();
            dt = hd.DSChiTietHoaDon(hoadon.MaHoaDon);
            rpt.DataSource = dt.DataSet;
            rpt.DataMember = "HoaDon";
            rpt.xrLabelBan.Text = "HĐ TÍNH TIỀN: " + lblBanAn.Text;
            rpt.xrLabelMaHoaDon.Text = "HĐ: " + lblMaHoaDon.Text;
            rpt.xrLabelNgay.Text = "Ngày: " + lblNgayLapHD.Text + " " + lblGioRa.Text;
            int i = 0;
            
            for (i = 0; i < dt.Rows.Count; i++)
            {
                XRTableRow row = new XRTableRow();
                XRTableCell cell = new XRTableCell();
                cell.Text = dt.Rows[i][0].ToString();
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.Font = font;
                cell.WidthF = 70;

                row.Cells.Add(cell);
                //
                cell = new XRTableCell();
                cell.Text = dt.Rows[i][2].ToString();
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.Font = font;
                cell.WidthF = 18;
                row.Cells.Add(cell);
                //
                cell = new XRTableCell();
                cell.Text = long.Parse(dt.Rows[i][3].ToString()).ToString("0,0", elGR);
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.Font = font;
                cell.WidthF = 50;
                row.Cells.Add(cell);
                //
                cell = new XRTableCell();
                cell.Text = long.Parse(dt.Rows[i][4].ToString()).ToString("0,0", elGR);
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.Font = font;
                cell.WidthF = 52;
                row.Cells.Add(cell);
                //
                rpt.xrTable.Rows.Add(row);
            }

            rpt.xrLabelTongTienThanhToan.Text = lblTongTien.Text;

            rpt.CreateDocument();
            //rpt.PrinterName = "";
            //rpt.PrintDialog();
            rpt.Print();
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
           
                DialogResult traloi;
                string err = "";
                // Hiện hộp thoại hỏi đáp 
                traloi = XtraMessageBox.Show("Tính tiền và kết thúc hóa đơn?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                try
                {
                    if (traloi == DialogResult.Yes)
                    {
                        if (hd.TinhTienHoaDon(ref err,hoadon.MaHoaDon,hoadon.BanAn,lblGioRa.Text,t,AppConfig.TenDN))
                        {

                            this.Close();
                            inHoaDon();
                        }
                        else
                        {
                            XtraMessageBox.Show("Không thể kết thúc hóa đơn này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                catch { }
           
        }

        private void txtTienKhachTra_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                long soTienTra = long.Parse(txtTienKhachTra.Text);
                long soTienDu = soTienTra*1000 - t;
                CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
                lblSoTienDu.Text = soTienDu.ToString("0,0", elGR);
            }
            catch { }
        }

        private void btnTinhTienKHD_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            traloi = XtraMessageBox.Show("Tính tiền và kết thúc hóa đơn?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (traloi == DialogResult.Yes)
                {
                    if (hd.TinhTienHoaDon(ref err, hoadon.MaHoaDon, hoadon.BanAn, lblGioRa.Text, t, AppConfig.TenDN))
                    {

                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Không thể kết thúc hóa đơn này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch { }
        }
    }
}
