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

        #region WordImageTest-funktionalitet

        public IEnumerable<WordImageQuestion> GetWordImageTestData(int limit = 5)
        {
            var data = context.WordImagetests
                .Select(x => new WordImageQuestion { Id = x.Id, Image = x.Image })
                .Take(limit);
            return data;
        }

        public ICollection<Boolean> SubmitWordImageTest(ICollection<WordImageAnswer> attempts)
        {
            List<int> idList = attempts
                .Select(a => a.Id)
                    .ToList();

            var answers = context.WordImagetests
                .Where(wi => idList.Contains(wi.Id))
                .Select(wi => wi.Word.ToLower())
                .ToList();

            var results = new List<Boolean>();

            foreach (WordImageAnswer attempt in attempts)
            {
                var result = answers.Contains(attempt.Word.ToLower());
                results.Add(result);
            }

            return results;
        }

        #endregion

        #region SeparatorTest-funktionalitet

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

        public string HideSeparators(string input, string replacement = "*")
        {
            Regex test = new Regex("[" + HelperClasses.Separators + "]");
            return test.Replace(input, replacement);
        }

        public List<bool> VerifySeparators(string input, string expected)
        {
            var correct = new List<bool>(); ;

            //Regex test = new Regex("[^" + HelperClasses.Separators + "]");
            //test.Replace(input, "");

            for (int i = 0; i < Math.Min(input.Length, expected.Length); i++)
            {
                if (input[i] == expected[i])
                {
                    correct.Add(true);
                }
                else
                {
                    correct.Add(false);
                }
            }

            return correct;
        }

        #endregion

        #region SentenceTest-funktionalitet

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

        public string[] ShuffleText(string text)
        {
            string[] temp = text.Split(' ');

            temp.Shuffle();

            //text = string.Join(" ", temp);

            return temp;
        }

        #endregion
    }
}