using DevExpress.XtraBars.Ribbon;
using QuanBunDauTienHai.DAO;
using QuanBunDauTienHai.Properties;
using QuanBunDauTienHai.VO;
using System;
using System.Data;
using System.Globalization;
using DevExpress.XtraReports.UI;
using DevExpress.ChartRangeControlClient.Core;
using System.Drawing;

namespace QuanBunDauTienHai
{
    public partial class FrmHoaDonChiTiet : RibbonForm
    {
        public static int MaHoaDon;
        HoaDonDAO hd = null;
        DataTable dt = null;
        HoaDonVO hoadon = null;
        DataRow dr = null;
        public FrmHoaDonChiTiet()
        {
            InitializeComponent();
            hd = new HoaDonDAO();
            hoadon = new HoaDonVO();
        }

        private void FrmHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            dt = hd.HoaDon(MaHoaDon);
            if(dt.Rows.Count>0)
            {
                dr = dt.Rows[0];
                lblMaHoaDon.Text = dr[0].ToString();
                lblBanAn.Text = dr[1].ToString();
                lblNgayLapHD.Text = DateTime.Parse(dr[2].ToString()).ToShortDateString();
                lblGioVao.Text = dr[3].ToString();
                lblGioRa.Text = dr[4].ToString();
                int t = int.Parse(dr[5].ToString());
                CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
                lblTongTien.Text = t.ToString("0,0", elGR);
                lblNguoiLap.Text = dr[8].ToString();
                lblNguoiKT.Text = dr[9].ToString();
                if("1".Equals(dr[6].ToString()))
                {
                    lblHoaDonHuy.Hide();
                    memoLyDo.Hide();
                    pictureTT.Image = Resources.apply_icon;
                }
                else
                {
                    lblHoaDonThanhToan.Hide();
                    btnInLaiHD.Hide();
                    memoLyDo.Text = "Lý do hủy: " + dr[7].ToString();
                    pictureTT.Image = Resources.delete_icon;
                }
            }
            gridControlHoaDon.DataSource = hd.DSChiTietHoaDon(MaHoaDon);
        }

        private void btnInLaiHD_Click(object sender, EventArgs e)
        {
            CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
            rptHoaDon rpt = new rptHoaDon();
            Font font = new System.Drawing.Font("Arial", 9);
            dt = hd.DSChiTietHoaDon(MaHoaDon);
            rpt.DataSource = dt.DataSet;
            rpt.DataMember = "HoaDon";
            rpt.xrLabelBan.Text = "HĐ TÍNH TIỀN: " + lblBanAn.Text;
            rpt.xrLabelMaHoaDon.Text = "HĐ: " + lblMaHoaDon.Text;
            rpt.xrLabelNgay.Text = "Ngày: " + lblNgayLapHD.Text + " " + lblGioRa.Text;
            int i = 0;
            for(i=0;i<dt.Rows.Count;i++)
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
            rpt.PrinterName = "";
            rpt.PrintDialog();
        }
    }
}
