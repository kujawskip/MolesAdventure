using Generic_Game_Engine.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Game_Engine.Interfaces
{
    public interface IPlaceable
    {
        Point GetLocation();
        void SetLocation(Point P);
        void SetView(IView V);
        IView GetView();
    }
}
