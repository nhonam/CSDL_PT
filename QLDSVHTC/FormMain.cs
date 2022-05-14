
using DevExpress.XtraBars;
using System;
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
            this.MAGV.Text = "MA " + Program.username;
            this.HOTEN.Text = "HOTEN " + Program.mHoten;
            this.NHOM.Text = "NHOM " + Program.mGroup;
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
                //DangKibarButton.Enabled = true;
                //DiemButtonItem.Enabled = HocPhibarButton.Enabled = btnLOPHOC.Enabled = LopTinChibarButton.Enabled = MonHocButtonItem.Enabled = btnSINHVIEN.Enabled = btnTaoTK.Enabled = false;
                rpBAOCAO.Visible = false;
            }
            if (Program.mGroup.Equals("PKT"))
            {
                //HocPhibarButton.Enabled = true;
               // DiemButtonItem.Enabled = LopHocbarButton.Enabled = LopTinChibarButton.Enabled = MonHocButtonItem.Enabled = btnSinhVien.Enabled = DangKibarButton.Enabled = false;
                //rpBaoCao.Visible = false;
            }
            if (Program.mGroup.Equals("PGV") || Program.mGroup.Equals("KHOA"))
            {
                //DangKibarButton.Enabled = HocPhibarButton.Enabled = false;
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

        /* private void MonHocButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             Form frm = this.CheckExists(typeof(frmMonHoc));
             if (frm != null) frm.Activate();
             else
             {
                 frmMonHoc f = new frmMonHoc();
                 f.MdiParent = this;
                 f.Show();
             }
         }*/

        /*private void LopTinChibarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                frmLopTinChi f = new frmLopTinChi();
                f.MdiParent = this;
                f.Show();
            }
        }*/

        /* private void DangKibarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             Form frm = this.CheckExists(typeof(frmDangKi));
             if (frm != null) frm.Activate();
             else
             {
                 frmDangKi f = new frmDangKi();
                 f.MdiParent = this;
                 f.Show();
             }
         }*/

        private void btnDIEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDiem));
            if (frm != null) frm.Activate();
            else
            {
                FormDiem f = new FormDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        /*  private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
              Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
              if (frm != null) frm.Activate();
              else
              {
                  frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                  f.MdiParent = this;
                  f.Show();
              }
          }
  */
        /* private void ribbonControl1_Click(object sender, EventArgs e)
         {

         }

         private void HocPhibarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {

             Form frm = this.CheckExists(typeof(frmHocPhi));
             if (frm != null) frm.Activate();
             else
             {
                 frmHocPhi f = new frmHocPhi();
                 f.MdiParent = this;
                 f.Show();
             }
         }*/

        /*  private void btnLapPhieuNX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
              Form frm = this.CheckExists(typeof(frptInDSSVLTC));
              if (frm != null) frm.Activate();
              else
              {
                  frptInDSSVLTC f = new frptInDSSVLTC();
                  f.MdiParent = this;
                  f.Show();
              }
          }
  */
        /* private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             Form frm = this.CheckExists(typeof(frptDSLTC));
             if (frm != null) frm.Activate();
             else
             {
                 frptDSLTC f = new frptDSLTC();
                 f.MdiParent = this;
                 f.Show();
             }
         }*/

        /*  private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
              Form frm = this.CheckExists(typeof(frptBDHM));
              if (frm != null) frm.Activate();
              else
              {
                  frptBDHM f = new frptBDHM();
                  f.MdiParent = this;
                  f.Show();
              }
          }*/

        /*private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frptPhieuDiemSV));
            if (frm != null) frm.Activate();
            else
            {
                frptPhieuDiemSV f = new frptPhieuDiemSV();
                f.MdiParent = this;
                f.Show();
            }
        }
*/
        /*  private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
              Form frm = this.CheckExists(typeof(frptHocPhi));
              if (frm != null) frm.Activate();
              else
              {
                  frptHocPhi f = new frptHocPhi();
                  f.MdiParent = this;
                  f.Show();
              }
          }
  */
        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            Form frmDangNhap = new FormDN();

            this.Close();
        }

        private void btnDIEM_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDiem));
            if (frm != null) frm.Activate();
            else
            {
                 FormDiem f = new FormDiem();
                 f.MdiParent = this;
                 f.Show();
            }
        
        }



        /*        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
                {
                    Form frm = this.CheckExists(typeof(frptBDTK));
                    if (frm != null) frm.Activate();
                    else
                    {
                        frptBDTK f = new frptBDTK();
                        f.MdiParent = this;
                        f.Show();
                    }
                }*/
        /*      private Form CheckExists(Type ftype)
              {
                  foreach (Form f in this.MdiChildren)
                      if (f.GetType() == ftype)
                          return f;
                  return null;
              }

              }

              private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

              private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

              private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
              {
                  FormDN f = new FormDN();
                  f.Show();
              }



              private void logout()
              {
                  foreach (Form f in this.MdiChildren)
                      f.Dispose();
              }

              private void BTNDANGXUAT_ItemClick(object sender, ItemClickEventArgs e)
              {
                  logout();

                  BTNDANGXUAT.Enabled = true;
                  BTNDANGXUAT.Enabled = true;

                  BTNNHAPXUAT.Visible = false;
                  BTNBAOCAO.Visible = false;
                  //pageTaiKhoan.Visible = false;

                  Form f = this.CheckExists(typeof(FormDN));
                  if (f != null)
                  {
                      f.Activate();
                  }
                  else
                  {
                      FormDN form = new FormDN();
                      //form.MdiParent = this;
                      form.Show();
                  }
                  Program.mainForm.MAGV.Text = "MÃ GV:";
                  Program.mainForm.HOTEN.Text = "HỌ TÊN:";
                  Program.mainForm.NHOM.Text = "VAI TRÒ:";
              }

              private void BTNDN_ItemClick(object sender, ItemClickEventArgs e)
              {
                  Form f = this.CheckExists(typeof(FormDN));
                  if (f != null)
                  {
                      f.Activate();
                  }
                  else
                  {
                      FormDN form = new FormDN();
                      //form.MdiParent = this;
                      form.Show();
                  }
              }

              private void FormChinh_Load(object sender, EventArgs e)
              {
              }


              private void BTNTHOAT_ItemClick_1(object sender, ItemClickEventArgs e)
              {
                  this.Close();

              }*/

    }
}
