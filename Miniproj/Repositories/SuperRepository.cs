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

        public IEnumerable<WordImageQuestion> GetWordImageTestData()
        {
            var data = context.WordImagetests
                .Select(x => new WordImageQuestion { Id = x.Id, Image = x.Image })
                .Take(5);
            return data;
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