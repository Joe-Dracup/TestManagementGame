using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TestManagementGame.ScreenManagement;
using TestManagementGame.ScreenManagement.Screens;

namespace TestManagementGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        ScreenManager screenMgr = new ScreenManager();
        SplashScreen splash = new SplashScreen();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            screenMgr.SetScreen(splash);

            screenMgr.Dimensions = new Vector2(640, 480);
            _graphics.PreferredBackBufferWidth = (int)screenMgr.Dimensions.X;
            _graphics.PreferredBackBufferHeight = (int)screenMgr.Dimensions.Y;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            screenMgr.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            screenMgr.Draw(this);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
