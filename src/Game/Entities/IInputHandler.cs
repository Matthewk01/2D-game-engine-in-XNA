using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstMonoGameProject.src.Game.Entities
{
    interface IInputHandler
    {
        public void handleMouseInput(MouseState lastTickstate, MouseState currState);

        public void handleKeyboardInput(KeyboardState lastTickstate, KeyboardState currState);
    }
}
