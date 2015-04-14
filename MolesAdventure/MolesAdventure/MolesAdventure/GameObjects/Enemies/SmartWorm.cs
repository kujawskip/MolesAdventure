using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MolesAdventure.GameObjects.Enemies
{
    class SmartWorm : Enemy
    {

        public override Generic_Game_Engine.Objects.CollisionEffect GetCollisionEffect()
        {
            throw new NotImplementedException();
        }
        public override Generic_Game_Engine.Objects.Point GetMove()
        {
            return base.GetMove();
        }
    }
}
