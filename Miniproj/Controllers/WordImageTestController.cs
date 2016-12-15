using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Miniproj.Models;
using Miniproj.Repositories;

namespace Miniproj.Controllers
{
    public class WordImageTestController : ApiController
    {
        public SuperRepository repo { get; set; }

        public WordImageTestController()
        {
            repo = new SuperRepository();
        }

        // GET: api/wordimagetest
        public ICollection<WordImageQuestion> Get()
        {
            List<WordImageQuestion> wordimages = repo.GetWordImageTestData().ToList();

            return wordimages;
        }

        // POST: api/wordimagetest
        [ResponseType(typeof(ICollection<bool>))]
        public IHttpActionResult Post(ICollection<WordImageAnswer> attempts)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            List<Boolean> response =
                repo
                    .SubmitWordImageTest(attempts)
                    .ToList();

            return Ok(response);
        }

    }
}