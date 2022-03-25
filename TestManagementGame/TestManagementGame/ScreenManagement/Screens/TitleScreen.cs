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
        SpriteFont font;
        KeyboardState keyState;

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(Game1 g)
        {
            g.GraphicsDevice.Clear(Color.Black);
        }
    }
}
