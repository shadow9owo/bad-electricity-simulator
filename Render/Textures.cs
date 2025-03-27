using Raylib_cs;
using System;

namespace logicgates
{
    class Textures
    {
        public static Texture2D buttonpressed,button,chip,linker,screen,led;
        public static Image buttonpressedimg,buttonimg,chipimg,linkerimg,screenimg,ledimg;
        public static void init()
        {
            buttonpressedimg = Raylib.LoadImage($"assets/button{(int)Window.ButtonStates.Pressed}.png"); 
            buttonimg = Raylib.LoadImage($"assets/button{(int)Window.ButtonStates.Normal}.png"); 
            chipimg = Raylib.LoadImage("assets/chip.png"); 
            linkerimg = Raylib.LoadImage("assets/linker.png"); 
            screenimg = Raylib.LoadImage("assets/screen.png"); 
            ledimg = Raylib.LoadImage("assets/led.png"); 

            buttonpressed = Raylib.LoadTextureFromImage(buttonpressedimg);
            button = Raylib.LoadTextureFromImage(buttonimg);
            chip = Raylib.LoadTextureFromImage(chipimg);
            linker = Raylib.LoadTextureFromImage(linkerimg);
            screen = Raylib.LoadTextureFromImage(screenimg);
            led = Raylib.LoadTextureFromImage(ledimg);

            Raylib.UnloadImage(buttonimg);
            Raylib.UnloadImage(buttonpressedimg);
            Raylib.UnloadImage(chipimg);
            Raylib.UnloadImage(linkerimg);
            Raylib.UnloadImage(screenimg);
            Raylib.UnloadImage(ledimg);
        }
    }
}