using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class Maps
    {

            public static void LoadLevel1(ContentManager Content)  
        {
            Texture2D FemtioXHundra;
            Texture2D HundraXFemtio;
            Texture2D FemtioXFemtio;
            Texture2D Bas;
            FemtioXHundra = Content.Load<Texture2D>("50x100");
            HundraXFemtio = Content.Load<Texture2D>("100x50");
            FemtioXFemtio = Content.Load<Texture2D>("50x50");
            Bas = Content.Load<Texture2D>("700x50");
            Sprites.Sprite bas = new Sprites.Sprite(Bas, 0, 450);


            Sprites.Sprite wall1 = new Sprites.Sprite(FemtioXHundra, 700, 350);
            Sprites.Sprite wall2 = new Sprites.Sprite(FemtioXHundra, 750, 350);
            Sprites.Sprite wall7 = new Sprites.Sprite(FemtioXHundra, 530, 120);
            Sprites.Sprite wall8 = new Sprites.Sprite(FemtioXHundra, 430, 260);
            Sprites.Sprite wall9 = new Sprites.Sprite(FemtioXHundra, 430, 160);

            Sprites.Sprite wall18 = new Sprites.Sprite(FemtioXHundra, -30, 100);

            Sprites.Sprite wall19 = new Sprites.Sprite(FemtioXHundra, 225, 20);


            Sprites.Sprite wall3 = new Sprites.Sprite(HundraXFemtio, 700, 450);
            Sprites.Sprite wall4 = new Sprites.Sprite(HundraXFemtio, 480, 310);
            Sprites.Sprite wall5 = new Sprites.Sprite(HundraXFemtio, 700, 300);
            Sprites.Sprite wall6 = new Sprites.Sprite(HundraXFemtio, 700, 150);
            Sprites.Sprite wall12 = new Sprites.Sprite(HundraXFemtio, 200, 260);
            Sprites.Sprite wall15 = new Sprites.Sprite(HundraXFemtio, 125, 70);
            Sprites.Sprite wall17 = new Sprites.Sprite(HundraXFemtio, -30, 20);

            Sprites.Sprite wall16 = new Sprites.Sprite(HundraXFemtio, 20, 200);


            Sprites.Sprite wall10 = new Sprites.Sprite(FemtioXFemtio, 480, 120);
            Sprites.Sprite wall11 = new Sprites.Sprite(FemtioXFemtio, 430, 120);
            Sprites.Sprite wall13 = new Sprites.Sprite(FemtioXFemtio, 275, 120);
            Sprites.Sprite wall20 = new Sprites.Sprite(FemtioXFemtio, 225, 120);


            Game1._sprites.Add(bas);

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
       /* public static void DeloadLevel1()
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
        }*/
        }
    }

