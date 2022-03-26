using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestManagementGame.Engine
{
    public static class Globals
    {
        public static GraphicsDeviceManager _graphics;
        public static SpriteBatch _spriteBatch;
        public static ContentManager content;

        public static int height { get; private set; }
        public static int width { get; private set; }
        public static bool vsync { get; private set; } = true;

        public static void Init(Game1 g)
        {
            height = 600;
            width = 800;

            //init graphics
            _graphics = new GraphicsDeviceManager(g);
            _graphics.PreferredBackBufferHeight = height;
            _graphics.PreferredBackBufferWidth = width;
            _graphics.SynchronizeWithVerticalRetrace = vsync;
            //_graphics.IsFullScreen = true;
            _graphics.ApplyChanges();

            g.IsMouseVisible = true;
        }
    }
}
