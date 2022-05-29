
namespace QLDSVHTC
{
    partial class FormLTC
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
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label hUYLOPLabel;
            System.Windows.Forms.Label sOSVTOITHIEULabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLTC));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS_SV1 = new QLDSVHTC.DS_SV1();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bdsLopTinChi = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTINCHITableAdapter = new QLDSVHTC.DS_SV1TableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new QLDSVHTC.DS_SV1TableAdapters.TableAdapterManager();
            this.DANGKYTableAdapter = new QLDSVHTC.DS_SV1TableAdapters.DANGKYTableAdapter();
            this.MONHOCTableAdapter = new QLDSVHTC.DS_SV1TableAdapters.MONHOCTableAdapter();
            this.lOPTINCHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDangKi = new System.Windows.Forms.BindingSource(this.components);
            this.txbNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txbMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.speHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.speSoSVToiThieu = new DevExpress.XtraEditors.SpinEdit();
            this.txbMaMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.txbMaGiangVien = new DevExpress.XtraEditors.TextEdit();
            this.speNhom = new DevExpress.XtraEditors.SpinEdit();
            this.hUYLOPCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            nHOMLabel = new System.Windows.Forms.Label();
            hUYLOPLabel = new System.Windows.Forms.Label();
            sOSVTOITHIEULabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speSoSVToiThieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaGiangVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hUYLOPCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(578, 71);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(45, 17);
            nHOMLabel.TabIndex = 40;
            nHOMLabel.Text = "Nhóm";
            // 
            // hUYLOPLabel
            // 
            hUYLOPLabel.AutoSize = true;
            hUYLOPLabel.Location = new System.Drawing.Point(575, 200);
            hUYLOPLabel.Name = "hUYLOPLabel";
            hUYLOPLabel.Size = new System.Drawing.Size(55, 17);
            hUYLOPLabel.TabIndex = 38;
            hUYLOPLabel.Text = "Hủy lớp";
            // 
            // sOSVTOITHIEULabel
            // 
            sOSVTOITHIEULabel.AutoSize = true;
            sOSVTOITHIEULabel.Location = new System.Drawing.Point(256, 201);
            sOSVTOITHIEULabel.Name = "sOSVTOITHIEULabel";
            sOSVTOITHIEULabel.Size = new System.Drawing.Size(95, 17);
            sOSVTOITHIEULabel.TabIndex = 36;
            sOSVTOITHIEULabel.Text = "Số sv tối thiểu";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(257, 33);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(59, 17);
            mAKHOALabel.TabIndex = 34;
            mAKHOALabel.Text = "Mã khoa";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(256, 154);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(97, 17);
            tENLabel.TabIndex = 32;
            tENLabel.Text = "Tên giảng viên";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(576, 159);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(91, 17);
            mAGVLabel.TabIndex = 30;
            mAGVLabel.Text = "Mã giảng viên";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(256, 110);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(90, 17);
            tENMHLabel.TabIndex = 29;
            tENMHLabel.Text = "Tên môn học";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(576, 113);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(84, 17);
            mAMHLabel.TabIndex = 27;
            mAMHLabel.Text = "Mã môn học";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(256, 72);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(51, 17);
            hOCKYLabel.TabIndex = 25;
            hOCKYLabel.Text = "Học kỳ";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(576, 34);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(68, 17);
            nIENKHOALabel.TabIndex = 23;
            nIENKHOALabel.Text = "Niên khóa";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnPhucHoi,
            this.btnGhi,
            this.btnHuy,
            this.btnLamMoi,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 6;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1363, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1029);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1363, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 978);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1363, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 978);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1363, 63);
            this.panelControl1.TabIndex = 6;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(512, 19);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(271, 24);
            this.cbKhoa.TabIndex = 1;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA";
            // 
            // dS_SV1
            // 
            this.dS_SV1.DataSetName = "DS_SV1";
            this.dS_SV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.hUYLOPCheckEdit);
            this.panelControl2.Controls.Add(this.speNhom);
            this.panelControl2.Controls.Add(this.txbMaGiangVien);
            this.panelControl2.Controls.Add(this.txbMaMonHoc);
            this.panelControl2.Controls.Add(this.speSoSVToiThieu);
            this.panelControl2.Controls.Add(this.speHocKy);
            this.panelControl2.Controls.Add(this.txbMaKhoa);
            this.panelControl2.Controls.Add(this.txbNienKhoa);
            this.panelControl2.Controls.Add(this.button2);
            this.panelControl2.Controls.Add(this.button1);
            this.panelControl2.Controls.Add(nIENKHOALabel);
            this.panelControl2.Controls.Add(nHOMLabel);
            this.panelControl2.Controls.Add(hOCKYLabel);
            this.panelControl2.Controls.Add(hUYLOPLabel);
            this.panelControl2.Controls.Add(mAMHLabel);
            this.panelControl2.Controls.Add(sOSVTOITHIEULabel);
            this.panelControl2.Controls.Add(tENMHLabel);
            this.panelControl2.Controls.Add(mAKHOALabel);
            this.panelControl2.Controls.Add(mAGVLabel);
            this.panelControl2.Controls.Add(tENLabel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 448);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1363, 581);
            this.panelControl2.TabIndex = 43;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 30);
            this.button2.TabIndex = 43;
            this.button2.Text = "Chọn Giảng Viên";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 33);
            this.button1.TabIndex = 42;
            this.button1.Text = "Chọn Môn Học";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bdsLopTinChi
            // 
            this.bdsLopTinChi.DataMember = "LOPTINCHI";
            this.bdsLopTinChi.DataSource = this.dS_SV1;
            // 
            // LOPTINCHITableAdapter
            // 
            this.LOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = this.DANGKYTableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.LOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.MONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSVHTC.DS_SV1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DANGKYTableAdapter
            // 
            this.DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTINCHIGridControl
            // 
            this.lOPTINCHIGridControl.DataSource = this.bdsLopTinChi;
            this.lOPTINCHIGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lOPTINCHIGridControl.Location = new System.Drawing.Point(0, 114);
            this.lOPTINCHIGridControl.MainView = this.gridView1;
            this.lOPTINCHIGridControl.MenuManager = this.barManager1;
            this.lOPTINCHIGridControl.Name = "lOPTINCHIGridControl";
            this.lOPTINCHIGridControl.Size = new System.Drawing.Size(1363, 334);
            this.lOPTINCHIGridControl.TabIndex = 44;
            this.lOPTINCHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colMAMH,
            this.colNHOM,
            this.colMAGV,
            this.colMAKHOA,
            this.colSOSVTOITHIEU,
            this.colHUYLOP});
            this.gridView1.GridControl = this.lOPTINCHIGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMALTC
            // 
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 25;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 94;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 1;
            this.colNIENKHOA.Width = 94;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 2;
            this.colHOCKY.Width = 94;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 3;
            this.colMAMH.Width = 94;
            // 
            // colNHOM
            // 
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 4;
            this.colNHOM.Width = 94;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 5;
            this.colMAGV.Width = 94;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 25;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 6;
            this.colMAKHOA.Width = 94;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.MinWidth = 25;
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 7;
            this.colSOSVTOITHIEU.Width = 94;
            // 
            // colHUYLOP
            // 
            this.colHUYLOP.FieldName = "HUYLOP";
            this.colHUYLOP.MinWidth = 25;
            this.colHUYLOP.Name = "colHUYLOP";
            this.colHUYLOP.Visible = true;
            this.colHUYLOP.VisibleIndex = 8;
            this.colHUYLOP.Width = 94;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS_SV1;
            // 
            // bdsDangKi
            // 
            this.bdsDangKi.DataMember = "FK_DANGKY_LOPTINCHI";
            this.bdsDangKi.DataSource = this.bdsLopTinChi;
            // 
            // txbNienKhoa
            // 
            this.txbNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "NIENKHOA", true));
            this.txbNienKhoa.Location = new System.Drawing.Point(694, 28);
            this.txbNienKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txbNienKhoa.MenuManager = this.barManager1;
            this.txbNienKhoa.Name = "txbNienKhoa";
            this.txbNienKhoa.Size = new System.Drawing.Size(248, 22);
            this.txbNienKhoa.TabIndex = 44;
            // 
            // txbMaKhoa
            // 
            this.txbMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "MAKHOA", true));
            this.txbMaKhoa.Location = new System.Drawing.Point(359, 28);
            this.txbMaKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaKhoa.MenuManager = this.barManager1;
            this.txbMaKhoa.Name = "txbMaKhoa";
            this.txbMaKhoa.Properties.ReadOnly = true;
            this.txbMaKhoa.Size = new System.Drawing.Size(178, 22);
            this.txbMaKhoa.TabIndex = 45;
            // 
            // speHocKy
            // 
            this.speHocKy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "HOCKY", true));
            this.speHocKy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speHocKy.Location = new System.Drawing.Point(359, 68);
            this.speHocKy.Margin = new System.Windows.Forms.Padding(4);
            this.speHocKy.MenuManager = this.barManager1;
            this.speHocKy.Name = "speHocKy";
            this.speHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speHocKy.Size = new System.Drawing.Size(178, 24);
            this.speHocKy.TabIndex = 46;
            // 
            // speSoSVToiThieu
            // 
            this.speSoSVToiThieu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "SOSVTOITHIEU", true));
            this.speSoSVToiThieu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speSoSVToiThieu.Location = new System.Drawing.Point(359, 197);
            this.speSoSVToiThieu.Margin = new System.Windows.Forms.Padding(4);
            this.speSoSVToiThieu.MenuManager = this.barManager1;
            this.speSoSVToiThieu.Name = "speSoSVToiThieu";
            this.speSoSVToiThieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speSoSVToiThieu.Size = new System.Drawing.Size(178, 24);
            this.speSoSVToiThieu.TabIndex = 47;
            // 
            // txbMaMonHoc
            // 
            this.txbMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "MAMH", true));
            this.txbMaMonHoc.Location = new System.Drawing.Point(696, 113);
            this.txbMaMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaMonHoc.MenuManager = this.barManager1;
            this.txbMaMonHoc.Name = "txbMaMonHoc";
            this.txbMaMonHoc.Properties.ReadOnly = true;
            this.txbMaMonHoc.Size = new System.Drawing.Size(246, 22);
            this.txbMaMonHoc.TabIndex = 48;
            // 
            // txbMaGiangVien
            // 
            this.txbMaGiangVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "MAGV", true));
            this.txbMaGiangVien.Location = new System.Drawing.Point(694, 168);
            this.txbMaGiangVien.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaGiangVien.MenuManager = this.barManager1;
            this.txbMaGiangVien.Name = "txbMaGiangVien";
            this.txbMaGiangVien.Properties.ReadOnly = true;
            this.txbMaGiangVien.Size = new System.Drawing.Size(246, 22);
            this.txbMaGiangVien.TabIndex = 49;
            // 
            // speNhom
            // 
            this.speNhom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "NHOM", true));
            this.speNhom.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speNhom.Location = new System.Drawing.Point(694, 68);
            this.speNhom.Margin = new System.Windows.Forms.Padding(4);
            this.speNhom.MenuManager = this.barManager1;
            this.speNhom.Name = "speNhom";
            this.speNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speNhom.Size = new System.Drawing.Size(246, 24);
            this.speNhom.TabIndex = 50;
            // 
            // hUYLOPCheckEdit
            // 
            this.hUYLOPCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTinChi, "HUYLOP", true));
            this.hUYLOPCheckEdit.Location = new System.Drawing.Point(694, 211);
            this.hUYLOPCheckEdit.Margin = new System.Windows.Forms.Padding(4);
            this.hUYLOPCheckEdit.MenuManager = this.barManager1;
            this.hUYLOPCheckEdit.Name = "hUYLOPCheckEdit";
            this.hUYLOPCheckEdit.Properties.Caption = "";
            this.hUYLOPCheckEdit.Size = new System.Drawing.Size(118, 24);
            this.hUYLOPCheckEdit.TabIndex = 51;
            // 
            // FormLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1384, 779);
            this.Controls.Add(this.lOPTINCHIGridControl);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormLTC";
            this.Text = "Lớp Tín Chỉ";
            this.Load += new System.EventHandler(this.FormLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speSoSVToiThieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaGiangVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hUYLOPCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DS_SV1 dS_SV1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsLopTinChi;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DS_SV1TableAdapters.LOPTINCHITableAdapter LOPTINCHITableAdapter;
        private DS_SV1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOPTINCHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYLOP;
        private DS_SV1TableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DS_SV1TableAdapters.DANGKYTableAdapter DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsDangKi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit txbNienKhoa;
        private DevExpress.XtraEditors.TextEdit txbMaGiangVien;
        private DevExpress.XtraEditors.TextEdit txbMaMonHoc;
        private DevExpress.XtraEditors.SpinEdit speSoSVToiThieu;
        private DevExpress.XtraEditors.SpinEdit speHocKy;
        private DevExpress.XtraEditors.TextEdit txbMaKhoa;
        private DevExpress.XtraEditors.SpinEdit speNhom;
        private DevExpress.XtraEditors.CheckEdit hUYLOPCheckEdit;
    }
}