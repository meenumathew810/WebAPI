using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class StudentController : ApiController
    {
        [HttpGet]
        [Route("GetDetails")]
        public string GetDetails(int id)
        {
            return "ID";
        }
        [HttpPost]
        [Route("PostDetails")]
        public string PostDetails(Project p)
        {

            return "project";
        }
    }
}
