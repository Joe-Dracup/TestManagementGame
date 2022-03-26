using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TestManagementGame.Engine;
using TestManagementGame.ScreenManagement;

namespace TestManagementGame
{
    public class Game1 : Game
    {
        //Graphics
        public SpriteFont font;

        //Screens
        public ScreenManager screenMgr = new ScreenManager();

        //window
        

        public Game1()
        {
            //init
            Globals.Init(this);

            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            screenMgr.Init();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            Globals.content = Content;
            Globals._spriteBatch = new SpriteBatch(GraphicsDevice);

            if (font == null)
            {
                font = Content.Load<SpriteFont>("Font1");
            }
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

            Globals._spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);
            screenMgr.Draw(this);
            Globals._spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
