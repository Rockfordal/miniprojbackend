using Miniproj.Models;
using Miniproj.Repositories;
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
        [ResponseType(typeof(SeparatorTest))]
        public IHttpActionResult Get()
        {
            SeparatorTest text = repo.GetRandomSeparatorTestData();

            text.Text = repo.HideSeparators(text.Text);

            return Ok(text);
        }
    }
}
