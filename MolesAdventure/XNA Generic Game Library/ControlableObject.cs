using Generic_Game_Engine.Interfaces;
using Generic_Game_Engine.Objects;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XNA_Generic_Game_Library
{
    public class ControlableObject : GameObject,IControlable
    {
        public ControlableObject(CollisionEffect CE, Texture2D sprite, Generic_Game_Engine.Objects.Point location, IView view) : base(CE,sprite,location,view)
        {
        }

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
