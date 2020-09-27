using FirstMonoGameProject.src.Game.Entities;
using FirstMonoGameProject.src.Game.World;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstMonoGameProject.src.CollisionDetector
{
    public enum CollisioDirection
    {
        HORIZONTAL, VERTICAL, BOTH, NONE
    }
    class CollisionDetector
    {
        public List<ICollidable> collidables;

        public CollisionDetector()
        {
            this.collidables = new List<ICollidable>();
        }

        public void registerCollidables(List<ICollidable> collidables)
        {
            this.collidables.AddRange(collidables);
        }
        public void registerCollidable(ICollidable collidable)
        {
            this.collidables.Add(collidable);
        }

        public void removeCollidable(ICollidable collidable)
        {
            this.collidables.Remove(collidable);
        }

        public void Update(GameTime gameTime)
        {
            int size = collidables.Count;
            for (int i = 0; i < size; ++i)
            {
                for (int j = i + 1; j < size; ++j)
                {
                    ICollidable collidable1 = collidables[i];
                    ICollidable collidable2 = collidables[j];
                    if (collidable1 is WorldTile && collidable2 is WorldTile)
                        continue;
                    if (collidable1 != collidable2)
                    {
                        double timePassed = gameTime.ElapsedGameTime.TotalSeconds;
                        var boxVelData1 = collidable1.getBoundingBoxAndVel();
                        var boxVelData2 = collidable2.getBoundingBoxAndVel();
                        Rectangle box1 = boxVelData1.Item1;
                        Rectangle box2 = boxVelData2.Item1;
                        box1.Offset(new Point((int)(boxVelData1.Item2.X * timePassed), 0));
                        box2.Offset(new Point((int)(boxVelData2.Item2.X * timePassed), 0));
                        CollisioDirection dir = CollisioDirection.NONE;
                        bool collided = false;
                        if (box1.Intersects(box2))
                        {
                            dir = CollisioDirection.HORIZONTAL;
                            collided = true;
                        }
                        box1 = boxVelData1.Item1;
                        box2 = boxVelData2.Item1;
                        box1.Offset(new Point(0, (int)(boxVelData1.Item2.Y * timePassed)));
                        box2.Offset(new Point(0, (int)(boxVelData2.Item2.Y * timePassed)));
                        if (box1.Intersects(box2))
                        {
                            dir = collided ? CollisioDirection.BOTH : CollisioDirection.VERTICAL;
                            collided = true;
                        }
                        if (collided)
                        {
                            collidable1.onCollisionWith(collidable2, dir);
                            collidable2.onCollisionWith(collidable1, dir);
                        }
                    }
                }
            }
        }
    }
}
