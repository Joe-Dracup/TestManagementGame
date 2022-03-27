using Microsoft.Xna.Framework;
using TestManagementGame.ScreenManagement.Screens;

namespace TestManagementGame.ScreenManagement
{
    public abstract class GameScreen
    {
        public GameScreen(ScreenType type)
        {
            this.type = type;
        }
        public ScreenType type;
        public virtual void Update(GameTime gameTime) { }
        public virtual void Draw() { }
        public virtual void LoadContent() { }
    }
}
