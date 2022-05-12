
namespace QLDSVHTC
{
    partial class FormSV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSV));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.Them = new DevExpress.XtraBars.BarButtonItem();
            this.Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.Sua = new DevExpress.XtraBars.BarButtonItem();
            this.PhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.Ghi = new DevExpress.XtraBars.BarButtonItem();
            this.Huy = new DevExpress.XtraBars.BarButtonItem();
            this.LamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.dS_SV1 = new QLDSVHTC.DS_SV1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOAHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOPTableAdapter = new QLDSVHTC.DS_SV1TableAdapters.LOPTableAdapter();
            this.bdsVS = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPASSWORD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SINHVIENTableAdapter = new QLDSVHTC.DS_SV1TableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSVHTC.DS_SV1TableAdapters.TableAdapterManager();
            this.bdsDANGKY = new System.Windows.Forms.BindingSource(this.components);
            this.DANGKYTableAdapter = new QLDSVHTC.DS_SV1TableAdapters.DANGKYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDANGKY)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Them,
            this.barCheckItem1,
            this.Xoa,
            this.Sua,
            this.PhucHoi,
            this.Ghi,
            this.Huy,
            this.LamMoi,
            this.Thoat});
            this.barManager1.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.Sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.PhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.Ghi),
            new DevExpress.XtraBars.LinkPersistInfo(this.Huy),
            new DevExpress.XtraBars.LinkPersistInfo(this.LamMoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.Thoat)});
            this.bar1.Text = "Tools";
            // 
            // Them
            // 
            this.Them.Caption = "Them";
            this.Them.Id = 0;
            this.Them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Them.ImageOptions.Image")));
            this.Them.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Them.ImageOptions.LargeImage")));
            this.Them.Name = "Them";
            this.Them.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // Xoa
            // 
            this.Xoa.Caption = "Xoa";
            this.Xoa.Id = 2;
            this.Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Xoa.ImageOptions.Image")));
            this.Xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Xoa.ImageOptions.LargeImage")));
            this.Xoa.Name = "Xoa";
            this.Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // Sua
            // 
            this.Sua.Caption = "Sua";
            this.Sua.Id = 3;
            this.Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Sua.ImageOptions.Image")));
            this.Sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Sua.ImageOptions.LargeImage")));
            this.Sua.Name = "Sua";
            this.Sua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // PhucHoi
            // 
            this.PhucHoi.Caption = "Phuc Hoi";
            this.PhucHoi.Id = 4;
            this.PhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PhucHoi.ImageOptions.Image")));
            this.PhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("PhucHoi.ImageOptions.LargeImage")));
            this.PhucHoi.Name = "PhucHoi";
            this.PhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // Ghi
            // 
            this.Ghi.Caption = "Ghi";
            this.Ghi.Id = 5;
            this.Ghi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Ghi.ImageOptions.Image")));
            this.Ghi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Ghi.ImageOptions.LargeImage")));
            this.Ghi.Name = "Ghi";
            this.Ghi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // Huy
            // 
            this.Huy.Caption = "Huy";
            this.Huy.Id = 6;
            this.Huy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Huy.ImageOptions.Image")));
            this.Huy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Huy.ImageOptions.LargeImage")));
            this.Huy.Name = "Huy";
            this.Huy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // LamMoi
            // 
            this.LamMoi.Caption = "Lam Moi";
            this.LamMoi.Id = 7;
            this.LamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LamMoi.ImageOptions.Image")));
            this.LamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("LamMoi.ImageOptions.LargeImage")));
            this.LamMoi.Name = "LamMoi";
            this.LamMoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // Thoat
            // 
            this.Thoat.Caption = "Thoat";
            this.Thoat.Id = 8;
            this.Thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Thoat.ImageOptions.Image")));
            this.Thoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Thoat.ImageOptions.LargeImage")));
            this.Thoat.Name = "Thoat";
            this.Thoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Thoat_ItemClick_1);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(940, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 495);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(940, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 471);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(940, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 471);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 1;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(940, 69);
            this.panelControl1.TabIndex = 4;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(175, 20);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(293, 21);
            this.cmbKhoa.TabIndex = 7;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "KHOA : ";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsLOP;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.gridControl1.Location = new System.Drawing.Point(0, 93);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(940, 225);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.dS_SV1;
            // 
            // dS_SV1
            // 
            this.dS_SV1.DataSetName = "DS_SV1";
            this.dS_SV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP1,
            this.colTENLOP,
            this.colKHOAHOC,
            this.colMAKHOA});
            this.gridView1.DetailHeight = 1081;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP1
            // 
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.MinWidth = 19;
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 0;
            this.colMALOP1.Width = 70;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 19;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 70;
            // 
            // colKHOAHOC
            // 
            this.colKHOAHOC.FieldName = "KHOAHOC";
            this.colKHOAHOC.MinWidth = 19;
            this.colKHOAHOC.Name = "colKHOAHOC";
            this.colKHOAHOC.Visible = true;
            this.colKHOAHOC.VisibleIndex = 2;
            this.colKHOAHOC.Width = 70;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 19;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            this.colMAKHOA.Width = 70;
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // bdsVS
            // 
            this.bdsVS.DataMember = "SINHVIEN";
            this.bdsVS.DataSource = this.dS_SV1;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.gridControl2.Location = new System.Drawing.Point(396, 318);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.gridControl2.MenuManager = this.barManager1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(544, 177);
            this.gridControl2.TabIndex = 11;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colMALOP,
            this.colDANGHIHOC,
            this.colPASSWORD});
            this.gridView2.DetailHeight = 1081;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 57;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 213;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 57;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 213;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 57;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 213;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 57;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 213;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 57;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 213;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 57;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 213;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 57;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 6;
            this.colMALOP.Width = 213;
            // 
            // colDANGHIHOC
            // 
            this.colDANGHIHOC.FieldName = "DANGHIHOC";
            this.colDANGHIHOC.MinWidth = 57;
            this.colDANGHIHOC.Name = "colDANGHIHOC";
            this.colDANGHIHOC.Visible = true;
            this.colDANGHIHOC.VisibleIndex = 7;
            this.colDANGHIHOC.Width = 213;
            // 
            // colPASSWORD
            // 
            this.colPASSWORD.FieldName = "PASSWORD";
            this.colPASSWORD.MinWidth = 57;
            this.colPASSWORD.Name = "colPASSWORD";
            this.colPASSWORD.Visible = true;
            this.colPASSWORD.VisibleIndex = 8;
            this.colPASSWORD.Width = 213;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.LOPTableAdapter;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.SINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSVHTC.DS_SV1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsDANGKY
            // 
            this.bdsDANGKY.DataMember = "DANGKY";
            this.bdsDANGKY.DataSource = this.dS_SV1;
            // 
            // DANGKYTableAdapter
            // 
            this.DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // FormSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 495);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSV";
            this.Text = " SINH VIEN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDANGKY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem Them;
        private DevExpress.XtraBars.BarButtonItem Xoa;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraBars.BarButtonItem Sua;
        private DevExpress.XtraBars.BarButtonItem PhucHoi;
        private DevExpress.XtraBars.BarButtonItem Ghi;
        private DevExpress.XtraBars.BarButtonItem Huy;
        private DevExpress.XtraBars.BarButtonItem LamMoi;
        private DevExpress.XtraBars.BarButtonItem Thoat;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DS_SV1 dS_SV1;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DS_SV1TableAdapters.LOPTableAdapter LOPTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource bdsVS;
        private DS_SV1TableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private DS_SV1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colDANGHIHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colPASSWORD;
        private System.Windows.Forms.BindingSource bdsDANGKY;
        private DS_SV1TableAdapters.DANGKYTableAdapter DANGKYTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
    }
}