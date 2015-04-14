using Generic_Game_Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XNA_Generic_Game_Library
{
    public class MovingObject : GameObject,IAutoMovable
    {

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
