
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
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.BTNDN = new DevExpress.XtraBars.BarButtonItem();
            this.BTNTTK = new DevExpress.XtraBars.BarButtonItem();
            this.BTNTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.BTNDANGXUAT = new DevExpress.XtraBars.BarButtonItem();
            this.BTNNHAPXUAT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BTNBAOCAO = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.barButtonItem2,
            this.BTNDN,
            this.BTNTTK,
            this.BTNTHOAT,
            this.BTNDANGXUAT});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.BTNNHAPXUAT,
            this.BTNBAOCAO,
            this.ribbonPage1});
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
            this.btnSINHVIEN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "LOP HOC";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // BTNDN
            // 
            this.BTNDN.Caption = "DANG NHAP";
            this.BTNDN.Id = 3;
            this.BTNDN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNDN.ImageOptions.Image")));
            this.BTNDN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNDN.ImageOptions.LargeImage")));
            this.BTNDN.Name = "BTNDN";
            this.BTNDN.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BTNDN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // BTNTTK
            // 
            this.BTNTTK.Caption = "TAO TAI KHOAN";
            this.BTNTTK.Id = 4;
            this.BTNTTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNTTK.ImageOptions.Image")));
            this.BTNTTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNTTK.ImageOptions.LargeImage")));
            this.BTNTTK.Name = "BTNTTK";
            this.BTNTTK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // BTNTHOAT
            // 
            this.BTNTHOAT.Caption = "THOAT";
            this.BTNTHOAT.Id = 5;
            this.BTNTHOAT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNTHOAT.ImageOptions.Image")));
            this.BTNTHOAT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNTHOAT.ImageOptions.LargeImage")));
            this.BTNTHOAT.Name = "BTNTHOAT";
            this.BTNTHOAT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BTNTHOAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BTNTHOAT_ItemClick_1);
            // 
            // BTNDANGXUAT
            // 
            this.BTNDANGXUAT.Caption = "DANG XUAT";
            this.BTNDANGXUAT.Id = 6;
            this.BTNDANGXUAT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNDANGXUAT.ImageOptions.Image")));
            this.BTNDANGXUAT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNDANGXUAT.ImageOptions.LargeImage")));
            this.BTNDANGXUAT.Name = "BTNDANGXUAT";
            this.BTNDANGXUAT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // BTNNHAPXUAT
            // 
            this.BTNNHAPXUAT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.BTNNHAPXUAT.Name = "BTNNHAPXUAT";
            this.BTNNHAPXUAT.Text = "NHAP XUAT";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSINHVIEN);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "QUAN LY";
            // 
            // BTNBAOCAO
            // 
            this.BTNBAOCAO.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.BTNBAOCAO.Name = "BTNBAOCAO";
            this.BTNBAOCAO.Text = "BAO CAO";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HE THONG";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNDN);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNTTK);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNTHOAT);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNDANGXUAT);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "HE THONG";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 690);
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
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "QUAN LY";
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage BTNBAOCAO;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage BTNNHAPXUAT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraBars.BarButtonItem BTNDN;
        private DevExpress.XtraBars.BarButtonItem BTNTTK;
        private DevExpress.XtraBars.BarButtonItem BTNTHOAT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem BTNDANGXUAT;
        public System.Windows.Forms.ToolStripStatusLabel MAGV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
    }
}

