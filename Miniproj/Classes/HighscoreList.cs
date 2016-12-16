using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miniproj.Classes
{
    public class HighscoreList
    {
        private int Capacity;
        private List<HighscoreEntry> Highscores { get; set; }

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

        public int InsertEntryIfValid(HighscoreEntry entry)
        {
            if (entry.Score < Highscores[Capacity - 1].Score)
            {
                return -1;
            }

            for (int i = 0; i < Capacity; i++)
            {
                if (entry.Score >= Highscores[i].Score)
                {
                    Highscores.Insert(i, entry);
                    Highscores.RemoveAt(Capacity);
                    return i;
                }
            }

            throw new Exception("Fel!");
        }
    }
}