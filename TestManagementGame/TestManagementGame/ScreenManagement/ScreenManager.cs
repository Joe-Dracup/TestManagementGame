using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using TestManagementGame.ScreenManagement.Screens;

namespace TestManagementGame.ScreenManagement
{
    public class ScreenManager
    {
        GameScreen currentScreen;

        Stack<GameScreen> screenStack = new Stack<GameScreen>();

        Vector2 dimensions;

        ContentManager content;

        private static ScreenManager instance;

        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ScreenManager();
                return instance;
            }
        }

        public Vector2 Dimensions
        {
            get { return dimensions; }
            set { dimensions = value; }
        }

        public void Initialize()
        {
            currentScreen = new SplashScreen();
        }

        public void AddScreen(GameScreen newScreen)
        {
            screenStack.Push(newScreen);
            currentScreen.UnloadContent();
            currentScreen = screenStack.Peek();
            currentScreen.LoadContent(content);
        }

        public void LoadContent(ContentManager Content)
        {
            content = new ContentManager(Content.ServiceProvider, "Content");
            currentScreen.LoadContent(content);
        }

        internal void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
        }
    }
}
