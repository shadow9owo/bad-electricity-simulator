using System;
using System.Numerics;
using Raylib_cs;

namespace logicgates
{
    internal class Program
    {
        public static Camera2D camera;
        static void Main(string[] args)
        {
            camera.Offset = Vector2.Zero;
            camera.Rotation = 0;
            camera.Target = new Vector2((int)Window.winsize.X / 2,(int)Window.winsize.Y /2);
            camera.Zoom = 1;

            Raylib.InitWindow((int)Window.winsize.X,(int)Window.winsize.Y,"an electricty simulator (VERY BUGGY DEMO)");

            Logger.log($"click to place down the {Window.voltage}v voltage power source");

            Raylib.SetTargetFPS(60);

            Textures.init();

            while (!Raylib.WindowShouldClose() && !Window.isquitting)
            {
                Raylib.BeginDrawing();
                Raylib.BeginMode2D(camera);
                Raylib.ClearBackground(Color.White);
                Render.InputHandling();
                Render.RendererCallBacks();
                Raylib.EndMode2D();
                Raylib.EndDrawing();
            }
        }
    }
}