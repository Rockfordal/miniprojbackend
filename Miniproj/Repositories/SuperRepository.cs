using Miniproj.Models;
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

        public List<WordImageResponse> SubmitWordImageTest(ICollection<WordImageAnswer> attempts)
        {
            List<int> idList = attempts
                .Select(a => a.Id)
                    .ToList();

            var answers = context.WordImagetests
                .Where(wi => idList.Contains(wi.Id))
                .Select(wi => wi.Word.ToLower())
                .ToList();

            var realanswers = context.WordImagetests
                .Where(wi => idList.Contains(wi.Id))
                .ToList();

            var results = new List<WordImageResponse>();

            foreach (WordImageAnswer attempt in attempts)
            {
                string data = "0";
                var result = answers.Contains(attempt.Word.ToLower());
                if (result)
                {
                    data = "1";
                } 
                var res = new WordImageResponse { Result = data };
                results.Add(res);
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

        public ICollection<bool> SubmitSeparatorTest(string input, string expected)
        {
            var result = new List<bool>();

            // Tar bort alla icke-skiljetecken från expected
            Regex rgx = new Regex("[^" + HelperClasses.Separators + "]");
            rgx.Replace(expected, "");

            for (int i = 0; i < Math.Max(input.Length, expected.Length); i++)
            {
                char c1 = (i < input.Length) ? input[i] : 'a';
                char c2 = (i < expected.Length) ? expected[i] : 'b';
                result.Add(c1 == c2);
            }

            return result;
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