
namespace QLDSVHTC
{
    partial class FormDangDiemTk
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMalop = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dS_SV1 = new QLDSVHTC.DS_SV1();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTableAdapter = new QLDSVHTC.DS_SV1TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSVHTC.DS_SV1TableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbMalop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txbMalop);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbKhoa);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 225);
            this.panel1.TabIndex = 3;
            // 
            // txbMalop
            // 
            this.txbMalop.Location = new System.Drawing.Point(465, 95);
            this.txbMalop.Margin = new System.Windows.Forms.Padding(4);
            this.txbMalop.Name = "txbMalop";
            this.txbMalop.Properties.ReadOnly = true;
            this.txbMalop.Size = new System.Drawing.Size(246, 22);
            this.txbMalop.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(761, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Chọn Lớp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(465, 52);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(325, 24);
            this.cbKhoa.TabIndex = 7;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged_1);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Salmon;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(571, 142);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 42);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(465, 142);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 42);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "IN";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "LỚP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "KHOA";
            // 
            // dS_SV1
            // 
            this.dS_SV1.DataSetName = "DS_SV1";
            this.dS_SV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS_SV1;
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.LOPTableAdapter;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSVHTC.DS_SV1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormDangDiemTk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 599);
            this.Controls.Add(this.panel1);
            this.Name = "FormDangDiemTk";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormDangDiemTk_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbMalop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DS_SV1 dS_SV1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit txbMalop;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS_SV1TableAdapters.LOPTableAdapter LOPTableAdapter;
        private DS_SV1TableAdapters.TableAdapterManager tableAdapterManager;
    }
}