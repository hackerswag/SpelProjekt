using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{

    public class Game1 : Game
    {

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        Texture2D kvadrat;

        Texture2D FemtioXHundra;
        Texture2D HundraXFemtio;
        Texture2D FemtioXFemtio;
        Texture2D Bas;








        static public List<Sprites.Sprite> _sprites;




        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            kvadrat = Content.Load<Texture2D>("kvadrat2");

            FemtioXHundra = Content.Load<Texture2D>("50x100");
            HundraXFemtio = Content.Load<Texture2D>("100x50");
            FemtioXFemtio = Content.Load<Texture2D>("50x50");
            Bas = Content.Load<Texture2D>("700x50");

            _sprites = new List<Sprites.Sprite>();

            Sprites.Player p = new Sprites.Player(kvadrat);
            p.Position = new Vector2(100, 400);

            //Sprites.Sprite temp2 = new Sprites.Sprite(levelsquare);
            //temp2.Position = new Vector2(300, 150);

            _sprites.Add(p);
            //_sprites.Add(temp2);
            //väggar bana 1
            Maps.LoadLevel1(Content);
        }





        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            foreach (var sprite in _sprites)
                sprite.Update(gameTime, _sprites);



            base.Update(gameTime);

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            foreach (var sprite in _sprites)
                sprite.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
        /* public void Level1()
         {



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




             _sprites.Add(wall1);
             _sprites.Add(wall2);
             _sprites.Add(wall3);
             _sprites.Add(wall4);
             _sprites.Add(wall5);
             _sprites.Add(wall6);
             _sprites.Add(wall7);
             _sprites.Add(wall8);
             _sprites.Add(wall9);
             _sprites.Add(wall10);
             _sprites.Add(wall11);
             _sprites.Add(wall12);
             _sprites.Add(wall13);
             _sprites.Add(wall15);
             _sprites.Add(wall16);
             _sprites.Add(wall17);
             _sprites.Add(wall18);
             _sprites.Add(wall19);
             _sprites.Add(wall20);


         }*/

    }
}
