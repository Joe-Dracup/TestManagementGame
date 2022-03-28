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

        //Variables
        readonly int logoHeight = 128;
        readonly Vector2 titlePos = new Vector2(128, 128);

        public SplashScreen() : base(ScreenType.Splash)
        {

        }

        public override void LoadContent()
        {
            if (title == null)
                title = new Text2D("Font1", titlePos, "This is a splash screen");
            if (bottomText == null)
                bottomText = new Text2D("Font1", new Vector2(Globals.Width / 2, Globals.Height - 150), "Press Space To Proceed");
            if (logo == null)
                logo = new SplashLogo(logoHeight);

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            keyState = Keyboard.GetState();

            logo.Update(gameTime);

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
