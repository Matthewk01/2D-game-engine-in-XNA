﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FirstMonoGameProject.src.Game.World.levels
{
    class Level1 : ILevel
    {
        public TILE_TYPE[,] Data => new TILE_TYPE[,] {
            { TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.NONE, TILE_TYPE.WALL },
            { TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL, TILE_TYPE.WALL },
        };
    }
}
