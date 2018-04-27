using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataTable dt = null;
            string conStr = "Server='127.0.0.1';database=demo;UID='sa';PWD='123456';";
            try
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string sql = @"select Dept.DeptID,Dept.DeptName,UserInfo.UserName,UserInfo.Salary from dbo.Dept left join dbo.UserInfo on Dept.ID=UserInfo.DeptID";
                SqlCommand sqlcmd = new SqlCommand(sql, con);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                sda.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.StackTrace);
            }

            try
            {
                this.reportViewer1.LocalReport.ReportPath = @"Reports\Report1.rdlc";
                ReportParameter rp = new ReportParameter("type", "rdlc报表");
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",dt));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
