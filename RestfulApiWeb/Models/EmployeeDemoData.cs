using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestfulApiWeb.Models
{
    public class EmployeeDemoData
    {

        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string Designation { get; set; }

        public class EmployeeDataList
        {
            public List<EmployeeDemoData> EmployeeDemoDatas { get; set; } = null;
            
        }


    }
}