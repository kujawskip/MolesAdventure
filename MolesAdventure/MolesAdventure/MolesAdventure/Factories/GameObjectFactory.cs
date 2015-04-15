using Generic_Game_Engine.Objects;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XNA_Generic_Game_Library;

namespace MolesAdventure.Factories
{
    public class GameObjectFactory
    {
        static public GameObject createSimpleDrawableObject(Texture2D sprite,Point Location)
        {
            var G = new GameObject(null, sprite, Location, null);
            return G;
        }
    }
}
