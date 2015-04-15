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
          return Location;
        }

        public void SetLocation(Point P)
        {
            Location=P;
        }

        public void SetView(IView V)
        {
            view = (MenuView)V;
        }

        public IView GetView()
        {
            return view;
        }
	int lastMove;
        public void Move(Point P)
        {
		if(P.Y!=0) lastMove = P.Y;
            if(P.Y > 0)
	    {
		index = view.GetNextIndex(index);
	    }
	    else if(P.Y < 0)
	    {
		index = view.GetPreviousIndex(index);
	    }
        }

        public Point GetMove(Microsoft.Xna.Framework.Input.KeyboardState K)
        {
            if(K.IsKeyDown(view.GetLogicalContext().GetDownKey()))
	    {
		    return new Point(0,-1);
	    }
	    else if(K.IsKeyDown(view.GetLogicalContext().GetUpKey()))
	    {
	    		return new Point(0,1);
	    }
            return new Point(0, 0);
   
        }


        public void ReverseMove()
        {
            Move(new Point(0,lastMove));
        }
    }
}
