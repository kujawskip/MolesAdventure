using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XNA_Generic_Game_Library.Extenders
{
    static public class PointExtender
    {
        static public Vector2 ToVector2(this Generic_Game_Engine.Objects.Point P)
        {
            return new Vector2(P.X, P.Y);
        }
    }
}
