using Generic_Game_Engine.Interfaces;
using Generic_Game_Engine.Objects;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XNA_Generic_Game_Library
{
    public class GameObject : IDrawable,ICollidable
    {
	CollisionEffect collisionEffect {get;set;}
	Texture2D texture;
	Generic_Game_Engine.Objects.Point location;
	IView view;
	public GameObject(CollisionEffect CE,Texture2D sprite,Generic_Game_Engine.Objects.Point location,IView view)
	{
		texture=sprite;
		collisionEffect = CE;
		this.location = location;
		this.view = view;
	}
        public Microsoft.Xna.Framework.Graphics.Texture2D GetTexture()
        {
            return texture;
        }

        public Generic_Game_Engine.Objects.Point GetLocation()
        {
            return location;
        }

        public void SetLocation(Generic_Game_Engine.Objects.Point P)
        {
            location = P;
        }
        public IView GetView()
        {
            return view;
        }
        public void SetView(IView V)
        {
           	view = V;
        }

        
        public virtual void Damage(int D)
        {
            
        }

        public virtual Generic_Game_Engine.Objects.CollisionEffect GetCollisionEffect()
        {
            return collisionEffect;
        }

        public virtual void ReactToCollision(Generic_Game_Engine.Objects.CollisionEffect CE)
        {
            var LogicalContext = GetView().GetLogicalContext();
            ICollidable ThisObject = this;
            CE(ref LogicalContext, ref ThisObject);
        }
    }
}
