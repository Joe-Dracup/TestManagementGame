using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestManagementGame.ScreenManagement.Screens
{
    public class SplashScreen : GameScreen
    {
        KeyboardState keyState;
           
        public override void Update(Game1 g)
        {
            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Space))
            {
                g.screenMgr.SetScreen(ScreenType.Title);
            }
        }

        public override void Draw(Game1 g)
        {
            g.GraphicsDevice.Clear(Color.White);
        }
    }
}
