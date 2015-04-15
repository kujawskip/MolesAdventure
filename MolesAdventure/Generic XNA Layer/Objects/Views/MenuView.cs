using Generic_Game_Engine.Interfaces;
using Generic_Game_Engine.Objects.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Game_Engine.Objects.Views
{
    public class MenuView : View
    {
        List<MenuItem> items;
        MenuCursor mc;
        public MenuView(IDrawable Background,IGame logicalContext,List<MenuItem> menuItems) : base( Background,logicalContext)
        {
            items = menuItems;
            items.Sort((S, P) => (S.GetLocation().Y.CompareTo(P.GetLocation().Y)));
            mc = new MenuCursor(this);
            AddObject((IWritable)mc);
            AddObject((IControlable)mc);
            foreach (MenuItem MI in items)
            {
                Objects.Add(MI);
                WriteObjects.Add(MI);
            }

        }
        public override void Update()
        {
            if (GetLogicalContext().GetKeyboardState().IsKeyDown(GetLogicalContext().GetAcceptKey())) ExecuteMenuOption(mc.GetIndex());
            base.Update();
        }
        public override void Draw()
        {
            base.Draw();
        }
        private int GetIndex(int index, int dindex)
        {
            while (dindex < 0) dindex += items.Count;
            return (index + dindex) % items.Count;
        }
        internal int GetNextIndex(int index)
        {
            return GetIndex(index, 1);
        }

        internal int GetPreviousIndex(int index)
        {
            return GetIndex(index, 0);
        }

        internal void ExecuteMenuOption(int index)
        {
            items[index].Execute();
        }

        internal Point GetCursorLocationByIndex(int index)
        {
            Point P = items[index].GetLocation();
            P.X -= GetBorder().X / 6;
            return P;
        }
    }
}
