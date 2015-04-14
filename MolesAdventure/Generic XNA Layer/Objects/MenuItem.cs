using Generic_Game_Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Game_Engine.Objects
{
    public delegate void MenuItemDelegate();
    public class MenuItem : IWritable
    {
        Point location;
        string text;
        IView view;
       

        MenuItemDelegate executor;
        #region IWritable
        public Point GetLocation()
        {
            return location;
        }
        public void SetLocation(Point P)
        {
            location = P;
        }

        public void SetView(IView V)
        {
            this.view = V;
        }

        public IView GetView()
        {
            return view;
        }
        public override string ToString()
        {
            return text;	 
        }
        #endregion
        public void Execute()
        {
            executor();
        }
        public MenuItem(string text, Point location, IView view, MenuItemDelegate executor)
        {
            this.text = text;
            this.location = location;
            this.view = view;
            this.executor = executor;
        }


        public void Append(string s)
        {
            throw new NotImplementedException();
        }

        public void SetString(string s)
        {
            throw new NotImplementedException();
        }
    }
}
