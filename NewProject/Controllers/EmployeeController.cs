using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using CommonLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NewProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IBusinessLayer businessLayer;

        private EmployeeController(IBusinessLayer businessLayer)
        {

        }

        [HttpPost]
        public ActionResult<IEnumerable<string>> SampleApi(EmployeeModel employee)
        {
            return new string[] { "value1", "value2" };
        }
    }
}
