using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using TestManagementGame.Engine;

namespace TestManagementGame.ObjectManagement
{
    public class Object2D
    {
        public Vector2 position, size;
        public Texture2D texture;
        public Object2D(string path, Vector2 position, Vector2 size)
        {
            this.position = position;
            this.size = size;

            texture = Globals.content.Load<Texture2D>(path);
        }

        public virtual void Update()
        {

        }

        public virtual void Draw()
        {
            Draw(new Vector2(0, 0), 0.0f, new Vector2(texture.Bounds.Width / 2, texture.Bounds.Height / 2));
        }

        public virtual void Draw(Vector2 offset, float rotation, Vector2 origin)
        {
            if (texture != null)
            {
                Globals.spriteBatch.Draw(texture, new Rectangle(((int)position.X + (int)offset.X), ((int)position.Y + (int)offset.Y), (int)size.X, (int)size.Y), null, Color.White, rotation, origin, new SpriteEffects(), 0);
            }
        }
    }
}
