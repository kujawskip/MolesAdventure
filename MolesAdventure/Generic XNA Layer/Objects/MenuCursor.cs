using Generic_Game_Engine.Interfaces;
using Generic_Game_Engine.Objects.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Game_Engine.Objects.Objects
{
    public class MenuCursor : IDrawable,IControlable
    {
        string text;
        Point Location;
        int index;

        MenuView view;
        public Point GetLocation()
        {
            throw new NotImplementedException();
        }

        public void SetLocation(Point P)
        {
            throw new NotImplementedException();
        }

        public void SetView(IView V)
        {
            throw new NotImplementedException();
        }

        public IView GetView()
        {
            throw new NotImplementedException();
        }

        public void Move(Point P)
        {
            throw new NotImplementedException();
        }

        public Point GetMove(Microsoft.Xna.Framework.Input.KeyboardState K)
        {
            throw new NotImplementedException();
   
        }


        public void ReverseMove()
        {
            throw new NotImplementedException();
        }
    }
}
