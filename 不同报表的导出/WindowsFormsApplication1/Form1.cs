using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Reports;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 水晶报表
            CrystalReport1 cr = new CrystalReport1();
            var title = cr.Section1.ReportObjects["TextTitle"];
            if (title.Kind == ReportObjectKind.TextObject)
                ((TextObject)title).Text = "XX一览";
            cr.ParameterFields["type"].CurrentValues.AddValue("这是水晶报表");
            crystalReportViewer1.ReportSource = cr;
            #endregion
        }
    }
}
