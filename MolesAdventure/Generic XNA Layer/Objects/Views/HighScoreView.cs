using Generic_Game_Engine.Interfaces;
using Generic_Game_Engine.Objects.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Game_Engine.Objects.Views
{
    public class StringListView : View
    {
	    int range;
	    MenuCursor mc;
        public StringListView(IDrawable Background,IGame logicalContext,List<IWritable> StringList,List<IWritable> Suffix,List<IWritable> Prefix,int range) : base(Background,logicalContext)
    {
	    this.range = range;
    }

        List<IWritable> Prefix;
        List<IWritable> Suffix;
        List<IWritable> StringList;
    }
}
