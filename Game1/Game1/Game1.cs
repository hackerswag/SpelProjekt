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
        Texture2D levelsquare;
       
        Stopwatch stopWatch = new Stopwatch();

        Vector2 position = new Vector2(100, 100);

        Rectangle TempLevel = new Rectangle(0, 400, 1000, 100);
        Rectangle TempWall = new Rectangle(500, 200, 100, 1000);

        

        private List<Sprites.Sprite> _sprites;

        


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
            levelsquare = Content.Load<Texture2D>("pixil-frame-0 (1)");
            _sprites = new List<Sprites.Sprite>();
            
            Sprites.Player p = new Sprites.Player(kvadrat);
            p.Position = new Vector2(100, 100);
            Sprites.Sprite temp = new Sprites.Sprite(levelsquare);
            temp.Position = new Vector2(100, 300);

            _sprites.Add(temp);
            _sprites.Add(p);
                
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
    }
}
