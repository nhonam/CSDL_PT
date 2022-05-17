using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSVHTC
{
    public partial class XrptPhieuDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptPhieuDiem()
        {
            InitializeComponent();
        }
        public XrptPhieuDiem(string msv, int type)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = msv;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = type;
        }

    }
}
