using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Miniproj.Controllers
{
    public class RandomTestController : ApiController
    {
        static Type[] controllerTypes = { typeof(WordImageTestController), typeof(ColorTestController), typeof(SeparatorTestController), typeof(SentenceTestController) };

        public IHttpActionResult GetRandom()
        {
            Random rand = new Random();
            ApiController con = Activator.CreateInstance(controllerTypes[rand.Next(0, controllerTypes.Length - 1)]) as ApiController;
            return Ok(con.ToString());
        }
    }
}
