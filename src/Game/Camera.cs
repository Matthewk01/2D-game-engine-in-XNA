using FirstMonoGameProject.src.Game.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstMonoGameProject.src.Game
{
    class Camera
    {
        Entity target;
        Viewport viewport;
        Matrix transform;

        public Camera(Entity target, Viewport viewport)
        {
            this.target = target;
            this.viewport = viewport;
        }

        public Matrix Transform { get => transform; set => transform = value; }

        public void Update(GameTime gameTime)
        {
            Vector2 targetPosition = new Vector2(target.getPosition().X, target.getPosition().Y);
           // targetPosition = Vector2.Clamp(targetPosition, Vector2.Zero, new  Vector2(200, 200));
            this.transform = Matrix.CreateTranslation(-targetPosition.X , -targetPosition.Y, 0.0f) * Matrix.CreateScale(2.0f, 2.0f, 1.0f) * Matrix.CreateTranslation(viewport.Width * 0.5f, viewport.Height * 0.5f, 0.0f);
        }

    }
}
