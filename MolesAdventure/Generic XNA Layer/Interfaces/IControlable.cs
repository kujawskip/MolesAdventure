using Generic_Game_Engine.Objects;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Game_Engine.Interfaces
{
    public interface IControlable : IMovable
    {
        
        Point GetMove(KeyboardState K);
    }
}
