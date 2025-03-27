//most of the work was streamed to youtube --- https://www.youtube.com/watch?v=S016QUqHC3E

using System;
using System.Diagnostics;
using System.Numerics;
using Raylib_cs;

namespace logicgates
{
    class Render
    {
        public static Vector2 mousePos;
        public static void RendererCallBacks()
        {
            Raylib.DrawText($"current selected item : {Enum.GetName(typeof(Window.Items),Window.selecteditem)}",(int)Raylib.GetScreenToWorld2D(new Vector2(10,0),Program.camera).X,(int)Raylib.GetScreenToWorld2D(new Vector2(0,Window.winsize.Y),Program.camera).Y - (24 * 1),(int)24,new Color(0,0,0,255 / 1));
            if (Window.debug)
            {
                foreach (var item in Window.electricline) 
                {
                    Vector2 start = item.Key;
                    Vector2 end = item.Value;
                
                    //i want to die from this garbage alghorhithm
                    const int boxSize = 5;
                    const int step = 5;

                    if (start.Y < end.Y)
                    {
                        for (int y = (int)start.Y; y <= (int)end.Y; y += step)
                        {
                            Raylib.DrawRectangle((int)start.X - boxSize / 2, y - boxSize / 2, boxSize, boxSize, Color.Green);
                            if (Window.placeble.Contains(new Rectangle((int)start.X - boxSize / 2, y - boxSize / 2, boxSize, boxSize)))
                            {
                                foreach (var item1 in Window.leds)
                                {
                                    if (Vector2.Distance(item1,new Vector2(start.X - boxSize / 2, y - boxSize / 2)) > 10)
                                    {
                                        Window.placeble.Add(new Rectangle((int)start.X - boxSize / 2, y - boxSize / 2, boxSize, boxSize));
                                    }
                                }
                            }else {
                                Window.placeble.Add(new Rectangle((int)start.X - boxSize / 2, y - boxSize / 2, boxSize, boxSize));
                            }
                        }
                    }
                    else
                    {
                        for (int y = (int)start.Y; y >= (int)end.Y; y -= step)
                        {
                            Raylib.DrawRectangle((int)start.X - boxSize / 2, y - boxSize / 2, boxSize, boxSize, Color.Green);
                            if (Window.placeble.Contains(new Rectangle((int)start.X - boxSize / 2, y - boxSize / 2, boxSize, boxSize)))
                            {
                                foreach (var item1 in Window.leds)
                                {
                                    if (Vector2.Distance(item1,new Vector2(start.X - boxSize / 2, y - boxSize / 2)) > 10)
                                    {
                                        Window.placeble.Add(new Rectangle((int)start.X - boxSize / 2, y - boxSize / 2, boxSize, boxSize));
                                    }
                                }
                            }else {
                                Window.placeble.Add(new Rectangle((int)start.X - boxSize / 2, y - boxSize / 2, boxSize, boxSize));
                            }
                        }
                    }

                    if (start.X < end.X)
                    {
                        for (int x = (int)start.X; x <= (int)end.X; x += step)
                        {
                            Raylib.DrawRectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize, Color.Green);
                            if (Window.placeble.Contains(new Rectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize)))
                            {
                                foreach (var item1 in Window.leds)
                                {
                                    if (Vector2.Distance(item1,new Vector2(x - boxSize / 2, (int)end.Y - boxSize / 2)) > 10)
                                    {
                                        Window.placeble.Add(new Rectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize));
                                    }
                                }
                            }else {
                                Window.placeble.Add(new Rectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize));
                            }
                        }
                    }else {
                        for (int x = (int)start.X; x >= (int)end.X; x -= step)
                        {
                            Raylib.DrawRectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize, Color.Green);
                            if (Window.placeble.Contains(new Rectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize)))
                            {
                                foreach (var item1 in Window.leds)
                                {
                                    if (Vector2.Distance(item1,new Vector2(x - boxSize / 2, (int)end.Y - boxSize / 2)) > 10)
                                    {
                                        Window.placeble.Add(new Rectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize));
                                    }
                                }
                                //Window.placeble.Add(new Rectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize));
                            }else {
                                Window.placeble.Add(new Rectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize));
                            }
                        }
                    }
                }
            }else 
            {
                foreach (var item in Window.electricline) 
                {
                    Vector2 start = item.Key;
                    Vector2 end = item.Value;
                
                    //i want to die from this garbage alghorhithm
                    const int boxSize = 5;
                    const int step = 5;

                    if (start.Y < end.Y)
                    {
                        for (int y = (int)start.Y; y <= (int)end.Y; y += step)
                        {
                            if (Window.placeble.Contains(new Rectangle((int)start.X - boxSize / 2, y - boxSize / 2, boxSize, boxSize)))
                            {
                                foreach (var item1 in Window.leds)
                                {
                                    if (Vector2.Distance(item1,new Vector2(start.X - boxSize / 2, y - boxSize / 2)) > 10)
                                    {
                                        Window.placeble.Add(new Rectangle((int)start.X - boxSize / 2, y - boxSize / 2, boxSize, boxSize));
                                    }
                                }
                            }else {
                                Window.placeble.Add(new Rectangle((int)start.X - boxSize / 2, y - boxSize / 2, boxSize, boxSize));
                            }
                        }
                    }
                    else
                    {
                        for (int y = (int)start.Y; y >= (int)end.Y; y -= step)
                        {
                            if (Window.placeble.Contains(new Rectangle((int)start.X - boxSize / 2, y - boxSize / 2, boxSize, boxSize)))
                            {
                                foreach (var item1 in Window.leds)
                                {
                                    if (Vector2.Distance(item1,new Vector2(start.X - boxSize / 2, y - boxSize / 2)) > 10)
                                    {
                                        Window.placeble.Add(new Rectangle((int)start.X - boxSize / 2, y - boxSize / 2, boxSize, boxSize));
                                    }
                                }
                            }else {
                                Window.placeble.Add(new Rectangle((int)start.X - boxSize / 2, y - boxSize / 2, boxSize, boxSize));
                            }
                        }
                    }

                    if (start.X < end.X)
                    {
                        for (int x = (int)start.X; x <= (int)end.X; x += step)
                        {
                            if (Window.placeble.Contains(new Rectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize)))
                            {
                                foreach (var item1 in Window.leds)
                                {
                                    if (Vector2.Distance(item1,new Vector2(x - boxSize / 2, (int)end.Y - boxSize / 2)) > 10)
                                    {
                                        Window.placeble.Add(new Rectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize));
                                    }
                                }
                            }else {
                                Window.placeble.Add(new Rectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize));
                            }
                        }
                    }else {
                        for (int x = (int)start.X; x >= (int)end.X; x -= step)
                        {
                            if (Window.placeble.Contains(new Rectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize)))
                            {
                                foreach (var item1 in Window.leds)
                                {
                                    if (Vector2.Distance(item1,new Vector2(x - boxSize / 2, (int)end.Y - boxSize / 2)) > 10)
                                    {
                                        Window.placeble.Add(new Rectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize));
                                    }
                                }
                                //Window.placeble.Add(new Rectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize));
                            }else {
                                Window.placeble.Add(new Rectangle(x - boxSize / 2, (int)end.Y - boxSize / 2, boxSize, boxSize));
                            }
                        }
                    }
                }
            }

            foreach (var item in Window.linkedgarbags)
            {
                if (Window.linkedgarbags.Count > 0)
                {
                    Raylib.DrawTexturePro(
                        Textures.screen,
                        new Rectangle(0, 0, Textures.screen.Width, Textures.screen.Height), // Source
                        new Rectangle(item.screen.X, item.screen.Y, Textures.screen.Width * 32.0f / (Textures.screen.Width / 8.0f), Textures.screen.Height * 32.0f / (Textures.screen.Width / 8.0f)), // Destination
                        new Vector2(Textures.screen.Width * 8.0f / (Textures.screen.Width / 8.0f) / 2, Textures.screen.Height * 8.0f / (Textures.screen.Width / 8.0f) / 2), // Origin
                        0,
                        item.color
                    );
                    Raylib.DrawText("under power (SCREEN)", (int)item.screen.X, (int)item.screen.Y, 12, Color.Blue);

                    Raylib.DrawTexturePro(
                        Textures.chip,
                        new Rectangle(0, 0, Textures.chip.Width, Textures.chip.Height), // Source
                        new Rectangle(item.chip.X, item.chip.Y, Textures.chip.Width * 16.0f / (Textures.chip.Width / 2.0f), Textures.chip.Height * 16.0f / (Textures.chip.Width / 2.0f)), // Destination
                        new Vector2(Textures.chip.Width * 8.0f / (Textures.chip.Width / 2.0f) / 2, Textures.chip.Height * 8.0f / (Textures.chip.Width / 2.0f) / 2), // Origin
                        0,
                        Color.White
                    );
                    Raylib.DrawText("under power (CHIP)", (int)item.chip.X, (int)item.chip.Y, 12, Color.Blue);

                    if (Raylib.CheckCollisionRecs(new Rectangle(new Vector2(item.button.X,item.button.Y),new Vector2(16,16)),new Rectangle(mousePos,new Vector2(4,4))))
                    {
                        Raylib.DrawTexturePro(
                            Textures.buttonpressed,
                            new Rectangle(0, 0, Textures.button.Width, Textures.button.Height), // Source
                            new Rectangle(item.button.X, item.button.Y, Textures.button.Width * 16.0f / (Textures.button.Width / 2.0f), Textures.button.Height * 16.0f / (Textures.button.Width / 2.0f)), // Destination
                            new Vector2(Textures.button.Width * 8.0f / (Textures.button.Width / 2.0f) / 2, Textures.button.Height * 8.0f / (Textures.button.Width / 2.0f) / 2), // Origin
                            0,
                            Color.White
                        );
                    }else
                    {
                        Raylib.DrawTexturePro(
                            Textures.button,
                            new Rectangle(0, 0, Textures.button.Width, Textures.button.Height), // Source
                            new Rectangle(item.button.X, item.button.Y, Textures.button.Width * 16.0f / (Textures.button.Width / 2.0f), Textures.button.Height * 16.0f / (Textures.button.Width / 2.0f)), // Destination
                            new Vector2(Textures.button.Width * 8.0f / (Textures.button.Width / 2.0f) / 2, Textures.button.Height * 8.0f / (Textures.button.Width / 2.0f) / 2), // Origin
                            0,
                            Color.White
                        );
                    }
                    Raylib.DrawText("under power (BUTTON)", (int)item.button.X, (int)item.button.Y, 12, Color.Blue);
                }
            }

            if (Window.supplysourcepos != Vector2.Zero)
            {
                Raylib.DrawCircle((int)Window.supplysourcepos.X, (int)Window.supplysourcepos.Y, 8, Color.Yellow);
                Raylib.DrawText($"power supply ({Window.voltage}v)", (int)Window.supplysourcepos.X, (int)Window.supplysourcepos.Y, 12, Color.Black);
            }
            foreach (var item in Window.posbuffer)
            {
                Raylib.DrawCircle((int)item.X, (int)item.Y, 4, new Color(255, 0, 0));
            }
            foreach (var item in Window.electricline)
            {
                Raylib.DrawLine((int)item.Key.X, (int)item.Key.Y, (int)item.Key.X, (int)item.Value.Y, new Color(255, 0, 0));
                Raylib.DrawLine((int)item.Value.X, (int)item.Value.Y, (int)item.Key.X, (int)item.Value.Y, new Color(255, 0, 0));
            }

            foreach (var item in Window.voltagelist)
            {
                Raylib.DrawText(item.Value + " volts", (int)item.Key.X, (int)item.Key.Y, 12, Color.Blue);
            }

            foreach (var item in Window.leds)//contains the positions
            {
                if (Window.debug)
                {
                    Raylib.DrawCircle((int)item.X,(int)item.Y,8,Color.Red);
                }
                Raylib.DrawTexturePro(
                    Textures.led,
                    new Rectangle(0, 0, Textures.led.Width, Textures.led.Height), // Source
                    new Rectangle(item.X, item.Y, Textures.led.Width * 8.0f / (Textures.led.Width / 2.0f), Textures.led.Height * 8.0f / (Textures.led.Width / 2.0f)), // Destination
                    new Vector2(Textures.led.Width * 8.0f / (Textures.led.Width / 2.0f) / 2, Textures.led.Height * 8.0f / (Textures.led.Width / 2.0f) / 2), // Origin
                    0,
                    Color.Red
                );
                Raylib.DrawText("under power", (int)item.X, (int)item.Y, 12, Color.Blue);
            }

            if (Window.debug)
            {
                Raylib.DrawRectangleRec(new Rectangle(mousePos.X, mousePos.Y,new Vector2(8, 8)),Color.Brown);
            }

            Logger.renderlogger();

            return;
        }

        public static void InputHandling()
        {
            mousePos = Raylib.GetScreenToWorld2D(Raylib.GetMousePosition(), Program.camera);

            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
            {
                if (Window.logs.Contains("have fun")) { Window.logs.Clear(); }
                if (Window.supplysourcepos == Vector2.Zero)
                {
                    Window.supplysourcepos = mousePos;
                    Window.logs.Clear();
                    Logger.log("connect a line to the powersource");
                    return;
                }
                if (!Window.connected) {
                    if (Vector2.Distance(mousePos, Window.supplysourcepos) < 25)
                    {
                        Window.connected = true;
                        Window.logs.Clear();
                        Window.posbuffer.Add(Window.supplysourcepos);
                        Logger.log("have fun");
                        return;
                    }
                    else {
                        return;
                    }
                }

                foreach (var item in Window.linkedgarbags)
                {
                    if (Raylib.CheckCollisionRecs(new Rectangle(new Vector2(item.button.X,item.button.Y),new Vector2(16,16)),new Rectangle(mousePos,new Vector2(4,4))))
                    {
                        Button.onbuttonclick(item); //on click function
                        break;
                    }
                }

                if (Window.selecteditem != Window.Items.none && Window.selecteditem != Window.Items.screen)
                {
                    foreach (var item in Window.placeble)
                    {
                        if (Raylib.CheckCollisionRecs(new Rectangle(mousePos.X, mousePos.Y, 8, 8), item))
                        {
                            switch (Window.selecteditem)
                            {
                                case Window.Items.none:
                                    Logger.log("HOW DID YOU???? huh (this is a bug)");
                                    throw new InvalidOperationException("Impossible state: Window.selecteditem should never be 'none' here!");
                                case Window.Items.led:
                                    Window.leds.Add(mousePos);
                                    Window.placeble.Remove(item);
                                    break;
                                case Window.Items.chip:
                                    Window.chipbuf = item;
                                    Window.placeble.Remove(item);
                                    Logger.log("chip was added to the buffer");
                                    break;
                                case Window.Items.button:
                                    Window.buttonbuf = item;
                                    Window.placeble.Remove(item);
                                    Logger.log("button was added to the buffer");
                                    break;
                                default:
                                    break;
                            }
                            break;
                        }
                    }
                }
                else if (Window.selecteditem == Window.Items.screen) //does not exec
                {
                    Window.screenbuf = new Rectangle(mousePos,new Vector2(16,16));
                    Logger.log("screen was added to the buffer");
                }
                {
                    //garbage ai copy pasta -- 25/03/2025 
                    //3 days left and i am running out of time pretty quickly

                    Vector2 closestPoint = Window.supplysourcepos;
                    float minDistance = 10;

                    foreach (var item in Window.electricline)
                    {
                        float distanceToKey = Vector2.Distance(mousePos, item.Key);
                        float distanceToValue = Vector2.Distance(mousePos, item.Value);

                        if (distanceToKey < minDistance)
                        {
                            minDistance = distanceToKey;
                            closestPoint = item.Key;
                        }
                        if (distanceToValue < minDistance)
                        {
                            minDistance = distanceToValue;
                            closestPoint = item.Value;
                        }
                    }

                    if (minDistance < 10)
                    {
                        Window.posbuffer.Add(closestPoint);
                        if (!Window.voltagelist.ContainsKey(closestPoint))
                        {
                            Window.voltagelist[closestPoint] = Window.resistance(Window.voltage); //applies window resistance
                        }
                    }

                    else 
                    {
                        //the vector item dictionary position isnt aligned (snapped dosent work) //problem if the wire is not connecting to other wire which in this case it should as there should be atleast one wire then dont
                        //if the fucking posbuffer is close enough to idk one of the prexisting window.electricline points (value is start key is end) then snap to that value ffs

                        //edit : works
                        //wooooowwwwwwwwwwww i am so proud of myself (irony)

                        if (Window.electricline.Count() > 0) 
                        {
                            foreach (var item in Window.electricline)
                            {
                                if (Vector2.Distance(item.Key,mousePos) < 10)
                                {
                                    Window.posbuffer.Add(item.Key);
                                }
                                else if (Vector2.Distance(item.Value,mousePos) < 10)
                                {
                                    Window.posbuffer.Add(item.Value);
                                }else
                                {
                                    if (Window.posbuffer.Count > 0)
                                    {
                                        Window.posbuffer.Add(mousePos);
                                    }
                                }
                            }
                        }else {
                            Window.posbuffer.Add(mousePos);
                        }
                    }
                }
            }

            if (Window.buttonbuf.X != 0 && Window.buttonbuf.Y != 0 && Window.buttonbuf.Width != 0 && Window.buttonbuf.Height != 0 &&
                Window.screenbuf.X != 0 && Window.screenbuf.Y != 0 && Window.screenbuf.Width != 0 && Window.screenbuf.Height != 0 &&
                Window.chipbuf.X != 0 && Window.chipbuf.Y != 0 && Window.chipbuf.Width != 0 && Window.chipbuf.Height != 0)
            {
                Window.linkedgarbags.Add(new Linkedgarbag(Window.chipbuf,Window.screenbuf,Window.buttonbuf,Color.White));
                Window.chipbuf = new Rectangle(0,0,0,0);
                Window.screenbuf = new Rectangle(0,0,0,0);
                Window.buttonbuf = new Rectangle(0,0,0,0);
            }

            if (Window.posbuffer.Count > 1)
            {
                if (!Window.electricline.ContainsKey(Window.posbuffer[0]))
                {
                    Window.electricline.Add(Window.posbuffer[0], Window.posbuffer[1]);
                }
                else
                {
                    Logger.log("cant place it here sorry would crash the program...");
                }
                Window.posbuffer.Clear();
            }

            // movement
            float moveSpeed = 100f * Raylib.GetFrameTime();
            if (Raylib.IsKeyDown(KeyboardKey.W) || Raylib.IsKeyDown(KeyboardKey.Up))
            {
                Program.camera.Offset.Y += moveSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.S) || Raylib.IsKeyDown(KeyboardKey.Down))
            {
                Program.camera.Offset.Y -= moveSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.A) || Raylib.IsKeyDown(KeyboardKey.Left))
            {
                Program.camera.Offset.X += moveSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.D) || Raylib.IsKeyDown(KeyboardKey.Right))
            {
                Program.camera.Offset.X -= moveSpeed;
            }

            if (Raylib.IsKeyPressed(KeyboardKey.F3))
            {
                Window.debug = !Window.debug;
            }

            if (Raylib.IsKeyPressed(KeyboardKey.Tab))
            {
                //ugly hardcoded code :) but i mean it works
                if ((int)Window.selecteditem + 1 > 4)
                {
                    Window.selecteditem = 0;
                }else {
                    Window.selecteditem = Window.selecteditem + 1;
                }
            }

            if (Raylib.IsKeyPressed(KeyboardKey.R))
            {
                Window.posbuffer.Clear();
                Window.electricline.Clear();
                Window.logs.Clear();
                Window.debug = true;
                Window.voltagelist.Clear();
                Window.supplysourcepos = Vector2.Zero;
                Window.connected = false;
                Logger.log($"click to place down the {Window.voltage}v voltage power source");
                Program.camera.Zoom = 1;
                Program.camera.Offset = Vector2.Zero;
                Window.placeble.Clear();
                Window.selecteditem = Window.Items.none;
            }

            // zoom
            Program.camera.Zoom += Raylib.GetMouseWheelMove() / 10;
            return;
        }
    }
}