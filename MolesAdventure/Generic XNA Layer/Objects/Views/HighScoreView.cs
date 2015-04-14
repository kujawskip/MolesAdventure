using Generic_Game_Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Game_Engine.Objects.Views
{
    public class StringListView : View
    {
        public StringListView(IDrawable Background,IGame logicalContext,List<IWritable> StringList,List<IWritable> Suffix,List<IWritable> Prefix) : base(Background,logicalContext)
    {
    }
        List<IWritable> Prefix;
        List<IWritable> Suffix;
        List<IWritable> StringList;
    }
}
