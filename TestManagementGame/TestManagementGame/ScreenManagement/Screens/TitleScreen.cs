using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestManagementGame.ScreenManagement.Screens
{
    public class TitleScreen : GameScreen
    {
        KeyboardState keyState;

        public override void Update(Game1 g)
        {
            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Enter))
            {
                g.screenMgr.SetScreen(ScreenType.Splash);
            }
        }

        public override void Draw(Game1 g)
        {
            g.GraphicsDevice.Clear(Color.Black);
            g._spriteBatch.DrawString(g.font, "Title Screen", new Vector2(100, 100), Color.White);
        }
    }
}
