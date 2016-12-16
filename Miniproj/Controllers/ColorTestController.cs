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
    public class ColorTestController : ApiController
    {
        public SuperRepository repo { get; set; }

        public ColorTestController ()
        {
            repo = new SuperRepository();
        }

        // GET api/colortest
        [ResponseType(typeof(ColorTestQuestion))]
        public ColorTestQuestion Get()
        {
            return repo.GetColorTestData();
        }

        // POST: api/colortest
        //[ResponseType(typeof(ICollection<ColorTestResponse>))]
        public IHttpActionResult Post(ICollection<ColorTestAnswer> attempts)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            List<ColorTestResponse> response =
                repo
                    .SubmitColorTest(attempts);

            return Ok(response);
        }

        public IHttpActionResult Options()
        {
            return Ok();
        }
    }
}
