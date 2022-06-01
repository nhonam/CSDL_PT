using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSVHTC
{
    public partial class ChonLop : Form
    {
        public ChonLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SV1);

        }

        private void ChonLop_Load(object sender, EventArgs e)
        {
            dS_SV1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS_SV1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS_SV1.LOP);
          //  cbKhoa.Text = FormDangDiemTk.tenkhoa;
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;
            //tenkhoa = cbKhoa.DisplayMember;
            if (Program.mGroup == "KHOA")
            {
                cbKhoa.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maLOP = ((DataRowView)lOPBindingSource.Current)["MALOP"].ToString();
            FormDangDiemTk.malop = maLOP;
            this.Close();
        }

      
        private void cbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
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
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS_SV1.LOP);
            }
        }
    }
}
