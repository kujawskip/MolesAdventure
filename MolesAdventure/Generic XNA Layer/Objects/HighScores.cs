using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Game_Engine.Objects
{
    public class HighScores
    {
        public HighScores(List<Tuple<string, int>> Scores)
        {
        }
        public void Add(Tuple<string, int> score)
        {
        }
        public void Save(string path)
        {
        }
        public static HighScores LoadHighscores(string path)
        {
            return null;
        }
    }
}
