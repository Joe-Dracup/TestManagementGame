using Microsoft.Xna.Framework.Content;

namespace TestManagementGame.ScreenManagement
{
    public abstract class GameScreen
    {
        protected ContentManager _content;
        public virtual void Update(Game1 g) { }
        public virtual void Draw(Game1 g) { }
    }
}
