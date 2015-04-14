using Generic_Game_Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XNA_Generic_Game_Library
{
    public class ControlableObject : GameObject,IControlable
    {
        

        public virtual Generic_Game_Engine.Objects.Point GetMove(Microsoft.Xna.Framework.Input.KeyboardState K)
        {
            throw new NotImplementedException();
        }

        public void Move(Generic_Game_Engine.Objects.Point P)
        {
            throw new NotImplementedException();
        }

        public void ReverseMove()
        {
            throw new NotImplementedException();
        }
    }
}
