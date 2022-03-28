using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TestManagementGame.Engine;

namespace TestManagementGame.ObjectManagement.Objects
{
    public class Text2D
    {
        public string text;
        public bool hidden;
        SpriteFont font;
        public Vector2 position;

        public Text2D(string path, Vector2 position, string text, bool hidden = false)
        {
            this.text = text;
            this.position = position;
            this.hidden = hidden;
            font = Globals.content.Load<SpriteFont>(path);
        }

        public virtual void Draw()
        {
            Draw(Color.Black, 0f, font.MeasureString(text) / 2, 1f);
        }

        public virtual void Draw(Color colour, float rotation, Vector2 origin, float scale)
        {
            if (!hidden)
            {
                Globals.spriteBatch.DrawString(font, text, position, colour, rotation, origin, scale, new SpriteEffects(), 0f);
            }
        }
    }
}
