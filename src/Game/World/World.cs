using FirstMonoGameProject.src.Game.Entities;
using FirstMonoGameProject.src.Game.World;
using FirstMonoGameProject.src.Game.World.levels;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstMonoGameProject.src
{
    public enum TILE_TYPE
    {
        NONE,
        WALL,
        STONE,
        PATH,
        WATER,
        GRASS,
    }

    class World
    {
        private TILE_TYPE[,] worldTemplate;
        Texture2D worldBg;
        List<WorldTile> tiles;
        int rows;
        int columns;
        const int TILE_SIZE = 16;

        public List<ICollidable> getCollidables()
        {
            return tiles.OfType<ICollidable>().ToList();
        }

        public World()
        {
            this.worldTemplate = new Level0().Data;
            this.worldBg = null;
            this.tiles = new List<WorldTile>();
            rows = (int)worldTemplate.GetLongLength(0);
            columns = (int)worldTemplate.GetLongLength(1);
            generateWorld();
        }

        private void generateWorld()
        {
            Texture2D tile0 = Globals.content.Load<Texture2D>("tile0");
            Texture2D tile1 = Globals.content.Load<Texture2D>("2764966_1");
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; ++j)
                {
                    switch (this.worldTemplate[i, j])
                    {
                        case TILE_TYPE.NONE:
                            break;
                        case TILE_TYPE.WALL:
                            tiles.Add(new WorldTile(tile1, initBoundingBox(i, j)));
                            break;
                        case TILE_TYPE.STONE:
                            break;
                        case TILE_TYPE.PATH:
                            break;
                        case TILE_TYPE.WATER:
                            break;
                        case TILE_TYPE.GRASS:
                            break;
                        default:
                            throw new Exception("Template mapy error!");
                    }
                }
            }
        }

        private Rectangle initBoundingBox(int i, int j)
        {
            return new Rectangle(j * TILE_SIZE, i * TILE_SIZE, TILE_SIZE, TILE_SIZE);
        }

        public void Draw(GameTime gameTime)
        {
            foreach (WorldTile tile in tiles)
            {
                tile.Draw(gameTime);
            }
        }
    }
}
