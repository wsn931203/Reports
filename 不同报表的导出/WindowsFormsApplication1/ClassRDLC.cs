using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class ClassRDLC
    {
        private int deptID;

        public int DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }

        private string deptName;

        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
