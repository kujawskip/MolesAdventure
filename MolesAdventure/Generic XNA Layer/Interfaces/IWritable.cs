using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Game_Engine.Interfaces
{
    public interface IWritable : IPlaceable
    {
        string ToString();
        void Append(string s);
        void SetString(string s);
    }
}
