using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using TestManagementGame.ScreenManagement.Screens;

namespace TestManagementGame.ScreenManagement
{
    public class ScreenManager
    {
        GameScreen currentScreen;

        public void SetScreen(GameScreen newScreen)
        {
            currentScreen = newScreen;
        }

        internal void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }

        internal void Draw(Game1 g)
        {
            currentScreen.Draw(g);
        }
    }
}
