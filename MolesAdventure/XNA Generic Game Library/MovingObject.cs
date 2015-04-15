using Generic_Game_Engine.Interfaces;
using Generic_Game_Engine.Objects;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XNA_Generic_Game_Library
{
    public class MovingObject : GameObject,IAutoMovable
    {
         public MovingObject(CollisionEffect CE, Texture2D sprite, Generic_Game_Engine.Objects.Point location, IView view) : base(CE,sprite,location,view)
        {
        }
        Generic_Game_Engine.Objects.Point LastMove;
        public virtual Generic_Game_Engine.Objects.Point GetMove()
        {
            throw new NotImplementedException();
        }

        public virtual void Move(Generic_Game_Engine.Objects.Point P)
        {
            LastMove = P;

        }

        public virtual void ReverseMove()
        {
            throw new NotImplementedException();
        }
    }
}
