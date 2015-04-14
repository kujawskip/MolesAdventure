using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XNA_Generic_Game_Library;

namespace MolesAdventure.GameObjects.Enemies
{
    class Enemy : MovingObject
    {
        public override void Damage(int D)
        {
            base.Damage(D);
        }
        public override Generic_Game_Engine.Objects.CollisionEffect GetCollisionEffect()
        {
            throw new NotImplementedException();
        }
    }
}
