using Microsoft.Xna.Framework;
using System.Collections.Generic;
using TestManagementGame.ScreenManagement.Screens;

namespace TestManagementGame.ScreenManagement
{
    public class ScreenManager
    {
        GameScreen currentScreen;
        Dictionary<ScreenType, GameScreen> screens = new Dictionary<ScreenType, GameScreen>();

        SplashScreen splash = new SplashScreen();
        TitleScreen title = new TitleScreen();

        public void Init()
        {
            AddScreen(splash.type, splash);
            AddScreen(title.type, title);

            SetScreen(ScreenType.Splash);
        }

        public void SetScreen(ScreenType type)
        {
            if (screens.TryGetValue(type, out GameScreen newScreen))
                currentScreen = newScreen;
            currentScreen.LoadContent();
        }

        public void AddScreen(ScreenType type, GameScreen newScreen)
        {
            screens.Add(type, newScreen);
        }

        internal void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }

        internal void Draw()
        {
            currentScreen.Draw();
        }
    }
}
