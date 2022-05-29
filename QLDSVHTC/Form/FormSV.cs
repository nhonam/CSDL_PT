using DevExpress.Utils;
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
            InitializeComponent();
            panelControl2.Enabled = false;
        }

        private void LOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SV1);

        }

        private void FormSV_Load(object sender, EventArgs e)
        {
            dS_SV1.EnforceConstraints = false;

            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.dS_SV1.LOP);

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.dS_SV1.SINHVIEN);

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
        private bool validatorSinhVien()
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
            if (PHAICheckEdit.Checked == false)
            {
                MessageBox.Show("Phái không được thiếu!", "", MessageBoxButtons.OK);
                PHAICheckEdit.Focus();
                return false;
            }
            if (DANGHIHOCCheckEdit.Checked == false)
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
        }
        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Program.bds_dspm.Filter = "TENKHOA not LIKE 'Phòng Kế Toán%'";
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
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
                try
                {
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Fill(this.dS_SV1.LOP);

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Fill(this.dS_SV1.SINHVIEN);

                    this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.DANGKYTableAdapter.Fill(this.dS_SV1.DANGKY);


                    macn = ((DataRowView)bdsLOP[0])["MAKHOA"].ToString();
                }catch(Exception ex)
                {
                    MessageBox.Show("Không được truy cập phòng kế toán " , "", MessageBoxButtons.OK);
                }
               
            }
        }



        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSV.Position;
            _flagOptionSinhVien = "UPDATE";
            _oldMaSV = txbMaSV.Text.Trim();

            panelControl2.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = true;
            txbMaSV.Enabled = false;
            sINHVIENGridControl.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (validatorSinhVien() == true)
            {
                try
                {
                    bdsSV.EndEdit();
                    bdsSV.ResetCurrentItem();
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Update(this.dS_SV1.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                sINHVIENGridControl.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;
                panelControl2.Enabled = false;
            }
            else
            {
                return;
            }

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSV.CancelEdit();
            if (btnThem.Enabled == false) bdsLOP.Position = vitri;
            sINHVIENGridControl.Enabled = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            FormSV_Load(sender, e);

            // load lại cả form...


            if (vitri > 0)
            {
                bdsSV.Position = vitri;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            vitri = bdsSV.Position;
            _flagOptionSinhVien = "ADD";

            panelControl2.Enabled = true;
            bdsSV.AddNew();
            txbMaLop.Text = ((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            sINHVIENGridControl.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LOPTableAdapter.Fill(this.dS_SV1.LOP);
                this.SINHVIENTableAdapter.Fill(this.dS_SV1.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string masv = "";
            if (bdsDANGKY.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì sinh viên đã đăng kí lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }


            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên khỏi lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();
                    bdsSV.RemoveCurrent();
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Update(this.dS_SV1.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh vieen: " + ex.Message, "", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Fill(this.dS_SV1.SINHVIEN);
                    bdsSV.Position = bdsLOP.Find("MASV", masv);
                    return;
                }
            }
            if (bdsSV.Count == 0) btnXoa.Enabled = false;
        }
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Enabled = false;
            sINHVIENGridControl.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = true;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
