namespace QuanBunDauTienHai
{
    partial class FrmDSHoaDon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDSHoaDon));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.panelControlHead = new DevExpress.XtraEditors.PanelControl();
            this.btnHomNay = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrv = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpNguoiNV = new DevExpress.XtraEditors.LookUpEdit();
            this.dateTinhTien = new DevExpress.XtraEditors.DateEdit();
            this.lblBanHuy = new DevExpress.XtraEditors.LabelControl();
            this.lblBanTT = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblTienHuy = new DevExpress.XtraEditors.LabelControl();
            this.lblTienThu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControlFill = new DevExpress.XtraEditors.PanelControl();
            this.gridControlHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gridViewHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BanAn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrangHinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PictureEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LyDoHuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiTT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHead)).BeginInit();
            this.panelControlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpNguoiNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTinhTien.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTinhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFill)).BeginInit();
            this.panelControlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ribbonControl.AllowMinimizeRibbon = false;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 1;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowCategoryInCaption = false;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(990, 27);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // panelControlHead
            // 
            this.panelControlHead.Controls.Add(this.btnHomNay);
            this.panelControlHead.Controls.Add(this.btnPrv);
            this.panelControlHead.Controls.Add(this.btnNext);
            this.panelControlHead.Controls.Add(this.btnXem);
            this.panelControlHead.Controls.Add(this.lookUpNguoiNV);
            this.panelControlHead.Controls.Add(this.dateTinhTien);
            this.panelControlHead.Controls.Add(this.lblBanHuy);
            this.panelControlHead.Controls.Add(this.lblBanTT);
            this.panelControlHead.Controls.Add(this.labelControl2);
            this.panelControlHead.Controls.Add(this.lblTienHuy);
            this.panelControlHead.Controls.Add(this.lblTienThu);
            this.panelControlHead.Controls.Add(this.labelControl1);
            this.panelControlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlHead.Location = new System.Drawing.Point(0, 27);
            this.panelControlHead.Name = "panelControlHead";
            this.panelControlHead.Size = new System.Drawing.Size(990, 100);
            this.panelControlHead.TabIndex = 1;
            // 
            // btnHomNay
            // 
            this.btnHomNay.Image = global::QuanBunDauTienHai.Properties.Resources.House;
            this.btnHomNay.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHomNay.Location = new System.Drawing.Point(271, 20);
            this.btnHomNay.Name = "btnHomNay";
            this.btnHomNay.Size = new System.Drawing.Size(60, 59);
            this.btnHomNay.TabIndex = 3;
            this.btnHomNay.Click += new System.EventHandler(this.btnHomNay_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.Image = global::QuanBunDauTienHai.Properties.Resources.Fast_backward;
            this.btnPrv.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrv.Location = new System.Drawing.Point(337, 20);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(60, 59);
            this.btnPrv.TabIndex = 4;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::QuanBunDauTienHai.Properties.Resources.Fast_forward;
            this.btnNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNext.Location = new System.Drawing.Point(403, 20);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 59);
            this.btnNext.TabIndex = 5;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnXem
            // 
            this.btnXem.Image = global::QuanBunDauTienHai.Properties.Resources.Search_red;
            this.btnXem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXem.Location = new System.Drawing.Point(200, 19);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(57, 60);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lookUpNguoiNV
            // 
            this.lookUpNguoiNV.Location = new System.Drawing.Point(32, 57);
            this.lookUpNguoiNV.MenuManager = this.ribbonControl;
            this.lookUpNguoiNV.Name = "lookUpNguoiNV";
            this.lookUpNguoiNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lookUpNguoiNV.Properties.Appearance.Options.UseFont = true;
            this.lookUpNguoiNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpNguoiNV.Size = new System.Drawing.Size(150, 22);
            this.lookUpNguoiNV.TabIndex = 1;
            // 
            // dateTinhTien
            // 
            this.dateTinhTien.EditValue = null;
            this.dateTinhTien.Location = new System.Drawing.Point(32, 17);
            this.dateTinhTien.MenuManager = this.ribbonControl;
            this.dateTinhTien.Name = "dateTinhTien";
            this.dateTinhTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTinhTien.Properties.Appearance.Options.UseFont = true;
            this.dateTinhTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTinhTien.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTinhTien.Size = new System.Drawing.Size(150, 22);
            this.dateTinhTien.TabIndex = 0;
            // 
            // lblBanHuy
            // 
            this.lblBanHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBanHuy.Location = new System.Drawing.Point(924, 57);
            this.lblBanHuy.Name = "lblBanHuy";
            this.lblBanHuy.Size = new System.Drawing.Size(21, 16);
            this.lblBanHuy.TabIndex = 1;
            this.lblBanHuy.Text = "Bàn";
            // 
            // lblBanTT
            // 
            this.lblBanTT.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBanTT.Location = new System.Drawing.Point(924, 22);
            this.lblBanTT.Name = "lblBanTT";
            this.lblBanTT.Size = new System.Drawing.Size(21, 16);
            this.lblBanTT.TabIndex = 1;
            this.lblBanTT.Text = "Bàn";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(714, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tổng tiền hủy:";
            // 
            // lblTienHuy
            // 
            this.lblTienHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTienHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTienHuy.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblTienHuy.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTienHuy.Location = new System.Drawing.Point(816, 55);
            this.lblTienHuy.Name = "lblTienHuy";
            this.lblTienHuy.Size = new System.Drawing.Size(91, 19);
            this.lblTienHuy.TabIndex = 0;
            this.lblTienHuy.Text = "000.000";
            // 
            // lblTienThu
            // 
            this.lblTienThu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTienThu.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTienThu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblTienThu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTienThu.Location = new System.Drawing.Point(816, 20);
            this.lblTienThu.Name = "lblTienThu";
            this.lblTienThu.Size = new System.Drawing.Size(91, 19);
            this.lblTienThu.TabIndex = 0;
            this.lblTienThu.Text = "000.000";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl1.Location = new System.Drawing.Point(714, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tổng tiền thu:";
            // 
            // panelControlFill
            // 
            this.panelControlFill.Controls.Add(this.gridControlHoaDon);
            this.panelControlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlFill.Location = new System.Drawing.Point(0, 127);
            this.panelControlFill.Name = "panelControlFill";
            this.panelControlFill.Size = new System.Drawing.Size(990, 568);
            this.panelControlFill.TabIndex = 2;
            // 
            // gridControlHoaDon
            // 
            this.gridControlHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHoaDon.Location = new System.Drawing.Point(2, 2);
            this.gridControlHoaDon.MainView = this.gridViewHoaDon;
            this.gridControlHoaDon.MenuManager = this.ribbonControl;
            this.gridControlHoaDon.Name = "gridControlHoaDon";
            this.gridControlHoaDon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.PictureEdit});
            this.gridControlHoaDon.Size = new System.Drawing.Size(986, 564);
            this.gridControlHoaDon.TabIndex = 0;
            this.gridControlHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHoaDon});
            // 
            // gridViewHoaDon
            // 
            this.gridViewHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHoaDon,
            this.BanAn,
            this.Ngay,
            this.GioDat,
            this.GioThanhToan,
            this.TongTien,
            this.TinhTrangHinh,
            this.TinhTrang,
            this.LyDoHuy,
            this.NguoiLap,
            this.NguoiTT});
            this.gridViewHoaDon.GridControl = this.gridControlHoaDon;
            this.gridViewHoaDon.Name = "gridViewHoaDon";
            this.gridViewHoaDon.OptionsFind.AlwaysVisible = true;
            this.gridViewHoaDon.OptionsFind.FindNullPrompt = "Nhập thông tin cần tìm";
            this.gridViewHoaDon.DoubleClick += new System.EventHandler(this.gridViewHoaDon_DoubleClick);
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaHoaDon.AppearanceCell.Options.UseFont = true;
            this.MaHoaDon.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaHoaDon.AppearanceHeader.Options.UseFont = true;
            this.MaHoaDon.Caption = "Mã Hóa Đơn";
            this.MaHoaDon.FieldName = "MaHoaDon";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.OptionsColumn.AllowEdit = false;
            this.MaHoaDon.Visible = true;
            this.MaHoaDon.VisibleIndex = 0;
            this.MaHoaDon.Width = 96;
            // 
            // BanAn
            // 
            this.BanAn.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BanAn.AppearanceCell.Options.UseFont = true;
            this.BanAn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BanAn.AppearanceHeader.Options.UseFont = true;
            this.BanAn.Caption = "Bàn Ăn";
            this.BanAn.FieldName = "BanAn";
            this.BanAn.Name = "BanAn";
            this.BanAn.OptionsColumn.AllowEdit = false;
            this.BanAn.Visible = true;
            this.BanAn.VisibleIndex = 1;
            this.BanAn.Width = 96;
            // 
            // Ngay
            // 
            this.Ngay.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Ngay.AppearanceCell.Options.UseFont = true;
            this.Ngay.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Ngay.AppearanceHeader.Options.UseFont = true;
            this.Ngay.Caption = "Ngày ";
            this.Ngay.FieldName = "Ngay";
            this.Ngay.Name = "Ngay";
            this.Ngay.OptionsColumn.AllowEdit = false;
            this.Ngay.Visible = true;
            this.Ngay.VisibleIndex = 2;
            this.Ngay.Width = 96;
            // 
            // GioDat
            // 
            this.GioDat.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GioDat.AppearanceCell.Options.UseFont = true;
            this.GioDat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GioDat.AppearanceHeader.Options.UseFont = true;
            this.GioDat.Caption = "Giờ Đặt";
            this.GioDat.FieldName = "GioDat";
            this.GioDat.Name = "GioDat";
            this.GioDat.OptionsColumn.AllowEdit = false;
            this.GioDat.Visible = true;
            this.GioDat.VisibleIndex = 3;
            this.GioDat.Width = 96;
            // 
            // GioThanhToan
            // 
            this.GioThanhToan.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GioThanhToan.AppearanceCell.Options.UseFont = true;
            this.GioThanhToan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GioThanhToan.AppearanceHeader.Options.UseFont = true;
            this.GioThanhToan.Caption = "Giờ Thanh Toán";
            this.GioThanhToan.FieldName = "GioThanhToan";
            this.GioThanhToan.Name = "GioThanhToan";
            this.GioThanhToan.OptionsColumn.AllowEdit = false;
            this.GioThanhToan.Visible = true;
            this.GioThanhToan.VisibleIndex = 4;
            this.GioThanhToan.Width = 96;
            // 
            // TongTien
            // 
            this.TongTien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TongTien.AppearanceCell.Options.UseFont = true;
            this.TongTien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TongTien.AppearanceHeader.Options.UseFont = true;
            this.TongTien.Caption = "Tổng Tiền";
            this.TongTien.FieldName = "TongTien";
            this.TongTien.Name = "TongTien";
            this.TongTien.OptionsColumn.AllowEdit = false;
            this.TongTien.Visible = true;
            this.TongTien.VisibleIndex = 5;
            this.TongTien.Width = 96;
            // 
            // TinhTrangHinh
            // 
            this.TinhTrangHinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TinhTrangHinh.AppearanceCell.Options.UseFont = true;
            this.TinhTrangHinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TinhTrangHinh.AppearanceHeader.Options.UseFont = true;
            this.TinhTrangHinh.Caption = "Tình Trạng";
            this.TinhTrangHinh.ColumnEdit = this.PictureEdit;
            this.TinhTrangHinh.FieldName = "TinhTrangHinh";
            this.TinhTrangHinh.Name = "TinhTrangHinh";
            this.TinhTrangHinh.OptionsColumn.AllowEdit = false;
            this.TinhTrangHinh.Visible = true;
            this.TinhTrangHinh.VisibleIndex = 6;
            this.TinhTrangHinh.Width = 96;
            // 
            // PictureEdit
            // 
            this.PictureEdit.Name = "PictureEdit";
            // 
            // TinhTrang
            // 
            this.TinhTrang.Caption = "TinhTrang";
            this.TinhTrang.FieldName = "TinhTrang";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.OptionsColumn.AllowEdit = false;
            // 
            // LyDoHuy
            // 
            this.LyDoHuy.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LyDoHuy.AppearanceCell.Options.UseFont = true;
            this.LyDoHuy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LyDoHuy.AppearanceHeader.Options.UseFont = true;
            this.LyDoHuy.Caption = "Lý Do Hủy";
            this.LyDoHuy.FieldName = "LyDoHuy";
            this.LyDoHuy.Name = "LyDoHuy";
            this.LyDoHuy.OptionsColumn.AllowEdit = false;
            this.LyDoHuy.Visible = true;
            this.LyDoHuy.VisibleIndex = 7;
            this.LyDoHuy.Width = 120;
            // 
            // NguoiLap
            // 
            this.NguoiLap.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NguoiLap.AppearanceCell.Options.UseFont = true;
            this.NguoiLap.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NguoiLap.AppearanceHeader.Options.UseFont = true;
            this.NguoiLap.Caption = "Người Lập HD";
            this.NguoiLap.FieldName = "NguoiLap";
            this.NguoiLap.Name = "NguoiLap";
            this.NguoiLap.OptionsColumn.AllowEdit = false;
            this.NguoiLap.Visible = true;
            this.NguoiLap.VisibleIndex = 8;
            this.NguoiLap.Width = 84;
            // 
            // NguoiTT
            // 
            this.NguoiTT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NguoiTT.AppearanceCell.Options.UseFont = true;
            this.NguoiTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NguoiTT.AppearanceHeader.Options.UseFont = true;
            this.NguoiTT.Caption = "Người Kết Thúc HD";
            this.NguoiTT.FieldName = "NguoiTT";
            this.NguoiTT.Name = "NguoiTT";
            this.NguoiTT.OptionsColumn.AllowEdit = false;
            this.NguoiTT.Visible = true;
            this.NguoiTT.VisibleIndex = 9;
            this.NguoiTT.Width = 92;
            // 
            // FrmDSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 695);
            this.Controls.Add(this.panelControlFill);
            this.Controls.Add(this.panelControlHead);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDSHoaDon";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hóa đơn theo ngày";
            this.Load += new System.EventHandler(this.FrmDSHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHead)).EndInit();
            this.panelControlHead.ResumeLayout(false);
            this.panelControlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpNguoiNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTinhTien.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTinhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFill)).EndInit();
            this.panelControlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.PanelControl panelControlHead;
        private DevExpress.XtraEditors.PanelControl panelControlFill;
        private DevExpress.XtraGrid.GridControl gridControlHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn MaHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn BanAn;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn GioDat;
        private DevExpress.XtraGrid.Columns.GridColumn GioThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn TongTien;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrangHinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit PictureEdit;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn LyDoHuy;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiLap;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiTT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblTienHuy;
        private DevExpress.XtraEditors.LabelControl lblTienThu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblBanHuy;
        private DevExpress.XtraEditors.LabelControl lblBanTT;
        private DevExpress.XtraEditors.DateEdit dateTinhTien;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.LookUpEdit lookUpNguoiNV;
        private DevExpress.XtraEditors.SimpleButton btnPrv;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnHomNay;
    }
}