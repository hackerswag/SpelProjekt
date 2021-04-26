using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;

namespace Game1
{
    
    public class Game1 : Game
    {
        
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        
        Texture2D pixel;
        Texture2D kvadrat;

        static int bruv = 3;
       
        static float velocityX;
        static float velocityY;
        static float oldvelocityX;
        static float oldvelocityY;
        bool isOnGround;

        Vector2 position = new Vector2(100, 100);
        Vector2 velocity;


        Rectangle hitbox;
        Rectangle TempLevel = new Rectangle(0, 400, 1000, 100);
        
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
            pixel = Content.Load<Texture2D>("pixel");
            kvadrat = Content.Load<Texture2D>("kvadrat2");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            
            double deltaTime =gameTime.ElapsedGameTime.TotalSeconds;

            KeyboardState kstate = Keyboard.GetState();

            hitbox = new Rectangle((int)position.X, (int)position.Y, kvadrat.Width, kvadrat.Height);

            if (kstate.IsKeyDown(Keys.W))
                velocityY = -10;
            if (kstate.IsKeyDown(Keys.A))
                velocityX = -10 * (float)deltaTime;
            if (kstate.IsKeyDown(Keys.D))
                velocityY = -10;

            if (hitbox.Intersects(TempLevel))
            {
                isOnGround = true;
            }


            if (isOnGround == false)
            {
                oldvelocityY = velocityY;
                velocityY = oldvelocityY + (float)deltaTime * 2;
            }
            else
                velocityY = 0;
            
               


            velocity = new Vector2(velocityX, velocityY);

            position += velocity; //(float)deltaTime;
            
            base.Update(gameTime);

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(kvadrat, position, Color.White);
            _spriteBatch.Draw(pixel, TempLevel, Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
