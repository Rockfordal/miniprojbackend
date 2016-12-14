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

        // GET: api/WordImageTest
        //public IQueryable<WordImageTestModel> GetWordImageTestModels()
        //{
        //    return db.WordImageTestModels;
        //}

        // GET: api/WordImageTest/5
        //[ResponseType(typeof(WordImageTestModel))]
        public ICollection<WordImageQuestion> Get()
        {
            List<WordImageQuestion> wordimages = repo.GetWordImageTestData().ToList();
            //if (testData == null)
            //{
                //return NotFound();
            //}

            //return new string[] { "hej", "hej" };
            return wordimages;
        }

        // PUT: api/WordImageTest/5
        /*
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWordImageTestModel(int id, WordImageTestModel wordImageTestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != wordImageTestModel.Id)
            {
                return BadRequest();
            }

            db.Entry(wordImageTestModel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WordImageTestModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        */

        // POST: api/WordImageTest
        /*
        [ResponseType(typeof(WordImageTestModel))]
        public IHttpActionResult PostWordImageTestModel(WordImageTestModel wordImageTestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WordImageTestModels.Add(wordImageTestModel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = wordImageTestModel.Id }, wordImageTestModel);
        }
        */

        // DELETE: api/WordImageTest/5
        /*
        [ResponseType(typeof(WordImageTestModel))]
        public IHttpActionResult DeleteWordImageTestModel(int id)
        {
            WordImageTestModel wordImageTestModel = db.WordImageTestModels.Find(id);
            if (wordImageTestModel == null)
            {
                return NotFound();
            }

            db.WordImageTestModels.Remove(wordImageTestModel);
            db.SaveChanges();

            return Ok(wordImageTestModel);
        }
        */
    }
}