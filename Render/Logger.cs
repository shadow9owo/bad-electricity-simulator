using System.Numerics;
using Raylib_cs;

namespace logicgates{
    class Logger
    {
        public static void log(string message)
        {
            if (Window.logs.Count + 1 > 3) {
                Window.logs.Clear(); //playing it safe :P
            }
            Window.logs.Insert(0,message);
            return;
        }
        public static void renderlogger()
        {
            int i = 1;
            foreach (var item in Window.logs)
            {
                Raylib.DrawText(item,(int)Raylib.GetScreenToWorld2D(new Vector2(10,0),Program.camera).X,(int)Raylib.GetScreenToWorld2D(new Vector2(0,-24),Program.camera).Y + (24 * i),(int)24,new Color(0,0,0,255 / i));
                i = i + 1;
            }
            return;
        }
    }
}