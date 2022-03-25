using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TestManagementGame.ScreenManagement;
using TestManagementGame.ScreenManagement.Screens;

namespace TestManagementGame
{
    public class Game1 : Game
    {
        //Graphics
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //Screens
        public ScreenManager screenMgr = new ScreenManager();

        //window
        public int height { get; private set; }
        public int width { get; private set; }
        public bool vsync { get; private set; }


        public Game1()
        {
            //init
            height = 600;
            width = 800;

            //init graphics
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferHeight = height;
            _graphics.PreferredBackBufferWidth = width;
            _graphics.SynchronizeWithVerticalRetrace = vsync;
            //_graphics.IsFullScreen = true;
            _graphics.ApplyChanges();

            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            screenMgr.Init();


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

            screenMgr.Update(this);
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
