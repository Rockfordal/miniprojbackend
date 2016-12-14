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
    public class SeparatorTestController : ApiController
    {
        public SuperRepository repo { get; set; }

        public SeparatorTestController()
        {
            repo = new SuperRepository();
        }


        // GET: /api/separatortest/
        //public SeparatorTestModel Get()
        [ResponseType(typeof(SeparatorTestModel))]
        public IHttpActionResult Get()
        //public Object Get()
        {
            SeparatorTestModel text = repo.GetSeparatorTestData();

            //return new { Id = septest.Id, Text = septest.Text };
            //return new string[] { }
            //return septest;
            return Ok(text);
        }

    }
}
