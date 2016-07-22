using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Medidata.OctoDemo.Web
{
    [Route("")]
    public class HomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(new { message = ConfigurationManager.AppSettings["app-message"] });
        }
        
    }
}