using Generic_Game_Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Game_Engine.Objects.Views
{
    public class GameView : View
    {
        IPlaceable[,] Field;
        public GameView(IDrawable Background, IGame logicalContext)
            : base(Background, logicalContext)
        {
        }
        public void AddScore(int amount)
        {
            LogicalContext.AddScore(amount);
        }
        public override void Update()
        {
            base.Update();
        }
        public override void Draw()
        {
            base.Draw();
        }
    }
}
