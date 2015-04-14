using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XNA_Generic_Game_Library;

namespace MolesAdventure.GameObjects.Actors
{
    public class Mole : ControlableObject
    {
        public override Generic_Game_Engine.Objects.CollisionEffect GetCollisionEffect()
        {
            return base.GetCollisionEffect();
        }
        public override Generic_Game_Engine.Objects.Point GetMove(Microsoft.Xna.Framework.Input.KeyboardState K)
        {
            return base.GetMove(K);
        }
        public override void ReactToCollision(Generic_Game_Engine.Objects.CollisionEffect CE)
        {
            base.ReactToCollision(CE);
        }
    }
}
