namespace QuanBunDauTienHai
{
    partial class FrmChuyenBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChuyenBan));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lookUpBanCoKhach = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpBanTrong = new DevExpress.XtraEditors.LookUpEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnChuyen = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBanCoKhach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBanTrong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(490, 27);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // lookUpBanCoKhach
            // 
            this.lookUpBanCoKhach.Location = new System.Drawing.Point(27, 46);
            this.lookUpBanCoKhach.MenuManager = this.ribbonControl;
            this.lookUpBanCoKhach.Name = "lookUpBanCoKhach";
            this.lookUpBanCoKhach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lookUpBanCoKhach.Properties.Appearance.Options.UseFont = true;
            this.lookUpBanCoKhach.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lookUpBanCoKhach.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpBanCoKhach.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lookUpBanCoKhach.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lookUpBanCoKhach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpBanCoKhach.Size = new System.Drawing.Size(160, 26);
            this.lookUpBanCoKhach.TabIndex = 1;
            // 
            // lookUpBanTrong
            // 
            this.lookUpBanTrong.Location = new System.Drawing.Point(305, 46);
            this.lookUpBanTrong.Name = "lookUpBanTrong";
            this.lookUpBanTrong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lookUpBanTrong.Properties.Appearance.Options.UseFont = true;
            this.lookUpBanTrong.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lookUpBanTrong.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpBanTrong.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lookUpBanTrong.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lookUpBanTrong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpBanTrong.Size = new System.Drawing.Size(160, 26);
            this.lookUpBanTrong.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::QuanBunDauTienHai.Properties.Resources.Fatcow_Farm_Fresh_Arrow_right;
            this.pictureEdit1.Location = new System.Drawing.Point(218, 48);
            this.pictureEdit1.MenuManager = this.ribbonControl;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(57, 24);
            this.pictureEdit1.TabIndex = 2;
            // 
            // btnChuyen
            // 
            this.btnChuyen.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChuyen.Appearance.Options.UseFont = true;
            this.btnChuyen.Location = new System.Drawing.Point(203, 93);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(80, 25);
            this.btnChuyen.TabIndex = 4;
            this.btnChuyen.Text = "Chuyển";
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // FrmChuyenBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 145);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lookUpBanTrong);
            this.Controls.Add(this.lookUpBanCoKhach);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChuyenBan";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển Bàn";
            this.Load += new System.EventHandler(this.FrmChuyenBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBanCoKhach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBanTrong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.LookUpEdit lookUpBanCoKhach;
        private DevExpress.XtraEditors.LookUpEdit lookUpBanTrong;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnChuyen;
    }
}