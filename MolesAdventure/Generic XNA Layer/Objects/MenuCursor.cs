using Generic_Game_Engine.Interfaces;
using Generic_Game_Engine.Objects.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Game_Engine.Objects.Objects
{
    public class MenuCursor : IWritable,IControlable
    {
        string text;
        int size;
        Point Location;
        int index;
        public MenuCursor(MenuView m)
        {
            index = 0;
            view = m;
            text = ">";
            size = 16;
        }
        MenuView view;
        public Point GetLocation()
        {
            var P = view.GetCursorLocationByIndex(index);
            return P;
        }

        public void SetLocation(Point P)
        {
           
        }
        public override string ToString()
        {
            return text;
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


        public void Append(string s)
        {
            throw new NotImplementedException();
        }

        public void SetString(string s)
        {
            throw new NotImplementedException();
        }

        public void SetSize(int s)
        {
            throw new NotImplementedException();
        }

        public int GetSize()
        {
            return size;
        }

        internal int GetIndex()
        {
            return index;
        }
    }
}
