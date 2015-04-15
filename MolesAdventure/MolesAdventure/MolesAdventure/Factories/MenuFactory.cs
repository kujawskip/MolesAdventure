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
        private static MenuItem createMenuItem(string text, MenuItemDelegate del,int index=0)
        {
            MenuItem m = new MenuItem(text, new Point(0,index), null, del);
            return m;
        }
        private static void PrepareMenuItem(ref MenuItem m, IView v, int index, Point Cell, int size,int NameSize)
        {
            Point Loc = Cell;
            Loc.Y *= (index);
            Loc.Y += NameSize;
            m.SetSize(size);
            m.SetLocation(Loc);
            m.SetView(v);

        }
        private static void PrepareMenuItems(ref List<MenuItem> m, IView v,int NameSize)
        {
            int size = 16 - 2 * (m.Count / 3);
            Point Cell = v.GetBorder();
            Cell.X /= 3;
            Cell.Y -= NameSize;
            Cell.Y /= (m.Count + 1);
            for (int i = 0; i < m.Count; i++)
            {
                var mm = m[i];
                PrepareMenuItem(ref mm, v, i, Cell, size, NameSize);
            }
        }
        static List<MenuItem> lastCreated;
        internal static List<MenuItem> createMainMenuItems()
        {
            List<MenuItem> result = new List<MenuItem>();
            //TODO
            result.Add(createMenuItem("Nowa Gra", Adventure.GetInstance().StartGame));
            result.Add(createMenuItem("Wczytaj Gre", Adventure.GetInstance().LoadGame,1));
            result.Add(createMenuItem("Opcje", Adventure.GetInstance().ChangeOptions,2));
            result.Add(createMenuItem("Pomoc", Adventure.GetInstance().ViewHelp,3));
            result.Add(createMenuItem("Najlepsze Wyniki", Adventure.GetInstance().ViewHighScores,4));
            result.Add(createMenuItem("Koniec Gry", Adventure.GetInstance().Quit,5));

            lastCreated = result;
            return result;
        }

        internal static void finish(Generic_Game_Engine.Objects.Views.MenuView M,int NameSize)
        {
            PrepareMenuItems(ref lastCreated, M, NameSize);
        }
    }
}
