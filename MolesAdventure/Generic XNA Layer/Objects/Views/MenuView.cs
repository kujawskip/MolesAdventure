using Generic_Game_Engine.Interfaces;
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
        public MenuView(IDrawable Background,IGame logicalContext,List<MenuItem> menuItems) : base( Background,logicalContext)
        {
            items = menuItems;
            items.Sort((S, P) => (-S.GetLocation().Y.CompareTo(P.GetLocation().Y)));
            foreach (MenuItem MI in items)
            {
                Objects.Add(MI);
                WriteObjects.Add(MI);
            }

        }
        public override void Update()
        {
            
            base.Update();
        }
        public override void Draw()
        {
            base.Draw();
        }

        internal int GetNextIndex(int index)
        {
            throw new NotImplementedException();
        }

        internal int GetPreviousIndex(int index)
        {
            throw new NotImplementedException();
        }

        internal void ExecuteMenuOption(int index)
        {
            items[index].Execute();
        }
    }
}
