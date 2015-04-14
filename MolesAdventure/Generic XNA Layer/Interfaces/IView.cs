using Generic_Game_Engine.Objects;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Game_Engine.Interfaces
{
    public interface IView
    {
        void Update();
        void Draw();
        void AddObject(IPlaceable p);
        void AddObject(IAutoMovable m);
        void AddObject(IControlable c);
        void AddObject(IWritable w);
        void AddObject(IDrawable d);
        void RemoveObject(IPlaceable p);
        Point GetBorder();
        void HandleCollision(ICollidable c1, ICollidable c2);

        IGame GetLogicalContext();
    }
}
