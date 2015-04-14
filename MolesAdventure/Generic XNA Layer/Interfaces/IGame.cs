using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
namespace Generic_Game_Engine.Interfaces
{
    public interface IGame
    {
        KeyboardState GetKeyboardState();
        IContext GetGraphicalContext();
        string GetPlayerName();
        int GetScore();
        void SetScore(int score);
        void AddScore(int score);
        void SaveGame();
        void Quit();
         
    }
}
