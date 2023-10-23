using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestfulApiWeb.Models;

namespace RestfulApiWeb.Controllers
{
    public class EmployeeDataController : ApiController
    {
        // GET: api/EmployeeData

        public IEnumerable<testEmpDt_tbl> Get()
        {
            //return new string[] { "value1", "value2" };

            EmployeeDBRep dBRep = new EmployeeDBRep();
            return dBRep.GetAllEmpDetails();
        }

        // GET: api/EmployeeData/5
        public testEmpDt_tbl Get(int id)
        {
            //return "value";
            EmployeeDBRep dBRep = new EmployeeDBRep();
            return dBRep.GetEmpRecord(id);
            //return null;
        }

        // GET: api/EmployeeData/5 test
        public testEmpDt_tbl Gettest(int id)
        {
            //return "value";
            EmployeeDBRep dBRep = new EmployeeDBRep();
            return dBRep.GetEmpRecord(id);
            //return null;
        }

        // GET: api/EmployeeData/5 test
        public testEmpDt_tbl Getemployee(int id)
        {
            //return "value";
            EmployeeDBRep dBRep = new EmployeeDBRep();
            return dBRep.GetEmpRecord(id);
            //return null;
        }


        //// GET: api/EmployeeData/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/EmployeeData
        //public void Post([FromBody]string value)
        //{
        //}

        public HttpResponseMessage Post([FromBody] testEmpDt_tbl value)
        {
            EmployeeDBRep dBRep = new EmployeeDBRep();
            int nRet = dBRep.CreateUpdateNewRecord(value);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.ExpectationFailed);
            if(nRet ==0)
            {
                response = Request.CreateResponse(HttpStatusCode.Created);
            }
            return response;
        }

        // PUT: api/EmployeeData/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        public void Put(int id, [FromBody] testEmpDt_tbl value)
        {

        }


        // DELETE: api/EmployeeData/5
        //public void Delete(int id)
        //{
        //}

        public HttpResponseMessage Delete(int id , [FromBody] testEmpDt_tbl value)
        {
            EmployeeDBRep dBRep = new EmployeeDBRep();
            int nRet = dBRep.RemoveTheRecord(value);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.ExpectationFailed);
            if (nRet == 0)
            {
                response = Request.CreateResponse(HttpStatusCode.OK);
            }
            return response;
        }





    }
}
