using FirstMonoGameProject.src.CollisionDetector;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstMonoGameProject.src.Game.Entities
{
    interface ICollidable 
    {
        public void onCollisionWith(ICollidable obj, CollisioDirection dir);

        public Tuple<Rectangle, Point> getBoundingBoxAndVel();

    }
}
