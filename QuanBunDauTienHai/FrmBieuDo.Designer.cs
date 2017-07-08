namespace QuanBunDauTienHai
{
    partial class FrmBieuDo
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBieuDo));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.panelControlHead = new DevExpress.XtraEditors.PanelControl();
            this.radioButtonDuong = new System.Windows.Forms.RadioButton();
            this.radioButtonCot = new System.Windows.Forms.RadioButton();
            this.btnNam = new DevExpress.XtraEditors.SimpleButton();
            this.btnThang = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblTieuDe = new DevExpress.XtraEditors.LabelControl();
            this.txtThang = new DevExpress.XtraEditors.SpinEdit();
            this.txtNam = new DevExpress.XtraEditors.SpinEdit();
            this.panelControlBieuDo = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chartControlThu = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHead)).BeginInit();
            this.panelControlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBieuDo)).BeginInit();
            this.panelControlBieuDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
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
            this.panelControlHead.Controls.Add(this.radioButtonDuong);
            this.panelControlHead.Controls.Add(this.radioButtonCot);
            this.panelControlHead.Controls.Add(this.btnNam);
            this.panelControlHead.Controls.Add(this.btnThang);
            this.panelControlHead.Controls.Add(this.labelControl3);
            this.panelControlHead.Controls.Add(this.labelControl2);
            this.panelControlHead.Controls.Add(this.lblTieuDe);
            this.panelControlHead.Controls.Add(this.txtThang);
            this.panelControlHead.Controls.Add(this.txtNam);
            this.panelControlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlHead.Location = new System.Drawing.Point(0, 27);
            this.panelControlHead.Name = "panelControlHead";
            this.panelControlHead.Size = new System.Drawing.Size(990, 100);
            this.panelControlHead.TabIndex = 1;
            // 
            // radioButtonDuong
            // 
            this.radioButtonDuong.AutoSize = true;
            this.radioButtonDuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButtonDuong.Location = new System.Drawing.Point(800, 55);
            this.radioButtonDuong.Name = "radioButtonDuong";
            this.radioButtonDuong.Size = new System.Drawing.Size(108, 20);
            this.radioButtonDuong.TabIndex = 5;
            this.radioButtonDuong.TabStop = true;
            this.radioButtonDuong.Text = "Biểu đồ đường";
            this.radioButtonDuong.UseVisualStyleBackColor = true;
            this.radioButtonDuong.CheckedChanged += new System.EventHandler(this.radioButtonDuong_CheckedChanged);
            // 
            // radioButtonCot
            // 
            this.radioButtonCot.AutoSize = true;
            this.radioButtonCot.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButtonCot.Location = new System.Drawing.Point(800, 24);
            this.radioButtonCot.Name = "radioButtonCot";
            this.radioButtonCot.Size = new System.Drawing.Size(89, 20);
            this.radioButtonCot.TabIndex = 4;
            this.radioButtonCot.TabStop = true;
            this.radioButtonCot.Text = "Biểu đồ cột";
            this.radioButtonCot.UseVisualStyleBackColor = true;
            this.radioButtonCot.CheckedChanged += new System.EventHandler(this.radioButtonCot_CheckedChanged);
            // 
            // btnNam
            // 
            this.btnNam.Image = global::QuanBunDauTienHai.Properties.Resources.Calendar_year;
            this.btnNam.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnNam.Location = new System.Drawing.Point(284, 25);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(64, 55);
            this.btnNam.TabIndex = 3;
            this.btnNam.Text = "Năm";
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnThang
            // 
            this.btnThang.Image = global::QuanBunDauTienHai.Properties.Resources.Calender_month;
            this.btnThang.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThang.Location = new System.Drawing.Point(205, 25);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(64, 55);
            this.btnThang.TabIndex = 2;
            this.btnThang.Text = "Tháng";
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Location = new System.Drawing.Point(26, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Năm:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Location = new System.Drawing.Point(26, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tháng:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.lblTieuDe.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTieuDe.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTieuDe.Location = new System.Drawing.Point(371, 33);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(250, 36);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Tháng 3 Năm 2016";
            // 
            // txtThang
            // 
            this.txtThang.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtThang.Location = new System.Drawing.Point(89, 24);
            this.txtThang.MenuManager = this.ribbonControl;
            this.txtThang.Name = "txtThang";
            this.txtThang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThang.Properties.Appearance.Options.UseFont = true;
            this.txtThang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtThang.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtThang.Properties.Mask.EditMask = "(0?[1-9]|1[012])";
            this.txtThang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtThang.Size = new System.Drawing.Size(100, 22);
            this.txtThang.TabIndex = 0;
            // 
            // txtNam
            // 
            this.txtNam.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNam.Location = new System.Drawing.Point(89, 58);
            this.txtNam.Name = "txtNam";
            this.txtNam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNam.Properties.Appearance.Options.UseFont = true;
            this.txtNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNam.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtNam.Properties.Mask.EditMask = "([123][0-9])?[0-9][0-9]";
            this.txtNam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNam.Size = new System.Drawing.Size(100, 22);
            this.txtNam.TabIndex = 1;
            // 
            // panelControlBieuDo
            // 
            this.panelControlBieuDo.Controls.Add(this.labelControl1);
            this.panelControlBieuDo.Controls.Add(this.chartControlThu);
            this.panelControlBieuDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlBieuDo.Location = new System.Drawing.Point(0, 127);
            this.panelControlBieuDo.Name = "panelControlBieuDo";
            this.panelControlBieuDo.Size = new System.Drawing.Size(990, 568);
            this.panelControlBieuDo.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl1.Location = new System.Drawing.Point(423, 523);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(142, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Biểu đồ tổng tiền";
            // 
            // chartControlThu
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlThu.Diagram = xyDiagram1;
            this.chartControlThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartControlThu.Location = new System.Drawing.Point(2, 2);
            this.chartControlThu.Name = "chartControlThu";
            series1.Name = "Series 1";
            this.chartControlThu.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlThu.Size = new System.Drawing.Size(986, 500);
            this.chartControlThu.TabIndex = 0;
            // 
            // FrmBieuDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 695);
            this.Controls.Add(this.panelControlBieuDo);
            this.Controls.Add(this.panelControlHead);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBieuDo";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biểu Đồ Thu Nhập";
            this.Load += new System.EventHandler(this.FrmBieuDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHead)).EndInit();
            this.panelControlHead.ResumeLayout(false);
            this.panelControlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBieuDo)).EndInit();
            this.panelControlBieuDo.ResumeLayout(false);
            this.panelControlBieuDo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraEditors.PanelControl panelControlHead;
        private DevExpress.XtraEditors.PanelControl panelControlBieuDo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraCharts.ChartControl chartControlThu;
        private DevExpress.XtraEditors.LabelControl lblTieuDe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnNam;
        private DevExpress.XtraEditors.SimpleButton btnThang;
        private System.Windows.Forms.RadioButton radioButtonDuong;
        private System.Windows.Forms.RadioButton radioButtonCot;
        private DevExpress.XtraEditors.SpinEdit txtThang;
        private DevExpress.XtraEditors.SpinEdit txtNam;
    }
}