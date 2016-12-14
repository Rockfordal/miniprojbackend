using Miniproj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miniproj.Repositories
{
    public class WordImageTestRepository
    {
        private static ApplicationDbContext context;

        public static Tuple<int, string> GetWordImageTestData(WordImageTestModel model)
        {
            return new Tuple<int, string>(model.Id, model.Image);
        }

        public static Tuple<int, string> GetRandomWordImageTestData()
        {
            var obj = HelperMethods.GetRandom(context.WordImageTestModels);
            return new Tuple<int, string>(obj.Id, obj.Image);
        }
    }
}