using FirstMonoGameProject.src.Game.Entities;
using FirstMonoGameProject.src.CollisionDetector;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstMonoGameProject.src.Game.World
{
    class WorldTile : ICollidable
    {
        private Texture2D tile;
        private Rectangle boundingBox;

        public WorldTile(Texture2D tile, Rectangle boundingBox)
        {
            this.Tile = tile;
            this.boundingBox = boundingBox;
        }

        public Texture2D Tile { get => tile; set => tile = value; }
        public Rectangle BoundingBox { get => boundingBox; set => boundingBox = value; }
    
        public void Draw(GameTime time)
        {
            Globals.spriteBatch.Draw(tile, boundingBox, Color.White);
        }

        public Tuple<Rectangle, Point> getBoundingBoxAndVel()
        {
            return new Tuple<Rectangle, Point>(boundingBox, Point.Zero);
        }

        public void onCollisionWith(ICollidable obj, CollisioDirection dir)
        {
           
        }
    }
}
