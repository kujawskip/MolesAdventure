using Generic_Game_Engine.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Game_Engine.Interfaces
{
    public interface ICollidable : IPlaceable
    {
        
        void Damage(int D);
        CollisionEffect GetCollisionEffect();
        void ReactToCollision(CollisionEffect CE);
    }
}
