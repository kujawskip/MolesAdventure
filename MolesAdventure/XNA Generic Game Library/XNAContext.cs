using Generic_Game_Engine.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XNA_Generic_Game_Library.Extenders;
namespace XNA_Generic_Game_Library
{
    public class XNAContext : IContext
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private SpriteFont spriteFont;
        private Color writeColor;
        public void Draw(Generic_Game_Engine.Interfaces.IDrawable D)
        {
            if (!(D is GameObject)) throw new ArgumentException("Object must be of type GameObject");
            GameObject O = (D as GameObject);
            spriteBatch.Draw(O.GetTexture(), D.GetLocation().ToVector2(), Color.White);
        }

        public void Prepare()
        {
            graphics.GraphicsDevice.Clear(Color.White);
        }

        public XNAContext(GraphicsDeviceManager graphics, SpriteBatch spriteBatch,SpriteFont writeFont,Color writeColor)
        {
            // TODO: Complete member initialization
            this.graphics = graphics;
            this.spriteBatch = spriteBatch;
            this.spriteFont = writeFont;
            this.writeColor = writeColor;
        }


        public void Draw(IWritable W)
        {
            spriteBatch.DrawString(spriteFont, W.ToString(), W.GetLocation().ToVector2(), writeColor);
        }


        public void DrawFielded(Generic_Game_Engine.Interfaces.IDrawable D, Generic_Game_Engine.Objects.Point FieldSize, Generic_Game_Engine.Objects.Point FieldStart)
        {
            if (!(D is GameObject)) throw new ArgumentException("Object must be of type GameObject");
            Generic_Game_Engine.Objects.Point TrueLocation = D.GetLocation();
            TrueLocation.X *= FieldSize.X;
            TrueLocation.Y *= FieldSize.Y;
            TrueLocation.X += FieldStart.X;
            TrueLocation.Y += FieldStart.Y;
            spriteBatch.Draw((D as GameObject).GetTexture(),TrueLocation.ToVector2(), Color.White);
        }
    }
}
