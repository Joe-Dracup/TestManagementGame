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
        SpriteFont font;
        KeyboardState keyState;
        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);  
            if(font == null) {
                font = _content.Load<SpriteFont>("Font1");
            }
        }

        public override void Update(GameTime gameTime)
        {
            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Space))
            {
                ScreenManager.Instance.AddScreen(new TitleScreen());
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, "Splash", new Vector2(100,100), Color.Black);
        }
    }
}
