using System;
using System.Collections.Generic;
using System.Text;

namespace FirstMonoGameProject.src.Game.World.levels
{
    interface ILevel
    {
        TILE_TYPE[,] Data { get; }
    }
}
