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
        Dictionary<ScreenType, GameScreen> screens = new Dictionary<ScreenType, GameScreen>();

        SplashScreen splash = new SplashScreen();
        TitleScreen title = new TitleScreen();


        public void Init()
        {
            screens.Add(ScreenType.Splash, splash);
            screens.Add(ScreenType.Title, title);

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

        internal void Update(Game1 g)
        {
            currentScreen.Update(g);
        }

        internal void Draw(Game1 g)
        {
            currentScreen.Draw(g);
        }


    }
}
