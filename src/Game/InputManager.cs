using FirstMonoGameProject.src.Game.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstMonoGameProject.src.Game
{
    class InputManager
    {
        List<IInputHandler> inputHandlers;
        KeyboardState lastKeyboardState, currentKeyboardState;
        MouseState lastMouseState, currentMouseState;

        public InputManager()
        {
            this.inputHandlers = new List<IInputHandler>();
        }

        public void Update(GameTime gameTime)
        {
            currentKeyboardState = Keyboard.GetState();
            currentMouseState = Mouse.GetState();
            this.NotifyAll();
            lastKeyboardState = currentKeyboardState;
            lastMouseState = currentMouseState;
            
        }

        private void NotifyAll()
        {
            foreach (IInputHandler inputHandler in inputHandlers) {
                inputHandler.handleKeyboardInput(lastKeyboardState, currentKeyboardState);
                inputHandler.handleMouseInput(lastMouseState, currentMouseState);
            }
        }

        public void registerHandler(IInputHandler handler)
        {
            this.inputHandlers.Add(handler);
        }
 

    }
}
