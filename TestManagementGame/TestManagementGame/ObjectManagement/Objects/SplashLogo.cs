using Microsoft.Xna.Framework;
using TestManagementGame.Engine;

namespace TestManagementGame.ObjectManagement.Objects
{
    public class SplashLogo : Object2D
    {
        public float Speed = 500f;
        public SplashLogo(Vector2 position, Vector2 size) : base("Logo", position, size)
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
