using Generic_Game_Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Game_Engine.Objects.Views
{
    public class StringInputView : View
    {
        IWritable writer;
        public StringInputView(IDrawable Background,IGame logicalContext) : base(Background,logicalContext)
        {
           
          //  this.GraphicalContext = graphicalContext;
        }
    }
}
