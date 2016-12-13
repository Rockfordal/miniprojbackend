using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miniproj.Classes
{
    public class HighscoreList
    {
        private int Capacity;
        public List<HighscoreEntry> Highscores { get; set; }

        public HighscoreList(int capacity = 10)
        {
            Capacity = capacity;
            Highscores = new List<HighscoreEntry>();
        }

        public void Populate(List<HighscoreEntry> entries)
        {
            if (Highscores.Count() > 0)
            {
                throw new Exception("List is already populated");
            }

            if (entries.Count() != Capacity)
            {
                throw new ArgumentException("Number of entries must equal capacity");
            }

            Highscores = entries;
        }
    }
}