using System;
using System.Numerics;
using Raylib_cs;

namespace logicgates
{
    internal class Program
    {
        public static Camera2D camera;
        public static RenderTexture2D target;
        
        static void Main(string[] args)
        {
            camera.Offset = Vector2.Zero;
            camera.Rotation = 0;
            camera.Target = new Vector2(0,0);
            camera.Zoom = 1;

            Raylib.InitWindow((int)Window.winsize.X,(int)Window.winsize.Y,"an electricty simulator (VERY BUGGY DEMO)");

            target = Raylib.LoadRenderTexture(1280, 720);

            Logger.log($"click to place down the {Window.voltage}v voltage power source");

            Raylib.SetTargetFPS(60);

            Raylib.SetExitKey(0);

            Textures.init();

            while (!Raylib.WindowShouldClose() && !Window.isquitting)
            {
                Raylib.BeginDrawing();
                Raylib.BeginTextureMode(target);
                Raylib.BeginMode2D(camera);
                Raylib.ClearBackground(Color.White);
                Render.InputHandling();
                Render.RendererCallBacks();
                Raylib.EndMode2D();
                Raylib.EndTextureMode();
                Raylib.DrawTexturePro(target.Texture, new Rectangle(0, 0, target.Texture.Width, -target.Texture.Height), new Rectangle(0, 0, Window.winsize.X, Window.winsize.Y), Vector2.Zero, 0, Color.White);
                Logger.renderlogger();
                Render.RenderUI();
                Raylib.EndDrawing();
            }
        }
    }
}