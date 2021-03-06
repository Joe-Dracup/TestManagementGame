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

        public static int Height { get; private set; } = 600;
        public static int Width { get; private set; } = 800;
        public static bool Vsync { get; private set; } = false;

        public static void Init(Game1 g)
        {
            //init graphics
            graphics = new GraphicsDeviceManager(g);
            graphics.PreferredBackBufferHeight = Height;
            graphics.PreferredBackBufferWidth = Width;
            graphics.SynchronizeWithVerticalRetrace = Vsync;
            graphics.ApplyChanges();

            content = g.Content;
            spriteBatch = new SpriteBatch(g.GraphicsDevice);
            screenMgr = new ScreenManager();
        }
    }
}
