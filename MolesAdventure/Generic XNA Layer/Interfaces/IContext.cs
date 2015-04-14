using Generic_Game_Engine.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Game_Engine.Interfaces
{
    public interface IContext
    {
        /// <summary>
        /// Metoda do rysowania obiektu typu IDrawable
        /// </summary>
        /// <param name="D"> obiekt IDrawable do narysowania</param>
        void Draw(IDrawable D);
        /// <summary>
        /// Metoda przygotuwująca kontekst graficzny do rysowania
        /// </summary>
        void Prepare();
        void Draw(IWritable W);
        void DrawFielded(IDrawable W, Point FieldSize,Point FieldStart);
    }
}
