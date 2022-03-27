using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestManagementGame.ObjectManagement.Objects
{
    public class SplashLogo : Object2D
    {
        public float Speed = 500f;
        public SplashLogo(Vector2 position, Vector2 size) : base("Logo", position, size)
        {

        }
    }
}
