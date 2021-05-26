using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    class Maps
    {
        public static Texture2D FemtioXHundra;
        public static Texture2D HundraXFemtio;
        public static Texture2D FemtioXFemtio;
        public static Texture2D Bas;
        public static Texture2D OutsideMapWall;
        public static Texture2D uwin;

        public static bool isLoaded1;

        public static bool isLoaded2;

        public static bool isLoaded3;


        //level1
        private static Sprites.Sprite bas;  // Each sprite is one wall

        private static Sprites.Sprite LeftWall;
        private static Sprites.Sprite RightWall;

        private static Sprites.Sprite wall1;
        private static Sprites.Sprite wall2;
        private static Sprites.Sprite wall7;
        private static Sprites.Sprite wall8;
        private static Sprites.Sprite wall9;

        private static Sprites.Sprite wall18;

        private static Sprites.Sprite wall19;

        private static Sprites.Sprite wall3;
        private static Sprites.Sprite wall4;
        private static Sprites.Sprite wall5;
        private static Sprites.Sprite wall6;
        private static Sprites.Sprite wall12;
        private static Sprites.Sprite wall15;
        private static Sprites.Sprite wall17;

        private static Sprites.Sprite wall16;

        private static Sprites.Sprite wall10;
        private static Sprites.Sprite wall11;
        private static Sprites.Sprite wall13;
        private static Sprites.Sprite wall20;

        //level1


        //level2

        private static Sprites.Sprite RightWall2;
        private static Sprites.Sprite LeftWall2;
        private static Sprites.Sprite wall201;
        private static Sprites.Sprite wall202;
        private static Sprites.Sprite wall203;
        private static Sprites.Sprite wall204;
        private static Sprites.Sprite wall205;
        private static Sprites.Sprite wall206;
        private static Sprites.Sprite wall207;
        private static Sprites.Sprite wall208;
        private static Sprites.Sprite wall209;
        private static Sprites.Sprite wall210;
        private static Sprites.Sprite wall211;

        //level2

        //level3



        private static Sprites.Sprite RightWall3;
        private static Sprites.Sprite LeftWall3;
        private static Sprites.Sprite wall301;
        private static Sprites.Sprite wall302;
        private static Sprites.Sprite wall303;
        private static Sprites.Sprite wall304;
        private static Sprites.Sprite wall305;
        private static Sprites.Sprite wall306;
        private static Sprites.Sprite wall307;
        private static Sprites.Sprite wall308;
        private static Sprites.Sprite wall309;

        //level3


        //winner level

        private static Sprites.Sprite basW;
        private static Sprites.Sprite basW2;
        private static Sprites.Sprite LeftWallW;
        private static Sprites.Sprite RightWallW;
        private static Sprites.Sprite win;
        /// <summary>
        /// Loads in sprites for level one
        /// </summary>
        /// <param name="Content"></param>
        public static void LoadLevel1(ContentManager Content)
        {
            isLoaded1 = true;
            
            FemtioXHundra = Content.Load<Texture2D>("50x100");
            HundraXFemtio = Content.Load<Texture2D>("100x50");
            FemtioXFemtio = Content.Load<Texture2D>("50x50");
            OutsideMapWall = Content.Load<Texture2D>("Wall");
            Bas = Content.Load<Texture2D>("700x50");
           
            bas = new Sprites.Sprite(Bas, 0, 450);

            LeftWall = new Sprites.Sprite(OutsideMapWall, -50, 0); // Constructor takes position of wall
            RightWall = new Sprites.Sprite(OutsideMapWall, 800, 0);

            wall1 = new Sprites.Sprite(FemtioXHundra, 700, 350);
            wall2 = new Sprites.Sprite(FemtioXHundra, 750, 350);
            wall7 = new Sprites.Sprite(FemtioXHundra, 530, 120);
            wall8 = new Sprites.Sprite(FemtioXHundra, 430, 260);
             wall9 = new Sprites.Sprite(FemtioXHundra, 430, 160);

             wall18 = new Sprites.Sprite(FemtioXHundra, -30, 100);

             wall19 = new Sprites.Sprite(FemtioXHundra, 225, 20);

             wall3 = new Sprites.Sprite(HundraXFemtio, 700, 450);
             wall4 = new Sprites.Sprite(HundraXFemtio, 480, 310);
             wall5 = new Sprites.Sprite(HundraXFemtio, 700, 300);
             wall6 = new Sprites.Sprite(HundraXFemtio, 700, 150);
             wall12 = new Sprites.Sprite(HundraXFemtio, 200, 260);
             wall15 = new Sprites.Sprite(HundraXFemtio, 125, 70);
             wall17 = new Sprites.Sprite(HundraXFemtio, -30, 20);

             wall16 = new Sprites.Sprite(HundraXFemtio, 20, 200);

             wall10 = new Sprites.Sprite(FemtioXFemtio, 480, 120);
             wall11 = new Sprites.Sprite(FemtioXFemtio, 430, 120);
             wall13 = new Sprites.Sprite(FemtioXFemtio, 275, 120);
             wall20 = new Sprites.Sprite(FemtioXFemtio, 225, 120);

            Game1._sprites.Add(bas);
            Game1._sprites.Add(LeftWall);
            Game1._sprites.Add(RightWall);
            Game1._sprites.Add(wall1);
            Game1._sprites.Add(wall2);
            Game1._sprites.Add(wall3);
            Game1._sprites.Add(wall4);
            Game1._sprites.Add(wall5);
            Game1._sprites.Add(wall6);
            Game1._sprites.Add(wall7);
            Game1._sprites.Add(wall8);
            Game1._sprites.Add(wall9);
            Game1._sprites.Add(wall10);
            Game1._sprites.Add(wall11);
            Game1._sprites.Add(wall12);
            Game1._sprites.Add(wall13);
            Game1._sprites.Add(wall15);
            Game1._sprites.Add(wall16);
            Game1._sprites.Add(wall17);
            Game1._sprites.Add(wall18);
            Game1._sprites.Add(wall19);
            Game1._sprites.Add(wall20);
            

            







            
        }
        /// <summary>
        /// Loads in sprites for level two
        /// </summary>
        /// <param name="Content"></param>
        public static void LoadLevel2(ContentManager Content)
        {
            isLoaded2 = true;

            FemtioXHundra = Content.Load<Texture2D>("50x100");
            HundraXFemtio = Content.Load<Texture2D>("100x50");
            FemtioXFemtio = Content.Load<Texture2D>("50x50");
            OutsideMapWall = Content.Load<Texture2D>("Wall");
            Bas = Content.Load<Texture2D>("700x50");

            LeftWall2 = new Sprites.Sprite(OutsideMapWall, -50, 0);
            RightWall2 = new Sprites.Sprite(OutsideMapWall, 800, 0);

            wall201 = new Sprites.Sprite(FemtioXFemtio, 0, 450);
            wall202 = new Sprites.Sprite(HundraXFemtio, 180, 400);
            wall203 = new Sprites.Sprite(FemtioXHundra, 390, 250);
            wall204 = new Sprites.Sprite(HundraXFemtio, 190, 250);
            wall205 = new Sprites.Sprite(HundraXFemtio, 50, 200);
            wall206 = new Sprites.Sprite(HundraXFemtio, 210, 70);
            wall207 = new Sprites.Sprite(HundraXFemtio, 110, 70);
            wall208 = new Sprites.Sprite(HundraXFemtio, 500, 70);
            wall209 = new Sprites.Sprite(HundraXFemtio, 580, 200);
            wall210 = new Sprites.Sprite(HundraXFemtio, 730, 120);
            wall211 = new Sprites.Sprite(FemtioXFemtio, 780, 70);


            Game1._sprites.Add(LeftWall2);
            Game1._sprites.Add(RightWall2);

            Game1._sprites.Add(wall201);
            Game1._sprites.Add(wall202);
            Game1._sprites.Add(wall203);
            Game1._sprites.Add(wall204);
            Game1._sprites.Add(wall205);
            Game1._sprites.Add(wall206);
            Game1._sprites.Add(wall207);
            Game1._sprites.Add(wall208);
            Game1._sprites.Add(wall209);
            Game1._sprites.Add(wall210);
            Game1._sprites.Add(wall211);

        }
        /// <summary>
        /// Loads in sprites for level three
        /// </summary>
        /// <param name="Content"></param>
        public static void LoadLevel3(ContentManager Content)
        {
            isLoaded3 = true;
            FemtioXHundra = Content.Load<Texture2D>("50x100");
            HundraXFemtio = Content.Load<Texture2D>("100x50");
            FemtioXFemtio = Content.Load<Texture2D>("50x50");
            OutsideMapWall = Content.Load<Texture2D>("Wall");
            Bas = Content.Load<Texture2D>("700x50");

            LeftWall3 = new Sprites.Sprite(OutsideMapWall, -50, 0);
            RightWall3 = new Sprites.Sprite(OutsideMapWall, 800, 0);


            wall301 = new Sprites.Sprite(HundraXFemtio, 740,450);
            wall302 = new Sprites.Sprite(FemtioXHundra, 610, 290);
            wall303 = new Sprites.Sprite(FemtioXHundra, 770, 190);
            wall304 = new Sprites.Sprite(HundraXFemtio, 500, 230);
            wall305 = new Sprites.Sprite(HundraXFemtio, 300, 370);
            wall308 = new Sprites.Sprite(HundraXFemtio, 400, 370);
            wall306 = new Sprites.Sprite(HundraXFemtio, 200, 170);
            wall307 = new Sprites.Sprite(FemtioXFemtio, 0, 50);
            wall309 = new Sprites.Sprite(FemtioXHundra, 175, -50);




            Game1._sprites.Add(RightWall3);
            Game1._sprites.Add(LeftWall3);

            Game1._sprites.Add(wall301);
            Game1._sprites.Add(wall302);
            Game1._sprites.Add(wall303);
            Game1._sprites.Add(wall304);
            Game1._sprites.Add(wall308);
            Game1._sprites.Add(wall305);
            Game1._sprites.Add(wall306);
            Game1._sprites.Add(wall307);
            Game1._sprites.Add(wall309);

        }
        /// <summary>
        /// Loads sprites for winner level
        /// </summary>
        /// <param name="Content"></param>
        public static void LoadWinnerLevel(ContentManager Content)
        {
            Bas = Content.Load<Texture2D>("700x50");
            uwin = Content.Load<Texture2D>("uwin");
            OutsideMapWall = Content.Load<Texture2D>("Wall");
            basW = new Sprites.Sprite(Bas, 0, 450);
            basW2 = new Sprites.Sprite(Bas, 700, 450);
            win = new Sprites.Sprite(uwin, 400, 100);

            LeftWallW = new Sprites.Sprite(OutsideMapWall, -50, 0);
            RightWallW = new Sprites.Sprite(OutsideMapWall, 800, 0);

            Game1._sprites.Add(win);
            Game1._sprites.Add(basW);
            Game1._sprites.Add(basW2);
            Game1._sprites.Add(LeftWallW);
            Game1._sprites.Add(RightWallW);

        }
        /// <summary>
        /// Removes sprites for level one
        /// </summary>
        /// <param name="Content"></param>
        public static void DeloadLevel1()
         {
             Game1._sprites.Remove(bas);

             Game1._sprites.Remove(wall1);
             Game1._sprites.Remove(wall2);
             Game1._sprites.Remove(wall3);
             Game1._sprites.Remove(wall4);
             Game1._sprites.Remove(wall5);
             Game1._sprites.Remove(wall6);
             Game1._sprites.Remove(wall7);
             Game1._sprites.Remove(wall8);
             Game1._sprites.Remove(wall9);
             Game1._sprites.Remove(wall10);
             Game1._sprites.Remove(wall11);
             Game1._sprites.Remove(wall12);
             Game1._sprites.Remove(wall13);
             Game1._sprites.Remove(wall15);
             Game1._sprites.Remove(wall16);
             Game1._sprites.Remove(wall17);
             Game1._sprites.Remove(wall18);
             Game1._sprites.Remove(wall19);
             Game1._sprites.Remove(wall20);

            isLoaded1 = false;
         }
        /// <summary>
        /// Removes sprites for level two
        /// </summary>
        /// <param name="Content"></param>
        public static void DeloadLevel2()
        {
            Game1._sprites.Remove(LeftWall2);
            Game1._sprites.Remove(RightWall2);

            Game1._sprites.Remove(wall201);
            Game1._sprites.Remove(wall202);
            Game1._sprites.Remove(wall203);
            Game1._sprites.Remove(wall204);
            Game1._sprites.Remove(wall205);
            Game1._sprites.Remove(wall206);
            Game1._sprites.Remove(wall207);
            Game1._sprites.Remove(wall208);
            Game1._sprites.Remove(wall209);
            Game1._sprites.Remove(wall210);
            Game1._sprites.Remove(wall211);
            isLoaded2 = false;
        }
        /// <summary>
        /// Removes sprites for level three
        /// </summary>
        /// <param name="Content"></param>
        public static void DeloadLevel3()
        {
            Game1._sprites.Remove(LeftWall3);
            Game1._sprites.Remove(RightWall3);

            Game1._sprites.Remove(wall301);
            Game1._sprites.Remove(wall302);
            Game1._sprites.Remove(wall303);
            Game1._sprites.Remove(wall304);
            Game1._sprites.Remove(wall305);
            Game1._sprites.Remove(wall306);
            Game1._sprites.Remove(wall307);
            Game1._sprites.Remove(wall308);
            Game1._sprites.Remove(wall309);
            isLoaded3 = false;
        }
    }
}

