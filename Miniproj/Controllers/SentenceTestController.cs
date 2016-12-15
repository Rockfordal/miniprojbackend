using Miniproj.Models;
using Miniproj.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Miniproj.Controllers
{
    public class SentenceTestController : ApiController
    {
        public SuperRepository repo { get; set; }

        public SentenceTestController ()
        {
            repo = new SuperRepository();
        }

        // GET: /api/separatortest/
        [ResponseType(typeof(SentenceTest))]
        public IHttpActionResult Get()
        {
            SentenceTest text = repo.GetRandomSentenceTestData();

            string output = string.Join(" ", repo.ShuffleText(text.Text));

            return Ok(output);
        }
    }
}
