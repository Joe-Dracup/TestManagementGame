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

        public override void Update()
        {
            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Enter))
            {
                Globals.screenMgr.SetScreen(ScreenType.Splash);
            }
        }

        public override void Draw()
        {
            //Globals.spriteBatch.DrawString(g.font, "Title Screen", new Vector2(100, 100), Color.White);
        }
    }
}
