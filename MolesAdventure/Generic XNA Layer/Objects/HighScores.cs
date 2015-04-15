using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
namespace Generic_Game_Engine.Objects
{
	[Serializable]
    public class HighScores
    {
 	public	List<Tuple<string, int>> Scores {get; private set; }
        public HighScores(List<Tuple<string, int>> Scores)
        {
		this.Scores=Scores;	
        }
        public void Add(Tuple<string, int> score)
        {
		Scores.Add(score);
        }
        public void Save(string path)
        {
		IFormatter formatter = new BinaryFormatter();
		Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
		formatter.Serialize(stream, this);
		stream.Close();
        }
        public static HighScores LoadHighscores(string path)
        {
           	IFormatter formatter = new BinaryFormatter();
		Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
		object obj = formatter.Deserialize(stream);
		stream.Close();
		return (HighScores)obj;
 
        }
    }
}
