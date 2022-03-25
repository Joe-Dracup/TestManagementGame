using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestManagementGame.ScreenManagement
{
    public class GameScreen
    {
        protected ContentManager _content;
        public virtual void LoadContent(ContentManager content)
        {
            _content = new ContentManager(content.ServiceProvider, "Content");
        }
        public virtual void UnloadContent()
        {
            _content.Unload();
        }
        public virtual void Update(GameTime gameTime) { }
        public virtual void Draw(SpriteBatch spriteBatch) { }
    }
}
