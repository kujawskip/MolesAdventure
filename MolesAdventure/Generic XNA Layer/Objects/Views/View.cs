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

        public View(IDrawable Background, IGame logicalContext)
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
            GraphicalContext.End();
        }


        public void AddObject(IPlaceable p)
        {
            Objects.Add(p);
        }

        public void AddObject(IAutoMovable m)
        {
            MovingObjects.Add(m);
            AddObject((IPlaceable)m);
        }

        public void AddObject(IControlable c)
        {
            Controlable.Add(c);
            AddObject((IPlaceable)c);
        }

        public void AddObject(IWritable w)
        {
            WriteObjects.Add(w);
            AddObject((IPlaceable)w);
        }

        public void AddObject(IDrawable d)
        {
            DrawObjects.Add(d);
            AddObject((IPlaceable)d);
        }

        public void RemoveObject(IPlaceable p)
        {
            Objects.Remove(p);
            DrawObjects.Remove(p as IDrawable);
            WriteObjects.Remove(p as IWritable);
            Controlable.Remove(p as IControlable);
            MovingObjects.Remove(p as IAutoMovable);
        }

        public Point GetBorder()
        {
            return LogicalContext.GetViewSize();
        }




        public void HandleCollision(ICollidable c1, ICollidable c2)
        {
            throw new NotImplementedException();
        }


        public IGame GetLogicalContext()
        {
            return LogicalContext;
        }
    }
}
