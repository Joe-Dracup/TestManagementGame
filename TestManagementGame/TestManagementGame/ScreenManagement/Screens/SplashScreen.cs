using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TestManagementGame.Engine;
using TestManagementGame.ObjectManagement;
using TestManagementGame.ObjectManagement.Objects;

namespace TestManagementGame.ScreenManagement.Screens
{
    public class SplashScreen : GameScreen
    {
        KeyboardState keyState;

        //Objects
        SpriteFont font;
        SplashLogo logo;
        int logoHeight = 128;

        public SplashScreen() : base(ScreenType.Splash)
        {

        }

        public override void LoadContent()
        {
            if (font == null)
            {
                font = Globals.content.Load<SpriteFont>("Font1");
            }
            if (logo == null)
            {
                logo = new SplashLogo(new Vector2(Globals.Width / 2, Globals.Height), new Vector2(logoHeight, logoHeight));
            }
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            keyState = Keyboard.GetState();

            var delta = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (logo.position.Y >= (Globals.Height / 2) - (logoHeight / 2))
            {
                logo.position.Y -= logo.Speed * delta;
            }
            else
            {

            }

            if (keyState.IsKeyDown(Keys.Space))
            {
                Globals.screenMgr.SetScreen(ScreenType.Title);
            }
        }

        public override void Draw()
        {
            logo.Draw();
            Globals.spriteBatch.DrawString(font, "Splash Screen", new Vector2(100, 100), Color.Black);
        }
    }
}
