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



        static public List<Sprites.Sprite> _sprites;

        Sprites.Player p;


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

          
            _sprites = new List<Sprites.Sprite>();

            p = new Sprites.Player(kvadrat);
            p.Position = new Vector2(50, 400);

           

            _sprites.Add(p);
            
            Maps.LoadLevel1(Content);

        }





        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            if (Maps.isLoaded1 == true)
            {
                if(p.Position.X<40 && p.Position.Y < 20) //Loads next level once level 1 is done
                {
                    Maps.DeloadLevel1();
                    Maps.LoadLevel2(Content);
                    p.Position.Y = 400;
                }
            }

            if (Maps.isLoaded2 == true) 
            {
                if(p.Position.Y > 450) //Loads next level if player clears level1
                {
                    Maps.DeloadLevel2();
                    Maps.LoadLevel1(Content);
                    p.Position.Y = 0;
                }
                if(p.Position.Y <70 && p.Position.X > 720) //Loads next level 1 if player falls down
                {
                    Maps.DeloadLevel2();
                    Maps.LoadLevel3(Content);
                    p.Position.Y = 400;
                }

            }
            if (Maps.isLoaded3 == true)
            {
                if(p.Position.Y > 450)  //Loads next level 2 if player falls down
                {
                    Maps.DeloadLevel3();
                    Maps.LoadLevel2(Content);
                    p.Position.Y = 0;
                }
                if (p.Position.Y < 50 && p.Position.X < 50)  //Loads winner level if player clears level3
                {
                    Maps.DeloadLevel3();
                    Maps.LoadWinnerLevel(Content);
                    p.Position.Y = 0;
                    
                }
            }

            foreach (var sprite in _sprites)
                sprite.Update(gameTime, _sprites);



            base.Update(gameTime);
            

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            foreach (var sprite in _sprites) //Draws all sprites in _sprites
                sprite.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }       

    }
}
