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
        Text2D title, bottomText;
        SplashLogo logo;
        int logoHeight = 128;

        public SplashScreen() : base(ScreenType.Splash)
        {

        }

        public override void LoadContent()
        {
            title = new Text2D("Font1", new Vector2(128, 128), "This is a splash screen");
            bottomText = new Text2D("Font1", new Vector2(Globals.Width / 2, Globals.Height - 250), "");
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
            else if (string.IsNullOrEmpty(bottomText.text))
            {
                bottomText.Update("Press Space To Proceed");
            }

            if (keyState.IsKeyDown(Keys.Space))
            {
                Globals.screenMgr.SetScreen(ScreenType.Title);
            }
        }

        public override void Draw()
        {
            logo.Draw();
            title.Draw();
            bottomText.Draw();
        }
    }
}
