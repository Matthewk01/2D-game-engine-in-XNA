using FirstMonoGameProject.src.Game.World;
using FirstMonoGameProject.src.CollisionDetector;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstMonoGameProject.src.Game.Entities
{
    public enum DIRECTION
    {
        NONE,
        LEFT,
        RIGHT,
        UP,
        DOWN
    }

    class Entity : IInputHandler, ICollidable
    {
        private  SpriteSheet currSpriteSheet;
        private  Rectangle boundingBox;
        private  Point speed;
        private  Point velocity;
        readonly private Dictionary<DIRECTION, SpriteSheet> dirToSpritesheet;
        private bool noClip = false;

        public Entity(string texture, Point position)
        {
            Texture2D textureSpriteSheet = Globals.content.Load<Texture2D>(texture);
            SpriteSheet idle = new SpriteSheet(textureSpriteSheet, 4, 4, 0, 0);
            this.currSpriteSheet = idle;
            this.boundingBox = new Rectangle(position, currSpriteSheet.Size);
            this.speed = new Point(120, 120);
            this.velocity = Point.Zero;
            const double ANIM_FRAME_DURATION = 0.07;
            this.dirToSpritesheet = new Dictionary<DIRECTION, SpriteSheet>(4);
            dirToSpritesheet[DIRECTION.NONE] = idle;
            dirToSpritesheet[DIRECTION.DOWN] = new AnimatedSpriteSheet(textureSpriteSheet, 4, 4, 0, 3, ANIM_FRAME_DURATION);
            dirToSpritesheet[DIRECTION.UP] = new AnimatedSpriteSheet(textureSpriteSheet, 4, 4, 8, 11, ANIM_FRAME_DURATION);
            dirToSpritesheet[DIRECTION.RIGHT] = new AnimatedSpriteSheet(textureSpriteSheet, 4, 4, 4, 7, ANIM_FRAME_DURATION);
            dirToSpritesheet[DIRECTION.LEFT] = new AnimatedSpriteSheet(textureSpriteSheet, 4, 4, 12, 15, ANIM_FRAME_DURATION);
        }

        public Point getPosition()
        {
            return boundingBox.Location;
        }

        public void handleKeyboardInput(KeyboardState lastTickstate, KeyboardState currState)
        {
            currSpriteSheet = dirToSpritesheet[DIRECTION.NONE];
            if (currState.IsKeyDown(Keys.Left))
            {
                velocity.X = -speed.X;
                currSpriteSheet = dirToSpritesheet[DIRECTION.LEFT];
            }
            if (currState.IsKeyDown(Keys.Right))
            {
                velocity.X = speed.X;
                currSpriteSheet = dirToSpritesheet[DIRECTION.RIGHT];
            }
            if (currState.IsKeyDown(Keys.Up))
            {
                velocity.Y = -speed.Y;
                currSpriteSheet = dirToSpritesheet[DIRECTION.UP];
            }
            if (currState.IsKeyDown(Keys.Down))
            {
                velocity.Y = speed.Y;
                currSpriteSheet = dirToSpritesheet[DIRECTION.DOWN];
            }
            if (currState.IsKeyDown(Keys.F) && !lastTickstate.IsKeyDown(Keys.F))
            {
                noClip = !noClip;
            }

        }

        public void handleMouseInput(MouseState lastTickstate, MouseState currState)
        {
            
        }

        public void Update(GameTime gameTime)
        {
            double elapsedTIme = gameTime.ElapsedGameTime.TotalSeconds;
            boundingBox.Offset((int) (velocity.X * elapsedTIme), (int)(velocity.Y * elapsedTIme));
            velocity = Point.Zero;
            currSpriteSheet.Update(gameTime);
        }

        public void Draw(GameTime time)
        {
            // Globals.spriteBatch.Draw(texture, boundingBox, Color.Purple);
            currSpriteSheet.Draw(time, getPosition());
        }

        public void onCollisionWith(ICollidable obj, CollisioDirection dir)
        {
            if (noClip)
                return;
           // Console.WriteLine("Collided!");
            if(obj is WorldTile)
            {
                switch (dir)
                {
                    case CollisioDirection.HORIZONTAL:
                        this.velocity.X = 0;
                        break;
                    case CollisioDirection.VERTICAL:
                        this.velocity.Y = 0;
                        break;
                    case CollisioDirection.BOTH:
                    case CollisioDirection.NONE:
                    default:
                        this.velocity = Point.Zero;
                        break;
                }
            }
        }

        public Tuple<Rectangle, Point> getBoundingBoxAndVel()
        {
            return new Tuple<Rectangle, Point>(boundingBox, this.velocity);
        }
    }
}
