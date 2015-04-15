using Generic_Game_Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Game_Engine.Objects.Views
{
    public class View : IView
    {
        protected List<IPlaceable> Objects;
        protected List<IAutoMovable> MovingObjects;
        protected List<IDrawable> DrawObjects;
        protected List<IControlable> Controlable;
        protected List<IWritable> WriteObjects;
        protected IDrawable Background;
        protected IGame LogicalContext;
        
        public View(IDrawable Background,IGame logicalContext)
        {
            Objects = new List<IPlaceable>();
            MovingObjects = new List<IAutoMovable>();
            DrawObjects = new List<IDrawable>();
            Controlable = new List<IControlable>();
            WriteObjects = new List<IWritable>();
            this.Background = Background;
            this.LogicalContext = logicalContext;
          //  this.GraphicalContext = graphicalContext;
        }
        public virtual void Update()
        {
            foreach (IAutoMovable movable in MovingObjects)
            {
                movable.Move(movable.GetMove());
            }
            foreach (IControlable controlable in Controlable)
            {
                controlable.Move(controlable.GetMove(GetLogicalContext().GetKeyboardState()));
            }
        }

     
        public virtual void Draw()
        {
            var GraphicalContext = LogicalContext.GetGraphicalContext();
            GraphicalContext.Prepare();
            GraphicalContext.Draw(Background);
            foreach (IDrawable drawable in DrawObjects)
            {
                GraphicalContext.Draw(drawable);
            }
            foreach (IWritable writable in WriteObjects)
            {
                GraphicalContext.Draw(writable);
            }
        }


        public void AddObject(IPlaceable p)
        {
            throw new NotImplementedException();
        }

        public void AddObject(IAutoMovable m)
        {
            throw new NotImplementedException();
        }

        public void AddObject(IControlable c)
        {
            throw new NotImplementedException();
        }

        public void AddObject(IWritable w)
        {
            throw new NotImplementedException();
        }

        public void AddObject(IDrawable d)
        {
            throw new NotImplementedException();
        }

        public void RemoveObject(IPlaceable p)
        {
            throw new NotImplementedException();
        }

        public Point GetBorder()
        {
            throw new NotImplementedException();
        }




        public void HandleCollision(ICollidable c1, ICollidable c2)
        {
            throw new NotImplementedException();
        }


        public IGame GetLogicalContext()
        {
            throw new NotImplementedException();
        }
    }
}
