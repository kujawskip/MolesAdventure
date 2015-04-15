using Generic_Game_Engine.Interfaces;
using Generic_Game_Engine.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MolesAdventure.Factories
{
    public class MenuFactory
    {
        private static MenuItem createMenuItem(string text, MenuItemDelegate del)
        {
            MenuItem m = new MenuItem(text, new Point(), null, del);
            return m;
        }
        private static void PrepareMenuItem(ref MenuItem m, IView v, int index, Point Cell, int size)
        {
            Point Loc = Cell;
            Loc.Y *= (index + 1);
            m.SetSize(size);
            m.SetLocation(Loc);
            m.SetView(v);

        }
        private static void PrepareMenuItems(ref List<MenuItem> m, IView v)
        {
            int size = 16 - 2 * (m.Count / 3);
            Point Cell = v.GetBorder();
            Cell.X /= 3;
            Cell.Y /= (m.Count + 1);
            for (int i = 0; i < m.Count; i++)
            {
                var mm = m[i];
                PrepareMenuItem(ref mm, v, i, Cell, size);
            }
        }
        static List<MenuItem> lastCreated;
        public static List<MenuItem> createMainMenuItems()
        {
            List<MenuItem> result = new List<MenuItem>();
            //TODO

            lastCreated = result;
            return result;
        }

        internal static void finish(Generic_Game_Engine.Objects.Views.MenuView M)
        {
            PrepareMenuItems(ref lastCreated, M);
        }
    }
}
