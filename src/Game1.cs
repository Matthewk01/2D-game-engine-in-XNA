using FirstMonoGameProject.src;
using FirstMonoGameProject.src.Game;
using FirstMonoGameProject.src.Game.Entities;
using FirstMonoGameProject.src.Game.World;
using FirstMonoGameProject.src.CollisionDetector;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Media;

namespace FirstMonoGameProject
{
    public class Game1 : Game
    {
        // Singletons
        Entity player;
        World world;
        Camera camera;
        InputManager inputManager;
        CollisionDetector collisionDetector;


        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Globals.content = this.Content;
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            // _graphics.IsFullScreen = true;
            _graphics.ApplyChanges();
            this.Window.Title = "Monogame framework";
            Window.AllowUserResizing = true;

            inputManager = new InputManager();
            collisionDetector = new CollisionDetector();
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Globals.spriteBatch = _spriteBatch;
            base.Initialize();
            
        }

        protected override void LoadContent()
        {
            world = new World();
            player = new Entity("NPC_test", new Point(150, 150));
            inputManager.registerHandler(player);
            camera = new Camera(player, _graphics.GraphicsDevice.Viewport);
            collisionDetector.registerCollidable(player);
            collisionDetector.registerCollidables(world.getCollidables());
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            inputManager.Update(gameTime);
            collisionDetector.Update(gameTime);
            player.Update(gameTime);
            camera.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.AntiqueWhite);

            _spriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.AlphaBlend, transformMatrix: camera.Transform);

            // FPS
            double frameRate = 1.0 / gameTime.ElapsedGameTime.TotalSeconds;
            Console.WriteLine(frameRate);
            world.Draw(gameTime);
            player.Draw(gameTime);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
