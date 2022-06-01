using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSVHTC
{
    public partial class FormDangDiemTk : Form
    {
        public static string malop = "";
      //  public static string tenkhoa = "";
        public FormDangDiemTk()
        {
            InitializeComponent();
        }

        private void FormDangDiemTk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_SV1.LOP' table. You can move, or remove it, as needed.
          


            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;


           
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;
           // tenkhoa = cbKhoa.ValueMember.ToString();
            if (Program.mGroup == "KHOA")
            {
                cbKhoa.Enabled = false;
            }
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.severname = cbKhoa.SelectedValue.ToString();
            if (cbKhoa.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);

            }
            else
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.dS_SV1.LOP);
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
          
            string cmd = "SELECT TENKHOA,KHOAHOC FROM dbo.LOP,dbo.KHOA WHERE MALOP = '" + malop + "' AND KHOA.MAKHOA = LOP.MAKHOA";
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            reader.Read();
            string tenkhoa = reader.GetString(0);
            string khoahoc = reader.GetString(1);
            reader.Close();
            XprtBangDiemTk rpt = new XprtBangDiemTk(malop);
            rpt.lbKhoa.Text = tenkhoa;
            rpt.lbKhoaHoc.Text = khoahoc;
            rpt.lbLop.Text = malop;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

       

      

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChonLop f = new ChonLop();
            
            f.ShowDialog();
            txbMalop.Text = malop;
           // Program.tenkhoa = 
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SV1);

        }

        private void cbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
