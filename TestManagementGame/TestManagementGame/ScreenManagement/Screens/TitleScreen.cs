using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using TestManagementGame.Engine;

namespace TestManagementGame.ScreenManagement.Screens
{
    public class TitleScreen : GameScreen
    {
        public TitleScreen() : base(ScreenType.Title)
        {

        }

        KeyboardState keyState;

        public override void Update(GameTime gameTime)
        {
            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Enter))
            {
                Globals.screenMgr.SetScreen(ScreenType.Splash);
            }
        }

        public override void Draw()
        {

        }
    }
}
