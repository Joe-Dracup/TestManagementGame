using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TestManagementGame.Engine;
using TestManagementGame.ScreenManagement;

namespace TestManagementGame
{
    public class Game1 : Game
    {
        public Game1()
        {
            //init
            Globals.Init(this);

            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            Globals.screenMgr.Init();

            base.Initialize();
        }

        protected override void LoadContent()
        {

           
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Globals.screenMgr.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            Globals.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);
            Globals.screenMgr.Draw();
            Globals.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
