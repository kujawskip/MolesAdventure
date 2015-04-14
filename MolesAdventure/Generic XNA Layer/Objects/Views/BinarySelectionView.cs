using Generic_Game_Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Game_Engine.Objects.Views
{
    public class BinarySelectionView : View
    {
        List<MenuItem> BinarySelectors;
        List<IWritable>[] Selectors;
        int currentSelector;
        public BinarySelectionView(IDrawable Background, IGame logicalContext,List<MenuItem> binarySelectors,List<IWritable>[] selectors)
            : base(Background, logicalContext)
        {
            currentSelector = 0;
            isSelectorUsed = false;
        }
        bool isSelectorUsed;
        void UseSelector(int index)
        {
            throw new NotImplementedException();   
        }
        void StopSelector()
        {
            throw new NotImplementedException();
        }
    }
}
