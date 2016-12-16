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
        //static Type[] controllerTypes = { typeof(WordImageTestController), typeof(ColorTestController), typeof(SeparatorTestController), typeof(SentenceTestController) };
        static string[] controllerUrls = { "WordImageTest", "ColorTest", "SeparatorTest", "SentenceTest" };

        public IHttpActionResult Get()
        {
            Random rand = new Random();
            //ApiController con = Activator.CreateInstance(controllerTypes[rand.Next(controllerTypes.Length)]) as ApiController;
            Uri controller = new Uri(controllerUrls[rand.Next(controllerUrls.Length)], UriKind.Relative);
            return Redirect(controller);
        }
    }
}
