﻿using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FormSV : Form
    {
        int vitri = 0;
        string macn = "";
        private string _flagOptionSinhVien;
        private string _oldMaSV;
        public FormSV()
        {
            // This line of code is generated by Data Source Configuration Wizard
            InitializeComponent();
           /* pclNhap.Enabled = true;*/
            // This line of code is generated by Data Source Configuration Wizard
        }

        /*private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SV1);

        }*/

        private void FormSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_SV1.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Fill(this.dS_SV1.LOP);
            // TODO: This line of code loads data into the 'dS_SV1.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Fill(this.dS_SV1.SINHVIEN);
            // TODO: This line of code loads data into the 'dS_SV1.DANGKY' table. You can move, or remove it, as needed.
            this.DANGKYTableAdapter.Fill(this.dS_SV1.DANGKY);

            dS_SV1.EnforceConstraints = false;

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.dS_SV1.SINHVIEN);

            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.dS_SV1.LOP);
 
            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DANGKYTableAdapter.Fill(this.dS_SV1.DANGKY);



            macn = ((DataRowView)bdsLOP[0])["MAKHOA"].ToString();
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "KHOA")
            {
                cmbKhoa.Enabled = false;
            }
        }

      /*  private bool validatorSinhVien()
        {
            if (txbMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txbMaLop.Focus();
                return false;
            }
            if (txbHo.Text.Trim() == "")
            {
                MessageBox.Show("họ không được thiếu!", "", MessageBoxButtons.OK);
                txbHo.Focus();
                return false;
            }
            if (txbTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "", MessageBoxButtons.OK);
                txbTen.Focus();
                return false;
            }
            if (txbDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu!", "", MessageBoxButtons.OK);
                txbDiaChi.Focus();
                return false;
            }
            if (txbMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txbDiaChi.Focus();
                return false;
            }
            if (PHAICheckEdit.Checked == null)
            {
                MessageBox.Show("Phái không được thiếu!", "", MessageBoxButtons.OK);
                PHAICheckEdit.Focus();
                return false;
            }
            if (DANGHIHOCCheckEdit.Checked == null)
            {
                MessageBox.Show("Đang nghỉ học không được thiếu!", "", MessageBoxButtons.OK);
                DANGHIHOCCheckEdit.Focus();
                return false;
            }
            if (_flagOptionSinhVien == "ADD")
            {
                string query1 = " DECLARE @return_value INT " +

                            " EXEC @return_value = [dbo].[SP_CHECKID] " +

                            " @Code = N'" + txbMaSV.Text.Trim() + "',  " +

                            " @Type = N'MASV' " +

                            " SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(query1);
                if (resultMa == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMa == 1)
                {
                    XtraMessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    XtraMessageBox.Show("Mã Sinh Viên đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (_flagOptionSinhVien == "UPDATE")
            {
                if (!this.txbMaSV.Text.Trim().ToString().Equals(_oldMaSV))
                {
                    string query2 = " DECLARE @return_value INT " +

                            " EXEC @return_value = [dbo].[SP_CHECKID] " +

                            " @Code = N'" + txbMaSV.Text.Trim() + "',  " +

                            " @Type = N'MASV' " +

                            " SELECT  'Return Value' = @return_value ";

                    int resultMa = Program.CheckDataHelper(query2);
                    if (resultMa == -1)
                    {
                        XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultMa == 1)
                    {
                        XtraMessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (resultMa == 2)
                    {
                        XtraMessageBox.Show("Mã Sinh Viên đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

            }
            return true;
        }*/

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.severname = cmbKhoa.SelectedValue.ToString();
            if (cmbKhoa.SelectedIndex != Program.mChinhanh)
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
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.dS_SV1.SINHVIEN);

                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.dS_SV1.LOP);

                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DANGKYTableAdapter.Fill(this.dS_SV1.DANGKY);


                macn = ((DataRowView)bdsLOP[0])["MAKHOA"].ToString();
            }
        }

        private void Thoat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close(); 
        }

        private void Huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            panelControl1.Enabled = false;
            gridControl2.Enabled = true;
            Them.Enabled = Sua.Enabled = Xoa.Enabled = Ghi.Enabled = true;
        }
    }
}