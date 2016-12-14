using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Miniproj.Controllers
{
    public class ColorTestController : ApiController
    {
        // GET api/colortest
        public IEnumerable<string> Get()
        {
            return new string[] { "hej", "hoj" };
        }
    }
}
