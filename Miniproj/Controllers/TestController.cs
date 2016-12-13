using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Http.Cors;10.23.192.246

namespace Miniproj.Controllers
{
    //[EnableCors(origins: "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
    public class TestController : ApiController
    {
        // GET api/test
        public IEnumerable<string> Get()
        {
            return new string[] { "hej", "hoj" };
        }
    }
}
