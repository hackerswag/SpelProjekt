using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace Game1
{
    
    public class Game1 : Game
    {
        
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        
        Texture2D pixel;
        Texture2D kvadrat;


        static float velocityX;
        static float maxVelocityX;
        static float velocityY;
        static float oldvelocityX;
        static float oldvelocityY;
        bool isOnGround;
        bool isMaxSpeed;
        bool touchingWall;
        
        Stopwatch stopWatch = new Stopwatch();

        Vector2 position = new Vector2(100, 100);
        Vector2 velocity;        
        Rectangle hitbox;
        Rectangle nextHitbox;
        Rectangle TempLevel = new Rectangle(0, 400, 1000, 100);
        Rectangle TempWall = new Rectangle(500, 200, 100, 1000); 

        

        
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
            
            float deltaTime =(float)gameTime.ElapsedGameTime.TotalSeconds;

            KeyboardState kstate = Keyboard.GetState();

            //hitbox = new Rectangle((int)position.X, (int)position.Y, kvadrat.Width, kvadrat.Height);
            //nextHitbox = new Rectangle((int)position.X + (int)velocityX, (int)position.Y + (int)velocityX, kvadrat.Width, kvadrat.Height);


            

            

            
            
            if (isOnGround == true && isMaxSpeed == false)
            {
                if (kstate.IsKeyDown(Keys.A))
                {
                    if (velocityX > 0)
                        velocityX += -10 * deltaTime;
                    velocityX += -5 * deltaTime;
                }

                if (kstate.IsKeyDown(Keys.D))
                {
                    if (velocityX < 0)
                        velocityX += 10 * deltaTime;
                    velocityX += 5 * deltaTime;
                }           


                
            }

            if (velocityX == maxVelocityX)
                isMaxSpeed = true;



            if (hitbox.Right == TempWall.Left)
            {
                touchingWall = true;
                if (isOnGround == false && touchingWall == true)
                    velocityX = 0;
                if (isOnGround == true && touchingWall == true) ;


                
            }

            if (nextHitbox.Intersects(TempLevel))
            {
                isOnGround = true;
                touchingWall = false;
                velocityY = 0;
            }
            else
                isOnGround = false;


            
            
                                                             


            if (isOnGround == false)
            {
                oldvelocityY = velocityY;
                velocityY = oldvelocityY + deltaTime * 10;
            }

            

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
            _spriteBatch.Draw(pixel, TempWall, Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
