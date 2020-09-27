using FirstMonoGameProject.src;
using FirstMonoGameProject.src.Game;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstMonoGameProject
{
    class SpriteSheet
    {
        protected Texture2D spriteSheet;
        protected Point size;
        protected int rows;
        protected int columns;
        protected int from;
        protected int to;
        protected int currentFrame;
        protected Rectangle currSource;
        


        public Point Size { get => size; }

        public SpriteSheet(Texture2D spriteSheet, int rows, int columns, int from, int to)
        {
            this.spriteSheet = spriteSheet;
            this.size = new Point(spriteSheet.Width / columns, spriteSheet.Height / rows);
            this.rows = rows;
            this.columns = columns;
            this.from = from;
            this.to = to;
            this.currentFrame = from;
            this.currSource = calculateSourceTriangle();
        }

        protected Rectangle calculateSourceTriangle()
        {
            int nextRow = currentFrame / columns;
            int nextCol = currentFrame % columns;
            return new Rectangle(new Point(nextCol * Size.X, nextRow * Size.Y), Size);
        }

        virtual public void Update(GameTime time)
        {

        }

       virtual public void Draw(GameTime time, Point location)
        {
            Globals.spriteBatch.Draw(spriteSheet, new Rectangle(location, Size), currSource, Color.White, 0.0f, Vector2.Zero, SpriteEffects.None, 1);
        }
    }
}
