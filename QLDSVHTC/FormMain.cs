
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

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void enableButtons()
        {

            BTNDN.Enabled = false;
            BTNTHOAT.Enabled = true;
            BTNNHAPXUAT.Visible = true;
            BTNBAOCAO.Visible = true;
            BTNTTK.Enabled = true;

            if (Program.role == "USER")
            {
                BTNTTK.Enabled = false;
            }

            //pageTaiKhoan.Visible = true;


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

        }

    }
}
