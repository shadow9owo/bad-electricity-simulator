using System;
using System.Numerics;
using Raylib_cs;

namespace logicgates
{
    class Linkedgarbag
    {
        public Rectangle chip { get; set; }
        public Rectangle screen { get; set; }
        public Rectangle button { get; set; }
        public Color color {get;set;}
    
        public Linkedgarbag(Rectangle chip, Rectangle screen, Rectangle button, Color color)
        {
            this.chip = chip;
            this.screen = screen;
            this.button = button;
            this.color = color;
        }
    }
    class Window
    {
        public enum Items
        {
            none = 0, //powercable
            led,
            screen,
            chip,
            button
        }

        public enum ButtonStates
        {
            Normal,
            Pressed
        }

        public static Vector2 winsize = new (1280,720);
        public static bool isquitting = false;
        public static List<Vector2> posbuffer = new List<Vector2>();
        public static Dictionary<Vector2,Vector2> electricline = new Dictionary<Vector2, Vector2>();
        public static List<string> logs = new List<string>();
        public static bool debug = false;
        public static Dictionary<Vector2,double> voltagelist = new Dictionary<Vector2, double>();
        public static Vector2 supplysourcepos = new Vector2(0,0);
        public static bool connected = false;
        public static double voltage = 5;
        public static List<Rectangle> placeble = new List<Rectangle>();
        public static Items selecteditem; //inv
        public static List<Vector2> leds = new List<Vector2>(); //i know i should have made a gameobject class 
        public static Rectangle buttonbuf = new Rectangle(0,0,0,0);
        public static Rectangle chipbuf = new Rectangle(0,0,0,0);
        public static Rectangle screenbuf = new Rectangle(0,0,0,0);
        public static List<Linkedgarbag> linkedgarbags = new List<Linkedgarbag>();
        public static double resistance(double voltage) //current is 1 ig
        {
            return voltage;
            //return voltage - voltage / 10;
        }
    }
}