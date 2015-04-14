using Generic_Game_Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Game_Engine.Objects
{
    public delegate void CollisionEffect(ref IGame LogicalContext,ref ICollidable Colidee);
}
