using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

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
            g._spriteBatch.DrawString(g.font, "Splash Screen", new Vector2(100, 100), Color.Black);        
        }
    }
}
