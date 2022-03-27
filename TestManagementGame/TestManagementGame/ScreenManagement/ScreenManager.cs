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
            screens.Add(splash.type, splash);
            screens.Add(title.type, title);

            currentScreen = splash;
        }

        public void SetScreen(ScreenType type)
        {
            GameScreen newScreen;
            if (screens.TryGetValue(type, out newScreen))
                currentScreen = newScreen;
        }

        public void AddScreen(ScreenType type, GameScreen newScreen)
        {
            screens.Add(type, newScreen);
        }

        internal void Update()
        {
            currentScreen.Update();
        }

        internal void Draw()
        {
            currentScreen.Draw();
        }
    }
}
