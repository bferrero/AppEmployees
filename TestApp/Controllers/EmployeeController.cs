using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using BOL;
using BOL.Interfaces;

namespace TestApp.Controllers
{    
    [RoutePrefix("api/employees")]
    public class EmployeeController : ApiController
    {

        private IEmployee _myIEmployee;

        public EmployeeController(IEmployee myEmployee) {
            _myIEmployee = myEmployee;       
        }

        [HttpGet]
        [Route("GetAll")]
        public HttpResponseMessage GetAll() {

            try
            {
                var listEmployee = _myIEmployee.GetAll();
                return Request.CreateResponse<List<Employee>>(HttpStatusCode.OK, listEmployee);
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }


        }

    }
}
