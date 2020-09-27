using FirstMonoGameProject.src;
using FirstMonoGameProject.src.Game;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstMonoGameProject
{
    class AnimatedSpriteSheet : SpriteSheet
    {
        private double elapsedTime;
        private double durationTime;
        private bool drawFlipped;
        public bool DrawFlipped { get => drawFlipped; set => drawFlipped = value; }

        public AnimatedSpriteSheet(Texture2D spriteSheet, int rows, int columns, int from, int to, double durationTime) : base(spriteSheet, rows, columns, from, to)
        {
            this.elapsedTime = 0;
            this.durationTime = durationTime;
            this.DrawFlipped = false;
            this.currSource = calculateSourceTriangle();
        }

        public override void Update(GameTime time)
        {
            elapsedTime += time.ElapsedGameTime.TotalSeconds;
            if (elapsedTime > durationTime)
            {
                currentFrame = currentFrame == to ? this.from : currentFrame + 1;
                elapsedTime -= durationTime;
                currSource = calculateSourceTriangle();
            }
        }

    }
}
