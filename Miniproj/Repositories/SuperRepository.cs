using Miniproj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miniproj.Repositories
{
    public class SuperRepository
    {
        private ApplicationDbContext context;

        public SuperRepository()
        {
            context = new ApplicationDbContext();
        }

        public ICollection<Tuple<int, string>> GetWordImageTestData()
        {
            return context.WordImageTestModels.Select(x => new Tuple<int, string>(x.Id, x.Image)).Take(5).ToList();
        }

        /*
        public static Tuple<int, string> GetRandomWordImageTestData()
        {
            var obj = HelperMethods.GetRandom(context.WordImageTestModels);
            return new Tuple<int, string>(obj.Id, obj.Image);
        }
        */
    }
}