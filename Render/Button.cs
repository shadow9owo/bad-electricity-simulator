using Raylib_cs;

namespace logicgates
{
    class Button
    {
        public static void onbuttonclick(Linkedgarbag linkedgarbag)
        {
            Logger.log("clicked");
            linkedgarbag.color = new Color(
                (byte)Raylib.GetRandomValue(0, 255),
                (byte)Raylib.GetRandomValue(0, 255),
                (byte)Raylib.GetRandomValue(0, 255),
                (byte)Raylib.GetRandomValue(0, 255) 
            );
        }
    }
}