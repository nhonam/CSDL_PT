
namespace QLDSVHTC
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSINHVIEN = new DevExpress.XtraBars.BarButtonItem();
            this.btnLOPHOC = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.BTNTTK = new DevExpress.XtraBars.BarButtonItem();
            this.BTNTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnDIEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.rpNHAPXUAT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpBAOCAO = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpHETHONG = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DiemButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnSINHVIEN,
            this.btnLOPHOC,
            this.btnDangNhap,
            this.BTNTTK,
            this.BTNTHOAT,
            this.btnLogout,
            this.btnDIEM,
            this.btnDangKi,
            this.barButtonItem3,
            this.barButtonItem1,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpNHAPXUAT,
            this.rpBAOCAO,
            this.rpHETHONG});
            this.ribbonControl1.Size = new System.Drawing.Size(1213, 183);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnSINHVIEN
            // 
            this.btnSINHVIEN.Caption = "SINH VIEN";
            this.btnSINHVIEN.Id = 1;
            this.btnSINHVIEN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSINHVIEN.ImageOptions.Image")));
            this.btnSINHVIEN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSINHVIEN.ImageOptions.LargeImage")));
            this.btnSINHVIEN.Name = "btnSINHVIEN";
            this.btnSINHVIEN.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSINHVIEN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSINHVIEN_ItemClick);
            // 
            // btnLOPHOC
            // 
            this.btnLOPHOC.Caption = "LOP HOC";
            this.btnLOPHOC.Id = 2;
            this.btnLOPHOC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLOPHOC.ImageOptions.Image")));
            this.btnLOPHOC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLOPHOC.ImageOptions.LargeImage")));
            this.btnLOPHOC.Name = "btnLOPHOC";
            this.btnLOPHOC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLOPHOC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLOPHOC_ItemClick);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "DANG NHAP";
            this.btnDangNhap.Id = 3;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.LargeImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // BTNTTK
            // 
            this.BTNTTK.Caption = "TAO TAI KHOAN";
            this.BTNTTK.Id = 4;
            this.BTNTTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNTTK.ImageOptions.Image")));
            this.BTNTTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNTTK.ImageOptions.LargeImage")));
            this.BTNTTK.Name = "BTNTTK";
            this.BTNTTK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BTNTTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BTNTTK_ItemClick);
            // 
            // BTNTHOAT
            // 
            this.BTNTHOAT.Caption = "THOAT";
            this.BTNTHOAT.Id = 5;
            this.BTNTHOAT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNTHOAT.ImageOptions.Image")));
            this.BTNTHOAT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNTHOAT.ImageOptions.LargeImage")));
            this.BTNTHOAT.Name = "BTNTHOAT";
            this.BTNTHOAT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "DANG XUAT";
            this.btnLogout.Id = 6;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.LargeImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnDIEM
            // 
            this.btnDIEM.Caption = "DIEM";
            this.btnDIEM.Id = 7;
            this.btnDIEM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDIEM.ImageOptions.Image")));
            this.btnDIEM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDIEM.ImageOptions.LargeImage")));
            this.btnDIEM.Name = "btnDIEM";
            this.btnDIEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDIEM_ItemClick_1);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Caption = "DANGKI";
            this.btnDangKi.Id = 8;
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangKi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 9;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "MON HOC";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // rpNHAPXUAT
            // 
            this.rpNHAPXUAT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rpNHAPXUAT.Name = "rpNHAPXUAT";
            this.rpNHAPXUAT.Text = "NHAP XUAT";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSINHVIEN);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLOPHOC);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDIEM);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDangKi);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "QUAN LY";
            // 
            // rpBAOCAO
            // 
            this.rpBAOCAO.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rpBAOCAO.Name = "rpBAOCAO";
            this.rpBAOCAO.Text = "BAO CAO";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // rpHETHONG
            // 
            this.rpHETHONG.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpHETHONG.Name = "rpHETHONG";
            this.rpHETHONG.Text = "HE THONG";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNTTK);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNTHOAT);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "HE THONG";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 690);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1213, 33);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAGV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1213, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MAGV
            // 
            this.MAGV.Name = "MAGV";
            this.MAGV.Size = new System.Drawing.Size(51, 20);
            this.MAGV.Text = "MAGV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(57, 20);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(55, 20);
            this.NHOM.Text = "NHOM";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSINHVIEN);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLOPHOC);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "QUAN LY";
            // 
            // DiemButtonItem
            // 
            this.DiemButtonItem.Name = "DiemButtonItem";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "LOP TIN CHI";
            this.barButtonItem4.Id = 11;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 723);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnSINHVIEN;
        private DevExpress.XtraBars.BarButtonItem btnLOPHOC;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHETHONG;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpBAOCAO;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpNHAPXUAT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem BTNTTK;
        private DevExpress.XtraBars.BarButtonItem BTNTHOAT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        public System.Windows.Forms.ToolStripStatusLabel MAGV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btnDIEM;
        private DevExpress.XtraBars.BarButtonItem DiemButtonItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnDangKi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    }
}

