using Generic_Game_Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XNA_Generic_Game_Library;

namespace MolesAdventure.GameObjects.Bonuses
{
    public class Bonus : GameObject
    {

        public override void Damage(int D)
        {
            return;
        }

        public override Generic_Game_Engine.Objects.CollisionEffect GetCollisionEffect()
        {
            throw new NotImplementedException();
        }

      

     
    }
}
