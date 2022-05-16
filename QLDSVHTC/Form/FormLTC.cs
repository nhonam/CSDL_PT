﻿using System;
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
    public partial class FormLTC : Form
    {

        private SqlConnection conn_publisher = new SqlConnection();
        int vitri = 0;
        string macn = "";
        public FormLTC()
        {
            InitializeComponent();
            panelControl2.Enabled = false;
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void FormLTC_Load(object sender, EventArgs e)
        {
            loadGVcombobox();
            dS_SV1.EnforceConstraints = false;

            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTINCHITableAdapter.Fill(this.dS_SV1.LOPTINCHI);

            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DANGKYTableAdapter.Fill(this.dS_SV1.DANGKY);


            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.dS_SV1.MONHOC);

            macn = ((DataRowView)bdsLopTinChi[0])["MAKHOA"].ToString();
            cbKhoa.DataSource = Program.bds_dspm;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mChinhanh;



            cbTenMonHoc.DataSource = bdsMonHoc;
            cbTenMonHoc.DisplayMember = "TENMH";
            cbTenMonHoc.ValueMember = "MAMH";

            if (Program.mGroup == "KHOA")
            {
                cbKhoa.Enabled = false;
            }
            txbMaMonHoc.Text = cbTenMonHoc.ValueMember.ToString();
            txbMaGiangVien.Text = cbTenGiangVien.ValueMember.ToString();

        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLopTinChi.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SV1);

        }

        void loadGVcombobox()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.SP_LayDSGV";
            dt = Program.ExecSqlDataTable(cmd);
            BindingSource bdsgv = new BindingSource();
            bdsgv.DataSource = dt;
            cbTenGiangVien.DataSource = bdsgv;
            cbTenGiangVien.DisplayMember = "HOTEN";
            cbTenGiangVien.ValueMember = "MAGV";
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
                loadGVcombobox();
                this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTINCHITableAdapter.Fill(this.dS_SV1.LOPTINCHI);
                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DANGKYTableAdapter.Fill(this.dS_SV1.DANGKY);
                macn = ((DataRowView)bdsLopTinChi[0])["MAKHOA"].ToString();
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLopTinChi.CancelEdit();
            if (btnThem.Enabled == false) bdsLopTinChi.Position = vitri;
            lOPTINCHIGridControl.Enabled = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            FormLTC_Load(sender, e);

            // load lại cả form...


            if (vitri > 0)
            {
                bdsLopTinChi.Position = vitri;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLopTinChi.Position;
            panelControl2.Enabled = true;
            bdsLopTinChi.AddNew();
            txbMaKhoa.Text = macn;
            cbTenGiangVien.SelectedIndex = 0;
            cbTenMonHoc.SelectedIndex = 0;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            lOPTINCHIGridControl.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maloptc = "";
            if (bdsDangKi.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maloptc = ((DataRowView)bdsLopTinChi[bdsLopTinChi.Position])["MALTC"].ToString();
                    bdsLopTinChi.RemoveCurrent();
                    this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTINCHITableAdapter.Update(this.dS_SV1.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp : " + ex.Message, "", MessageBoxButtons.OK);
                    this.LOPTINCHITableAdapter.Fill(this.dS_SV1.LOPTINCHI);
                    bdsLopTinChi.Position = bdsLopTinChi.Find("MALTC", maloptc);
                    return;
                }
            }
            if (bdsLopTinChi.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLopTinChi.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = false;
            btnGhi.Enabled = true;
            lOPTINCHIGridControl.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnPhucHoi.Enabled = true;

            if (speHocKy.Value == 0)
            {
                MessageBox.Show("Học kì không được thiếu!", "", MessageBoxButtons.OK);
                speHocKy.Focus();
                return;
            }
            if (speSoSVToiThieu.Value == 0)
            {
                MessageBox.Show("Số sinh viên tối thiểu không được thiếu!", "", MessageBoxButtons.OK);
                speSoSVToiThieu.Focus();
                return;
            }
            if (speNhom.Value == 0)
            {
                MessageBox.Show("Nhóm không được thiếu!", "", MessageBoxButtons.OK);
                speSoSVToiThieu.Focus();
                return;
            }
            if (txbMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                txbMaKhoa.Focus();
                return;
            }
            if (txbMaMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được thiếu!", "", MessageBoxButtons.OK);
                txbMaKhoa.Focus();
                return;
            }
            if (txbMaGiangVien.Text.Trim() == "")
            {
                MessageBox.Show("Mã giảng viên không được thiếu!", "", MessageBoxButtons.OK);
                txbMaKhoa.Focus();
                return;
            }
            if (txbNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không được thiếu!", "", MessageBoxButtons.OK);
                txbMaKhoa.Focus();
                return;
            }
            try
            {
                bdsLopTinChi.EndEdit();
                bdsLopTinChi.ResetCurrentItem();
                this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTINCHITableAdapter.Update(this.dS_SV1.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp tín chỉ: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            lOPTINCHIGridControl.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LOPTINCHITableAdapter.Fill(this.dS_SV1.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cbTenGiangVien_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTenGiangVien.SelectedValue != null)
            {
                txbMaGiangVien.Text = cbTenGiangVien.SelectedValue.ToString();
            }
        }
        private void cbTenMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTenMonHoc.SelectedValue != null)
            {
                txbMaMonHoc.Text = cbTenMonHoc.SelectedValue.ToString();
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl2.Enabled = false;
            lOPTINCHIGridControl.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = true;
        }

        private void txbMaMonHoc_EditValueChanged(object sender, EventArgs e)
        {
            cbTenMonHoc.SelectedValue = txbMaMonHoc.Text;
        }

        private void txbMaGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            cbTenGiangVien.SelectedValue = txbMaGiangVien.Text;
        }
    }
}
