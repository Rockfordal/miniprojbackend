﻿using Miniproj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        public IEnumerable<WordImageQuestion> GetWordImageTestData(int limit = 5)
        {
            var data = context.WordImagetests
                .Select(x => new WordImageQuestion { Id = x.Id, Image = x.Image })
                .Take(limit);
            return data;
        }

        /* public static Tuple<int, string> GetRandomWordImageTestData()
        {
            var obj = HelperMethods.GetRandom(context.WordImageTestModels);
            return new Tuple<int, string>(obj.Id, obj.Image);
        } */

        public SeparatorTest GetRandomSeparatorTestData()
        {
            Random rand = new Random();
            var count = context.Separatortests.Count();
            int toSkip = rand.Next(0, count);
            var data = context.Separatortests
                .OrderBy(a => a.Id)
                .Skip(toSkip)
                .Take(1)
                .First();
            return data;
        }

        public SentenceTest GetRandomSentenceTestData()
        {
            Random rand = new Random();
            var count = context.Sentencetests.Count();
            int toSkip = rand.Next(0, count);
            var data = context.Sentencetests
                .OrderBy(a => a.Id)
                .Skip(toSkip)
                .Take(1)
                .First();
            return data;
        }

        public string HideSeparators(string input, string replacement = "*")
        {
            Regex test = new Regex("[" + HelperClasses.SeparatorList +"]");
            return test.Replace(input, replacement);
        }

        public string[] ScrambleText(string text)
        {
            string[] temp = text.Split(' ');

            temp.Shuffle();

            //text = string.Join(" ", temp);

            return temp;
        }
    }
}