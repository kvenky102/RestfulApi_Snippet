using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RestfulApiWeb.Models
{
    public class EmployeeDBRep : EmployeeDBEntities
    {

        // testEmpDt_tbl table name
       public List<testEmpDt_tbl> GetAllEmpDetails()
        {
        
            //return new List<testEmpDt_tbl>();
            return testEmpDt_tbl.ToList();

        }

        public testEmpDt_tbl GetEmpRecord(int ID)
        {

            testEmpDt_tbl Emp_Res = new testEmpDt_tbl();

            //List<testEmpDt_tbl> lstEmp = testEmpDt_tbl.Where(e=>e.Equals(ID)).ToList();
            //List<testEmpDt_tbl> lstEmp = testEmpDt_tbl.Where(e => e.EmployeeID == ID).ToList();
            //Emp_Res = lstEmp.First();


            return testEmpDt_tbl.Find(ID);
        }


        public int CreateUpdateNewRecord(testEmpDt_tbl Empdata)
        {

            try
            {
                testEmpDt_tbl.Add(Empdata);
                SaveChanges();
            }catch(Exception ex)
            {
                return 1;
            }
            return 0;

            //List<testEmpDt_tbl> lstEmp = testEmpDt_tbl.Where(e=>e.Equals(ID)).ToList();
            //List<testEmpDt_tbl> lstEmp = testEmpDt_tbl.Where(e => e.EmployeeID == ID).ToList();
            //Emp_Res = lstEmp.First();


        }

        public int RemoveTheRecord(testEmpDt_tbl Empdata)
        {

            try
            {
                testEmpDt_tbl.Remove(Empdata);
                SaveChanges();
            }
            catch (Exception ex)
            {
                return 1;
            }
            return 0;
        }


    }
}