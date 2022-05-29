using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSVHTC
{
    public partial class XprtBangDiemTk : DevExpress.XtraReports.UI.XtraReport
    {
        public XprtBangDiemTk()
        {
            InitializeComponent();
        }

        public XprtBangDiemTk(string malop)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
        }

    }
}
