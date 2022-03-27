using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using TestManagementGame.ScreenManagement;

namespace TestManagementGame.Engine
{
    public static class Globals
    {
        public static GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch;
        public static ContentManager content;
        public static ScreenManager screenMgr;

        public static int height { get; private set; }
        public static int width { get; private set; }
        public static bool vsync { get; private set; } = true;

        public static void Init(Game1 g)
        {
            height = 600;
            width = 800;

            //init graphics
            graphics = new GraphicsDeviceManager(g);
            graphics.PreferredBackBufferHeight = height;
            graphics.PreferredBackBufferWidth = width;
            graphics.SynchronizeWithVerticalRetrace = vsync;
            //_graphics.IsFullScreen = true;
            graphics.ApplyChanges();

            content = g.Content;
            spriteBatch = new SpriteBatch(g.GraphicsDevice);
            screenMgr = new ScreenManager();
        }
    }
}
