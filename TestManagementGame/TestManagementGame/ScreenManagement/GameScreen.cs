using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestManagementGame.ScreenManagement
{
    public abstract class GameScreen
    {
        protected ContentManager _content;
        public virtual void Update(GameTime gameTime) { }
        public virtual void Draw(Game1 g) { }
    }
}
