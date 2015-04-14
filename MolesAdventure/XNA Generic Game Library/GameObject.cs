﻿using Generic_Game_Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XNA_Generic_Game_Library
{
    public class GameObject : IDrawable,ICollidable
    {
        public Microsoft.Xna.Framework.Graphics.Texture2D GetTexture()
        {
            throw new NotImplementedException();
        }

        public Generic_Game_Engine.Objects.Point GetLocation()
        {
            throw new NotImplementedException();
        }

        public void SetLocation(Generic_Game_Engine.Objects.Point P)
        {
            throw new NotImplementedException();
        }
        public IView GetView()
        {
            throw new NotImplementedException();
        }
        public void SetView(IView V)
        {
            throw new NotImplementedException();
        }

        
        public virtual void Damage(int D)
        {
            throw new NotImplementedException();
        }

        public virtual Generic_Game_Engine.Objects.CollisionEffect GetCollisionEffect()
        {
            throw new NotImplementedException();
        }

        public virtual void ReactToCollision(Generic_Game_Engine.Objects.CollisionEffect CE)
        {
            var LogicalContext = GetView().GetLogicalContext();
            ICollidable ThisObject = this;
            CE(ref LogicalContext, ref ThisObject);
        }
    }
}
