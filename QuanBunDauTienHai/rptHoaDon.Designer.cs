namespace QuanBunDauTienHai
{
    partial class rptHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTongTienThanhToan = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTongTien = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelMaHoaDon = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelNgay = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelBan = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.TenMatHang = new DevExpress.XtraReports.UI.XRTableCell();
            this.SoLuong = new DevExpress.XtraReports.UI.XRTableCell();
            this.Gia = new DevExpress.XtraReports.UI.XRTableCell();
            this.ThanhTien = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblTenQuan = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xpView1 = new DevExpress.Xpo.XPView(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabelTongTienThanhToan,
            this.xrLabelTongTien,
            this.xrLabelMaHoaDon,
            this.xrLabelNgay,
            this.xrLabelBan,
            this.xrLabel3,
            this.xrLabel2,
            this.xrTable,
            this.lblTenQuan});
            this.TopMargin.HeightF = 600F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.TopMargin.AfterPrint += new System.EventHandler(this.TopMargin_AfterPrint);
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(12F, 184F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(172F, 22F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Hẹn gặp lại quý khách.";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(30F, 160F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(139.5833F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Xin cảm ơn!";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabelTongTienThanhToan
            // 
            this.xrLabelTongTienThanhToan.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabelTongTienThanhToan.LocationFloat = new DevExpress.Utils.PointFloat(90F, 136F);
            this.xrLabelTongTienThanhToan.Name = "xrLabelTongTienThanhToan";
            this.xrLabelTongTienThanhToan.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelTongTienThanhToan.SizeF = new System.Drawing.SizeF(89.45834F, 23F);
            this.xrLabelTongTienThanhToan.StylePriority.UseFont = false;
            this.xrLabelTongTienThanhToan.StylePriority.UseTextAlignment = false;
            this.xrLabelTongTienThanhToan.Text = "000.000";
            this.xrLabelTongTienThanhToan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabelTongTien
            // 
            this.xrLabelTongTien.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabelTongTien.LocationFloat = new DevExpress.Utils.PointFloat(0F, 136F);
            this.xrLabelTongTien.Name = "xrLabelTongTien";
            this.xrLabelTongTien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelTongTien.SizeF = new System.Drawing.SizeF(89.58334F, 23F);
            this.xrLabelTongTien.StylePriority.UseFont = false;
            this.xrLabelTongTien.StylePriority.UseTextAlignment = false;
            this.xrLabelTongTien.Text = "Tổng tiền:";
            this.xrLabelTongTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabelMaHoaDon
            // 
            this.xrLabelMaHoaDon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabelMaHoaDon.LocationFloat = new DevExpress.Utils.PointFloat(125F, 88.00002F);
            this.xrLabelMaHoaDon.Name = "xrLabelMaHoaDon";
            this.xrLabelMaHoaDon.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelMaHoaDon.SizeF = new System.Drawing.SizeF(65F, 23F);
            this.xrLabelMaHoaDon.StylePriority.UseFont = false;
            this.xrLabelMaHoaDon.StylePriority.UseTextAlignment = false;
            this.xrLabelMaHoaDon.Text = "HĐ: 01";
            this.xrLabelMaHoaDon.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabelNgay
            // 
            this.xrLabelNgay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabelNgay.LocationFloat = new DevExpress.Utils.PointFloat(0F, 88.00002F);
            this.xrLabelNgay.Name = "xrLabelNgay";
            this.xrLabelNgay.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelNgay.SizeF = new System.Drawing.SizeF(125F, 23F);
            this.xrLabelNgay.StylePriority.UseFont = false;
            this.xrLabelNgay.StylePriority.UseTextAlignment = false;
            this.xrLabelNgay.Text = "Ngày:";
            this.xrLabelNgay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabelBan
            // 
            this.xrLabelBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabelBan.LocationFloat = new DevExpress.Utils.PointFloat(0F, 64.99999F);
            this.xrLabelBan.Name = "xrLabelBan";
            this.xrLabelBan.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelBan.SizeF = new System.Drawing.SizeF(190F, 23F);
            this.xrLabelBan.StylePriority.UseFont = false;
            this.xrLabelBan.StylePriority.UseTextAlignment = false;
            this.xrLabelBan.Text = "HOA DON";
            this.xrLabelBan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(24.58335F, 42.00002F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(139.5833F, 22.99998F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "SĐT: 096 729 45 58";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(2.384186E-05F, 20F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(195F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "409 Nguyễn Tri Phương, Q.10, HCM";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTable
            // 
            this.xrTable.BorderColor = System.Drawing.Color.DimGray;
            this.xrTable.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTable.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable.BorderWidth = 1F;
            this.xrTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 111F);
            this.xrTable.Name = "xrTable";
            this.xrTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable.SizeF = new System.Drawing.SizeF(190F, 25F);
            this.xrTable.StylePriority.UseBorderColor = false;
            this.xrTable.StylePriority.UseBorderDashStyle = false;
            this.xrTable.StylePriority.UseBorders = false;
            this.xrTable.StylePriority.UseBorderWidth = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.TenMatHang,
            this.SoLuong,
            this.Gia,
            this.ThanhTien});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // TenMatHang
            // 
            this.TenMatHang.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TenMatHang.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TenMatHang.Name = "TenMatHang";
            this.TenMatHang.StylePriority.UseBorders = false;
            this.TenMatHang.StylePriority.UseFont = false;
            this.TenMatHang.StylePriority.UseTextAlignment = false;
            this.TenMatHang.Text = "Tên";
            this.TenMatHang.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.TenMatHang.Weight = 0.699999949013659D;
            // 
            // SoLuong
            // 
            this.SoLuong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.StylePriority.UseFont = false;
            this.SoLuong.StylePriority.UseTextAlignment = false;
            this.SoLuong.Text = "SL";
            this.SoLuong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.SoLuong.Weight = 0.17999998695743086D;
            // 
            // Gia
            // 
            this.Gia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Gia.Name = "Gia";
            this.Gia.StylePriority.UseFont = false;
            this.Gia.StylePriority.UseTextAlignment = false;
            this.Gia.Text = "Giá";
            this.Gia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.Gia.Weight = 0.49999998230913756D;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.StylePriority.UseFont = false;
            this.ThanhTien.StylePriority.UseTextAlignment = false;
            this.ThanhTien.Text = "Tổng";
            this.ThanhTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.ThanhTien.Weight = 0.51999996923070357D;
            // 
            // lblTenQuan
            // 
            this.lblTenQuan.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.lblTenQuan.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenQuan.LocationFloat = new DevExpress.Utils.PointFloat(25F, 0F);
            this.lblTenQuan.Name = "lblTenQuan";
            this.lblTenQuan.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTenQuan.SizeF = new System.Drawing.SizeF(138F, 23F);
            this.lblTenQuan.StylePriority.UseBorderDashStyle = false;
            this.lblTenQuan.StylePriority.UseFont = false;
            this.lblTenQuan.StylePriority.UseTextAlignment = false;
            this.lblTenQuan.Text = "TIẾN HẢI QUÁN";
            this.lblTenQuan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // rptHoaDon
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(0, 183, 600, 100);
            this.Version = "15.2";
            this.AfterPrint += new System.EventHandler(this.rptHoaDon_AfterPrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel lblTenQuan;
        private DevExpress.Xpo.XPView xpView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell TenMatHang;
        private DevExpress.XtraReports.UI.XRTableCell SoLuong;
        private DevExpress.XtraReports.UI.XRTableCell Gia;
        public DevExpress.XtraReports.UI.XRTable xrTable;
        private DevExpress.XtraReports.UI.XRTableCell ThanhTien;
        public DevExpress.XtraReports.UI.XRLabel xrLabelBan;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        public DevExpress.XtraReports.UI.XRLabel xrLabelMaHoaDon;
        public DevExpress.XtraReports.UI.XRLabel xrLabelNgay;
        public DevExpress.XtraReports.UI.XRLabel xrLabelTongTienThanhToan;
        public DevExpress.XtraReports.UI.XRLabel xrLabelTongTien;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
    }
}
