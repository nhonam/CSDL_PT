using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSVHTC
{
    public partial class FormDN : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private bool isSinhVien = false;
        public FormDN()
        {


          //  LayDSPM("SELECT * FROM LINK0.QLDSV_HTC.dbo.V_DS_PHANMANHDN");
            InitializeComponent();
        }
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
          
        }
        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publicsher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại tên Sever của Publisher, và tên CSDL trong chuỗi kết nối.\n" + e.Message);
                return 0;
            }
        }
        private void FormDN_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM LINK0.QLDSV_HTC.dbo.V_DS_PHANMANHDN");
            txtLogin.Text = "pgv";
            txtPass.Text = "123";
            cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = 0;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.severname = cmbKhoa.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (isSinhVien == false)
            {
                if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
                {
                    MessageBox.Show("Login name và mật khẩu không được trống", "", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                if (txtLogin.Text.Trim() == "")
                {
                    MessageBox.Show("Login name không được trống", "", MessageBoxButtons.OK);
                    return;
                }
            }

            if (isSinhVien == true)
            {
                Program.mlogin = "sv";
                Program.password = "123";
                if (Program.KetNoi() == 0) return;
            }
            else
            {
                Program.mlogin = txtLogin.Text; Program.password = txtPass.Text;
                if (Program.KetNoi() == 0) return;
            }


            Program.mChinhanh = cmbKhoa.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;


            string strLenh = "EXEC dbo.SP_Lay_Thong_Tin_NV_Tu_Login '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read(); // Đọc 1 dòng nếu dữ liệu có nhiều dùng thì dùng for lặp nếu null thì break
            Program.mGroup = Program.myReader.GetString(2);

            if (isSinhVien == false)
            {
                Program.mHoten = Program.myReader.GetString(1);
                Program.username = Program.myReader.GetString(0);
            }
            Program.myReader.Close();
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }

            if (cmbKhoa.Text.ToString().Equals("Phòng Kế Toán") && isSinhVien)
            {
                MessageBox.Show("sinh viên không được đăng nhập vào phòng kế toán");
                return;
            }

            if (isSinhVien==true)
            {
              //  Program.mGroup = "SV";
            string strlenh1 = "EXEC [dbo].[SP_LayThongTinSV_DangNhap] '" + txtLogin.Text + "', '" + txtPass.Text + "'";
            SqlDataReader reader = Program.ExecSqlDataReader(strlenh1);

            if (reader.HasRows == false && isSinhVien == true)
            {
                MessageBox.Show("Đăng nhập thất bại! \nMã sinh viên không tồn tại");
                return;
            }

            reader.Read();



            if (isSinhVien == true)
            {
                try
                {
                    Program.mHoten = reader.GetString(1);
                    Program.username = reader.GetString(0);
                }
                catch (Exception) { }
            }
            Program.conn.Close();
            reader.Close();
        }
            Form f = new FormMain();
            f.ShowDialog();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Program.mainForm.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isSinhVien = !isSinhVien;
        }
    }

}