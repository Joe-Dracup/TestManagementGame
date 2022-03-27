using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TestManagementGame.Engine;
using TestManagementGame.ObjectManagement;

namespace TestManagementGame.ScreenManagement.Screens
{
    public class SplashScreen : GameScreen
    {
        KeyboardState keyState;

        //Objects
        SpriteFont font;
        Object2D logo;

        public SplashScreen() : base(ScreenType.Splash)
        {
            
        }

        public override void LoadContent()
        {
            if (font == null)
            {
                font = Globals.content.Load<SpriteFont>("Font1");
            }
            if(logo == null)
            {
                logo = new Object2D("Logo", new Vector2(Globals.width / 2, Globals.height / 2), new Vector2(128, 128));
            }
            base.LoadContent();
        }

        public override void Update()
        {
            keyState = Keyboard.GetState();
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
