
using DevExpress.XtraBars;
using QLDSVHTC.Report;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSVHTC
{
    public partial class FormMain : Form
    { 

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        { 
            HienThiMenu();
            PhanQuyen();
            this.MAGV.Text = "Mã: " + Program.username;
            this.HOTEN.Text = "Họ Tên : " + Program.mHoten;
            this.NHOM.Text = "Nhóm : " + Program.mGroup;
        }
       
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public void HienThiMenu()
        {
            rpNHAPXUAT.Visible = rpBAOCAO.Visible = rpHETHONG.Visible = true;
        }

        #region EVENT

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDN));
            if (frm != null) frm.Activate();
            else
            {
                FormDN f = new FormDN();
                f.MdiParent = this;
                f.Show();
            }
        }
        #endregion


        void PhanQuyen()
        {
            if (Program.mGroup.Equals("SV"))
            {
                btnDANGKI.Enabled = true;
                btnDIEM.Enabled = btnHOCPHI.Enabled = btnLOPHOC.Enabled = btnLOPTINCHI.Enabled = btnMONHOC.Enabled = btnSINHVIEN.Enabled = BTNTTK.Enabled = false;
                rpBAOCAO.Visible = false;
            }
            if (Program.mGroup.Equals("PKT"))
            {
                btnHOCPHI.Enabled = true;
                btnDIEM.Enabled = btnLOPHOC.Enabled = btnLOPTINCHI.Enabled = btnMONHOC.Enabled = btnSINHVIEN.Enabled = btnDANGKI.Enabled = false;
                rpBAOCAO.Visible = false;
            }
            if (Program.mGroup.Equals("PGV") || Program.mGroup.Equals("KHOA"))
            {
                btnDANGKI.Enabled = btnHOCPHI.Enabled = false;
                rpNHAPXUAT.Visible = true;
                btnSINHVIEN.Enabled = btnLOPHOC.Enabled = true;
            }
        }
        private void btnSINHVIEN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormSV));
            if (frm != null) frm.Activate();
            else
            {
                FormSV f = new FormSV();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void btnLOPHOC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(FormLH));
            if (frm != null) frm.Activate();
            else
            {
                FormLH f = new FormLH();
                f.MdiParent = this;
                f.Show();
            }
        }


        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            Program.bds_dspm = null;
            Form frmDangNhap = new FormDN();

            this.Close();

        }

        private void btnDIEM_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDIEM));
            if (frm != null) frm.Activate();
            else
            {
                FormDIEM f = new FormDIEM();
                 f.MdiParent = this;
                 f.Show();
            }
        
        }

      

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormMH));
            if (frm != null) frm.Activate();
            else
            {
                FormMH f = new FormMH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void BTNTTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                FormTaoTaiKhoan f = new FormTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLTC));
            if (frm != null) frm.Activate();
            else
            {
                FormLTC f = new FormLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormHOCPHI));
            if (frm != null) frm.Activate();
            else
            {
                FormHOCPHI f = new FormHOCPHI();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrptBDMH));
            if (frm != null) frm.Activate();
            else
            {
                FrptBDMH f = new FrptBDMH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_PHIEUDIEM));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_PHIEUDIEM f = new Frpt_PHIEUDIEM();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrptDSHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                FrptDSHocPhi f = new FrptDSHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrptDSLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                FrptDSLopTinChi f = new FrptDSLopTinChi();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FRpDSSVDK));
            if (frm != null) frm.Activate();
            else
            {
                FRpDSSVDK f = new FRpDSSVDK();
                f.MdiParent = this;
                f.Show();
            }
        }





  

              private void logout()
              {
                  foreach (Form f in this.MdiChildren)
                      f.Dispose();
              }

        private void btnDANGKI_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangKi));
            if (frm != null) frm.Activate();
            else
            {
                FormDangKi f = new FormDangKi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangDiemTk));
            if (frm != null) frm.Activate();
            else
            {
                FormDangDiemTk f = new FormDangDiemTk();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
