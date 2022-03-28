using Microsoft.Xna.Framework;
using TestManagementGame.Engine;

namespace TestManagementGame.ObjectManagement.Objects
{
    public class SplashLogo : Object2D
    {
        public float Speed = 200f;
        public SplashLogo(int logoHeight) : base("BeeLogo2", new Vector2(Globals.Width / 2, Globals.Height), new Vector2(logoHeight + logoHeight / 3, logoHeight))
        {

        }

        public override void Update(GameTime gameTime)
        {
            if (position.Y >= (Globals.Height / 2) - (size.Y / 2))
            {
                var delta = (float)gameTime.ElapsedGameTime.TotalSeconds;

                position.Y -= Speed * delta;
            }

            base.Update(gameTime);
        }
    }
}
