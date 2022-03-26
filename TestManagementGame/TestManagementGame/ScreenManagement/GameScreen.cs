using Microsoft.Xna.Framework.Content;
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
        protected ContentManager _content;
        public virtual void Update(Game1 g) { }
        public virtual void Draw(Game1 g) { }
    }
}
