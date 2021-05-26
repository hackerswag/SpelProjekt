using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.Sprites
{
    public class Sprite
    {


        public float velocityX;
        public float maxVelocityX;
        public float velocityY;

        public float oldvelocityY;
        public Vector2 Position;
        public Vector2 Velocity;

        public bool isOnGround;
        public bool isMaxSpeed;
        public bool isOnWallRight;
        public bool isOnWallLeft;
        public bool playerIsOn;
        public bool playerIsAgainstLeft;
        

        public bool playerIsAgainstRight;
        public Color Colour = Color.White;

        protected Texture2D _texture;

        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, _texture.Width, _texture.Height); //Creates rectangle on sprite, allows for collision detection (hitbox)
            }
        }

        public Sprite(Texture2D texture, int x, int y) //Constructor takes position of sprite
        {
            _texture = texture;
            Position = new Vector2(x, y);
            


        }
        public Sprite(Texture2D texture)
        {
            _texture = texture;

        }

        public virtual void Update(GameTime gameTime, List<Sprite> sprites)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, Position, Colour);
        }
        /// <summary>
        /// Gets position of Sprite and other object and checks if they will collide in next update
        /// </summary>
        /// <param name="sprite"></param>
        /// <returns>A bool value based on collision or not</returns>
        protected bool IsTouchingLeft(Sprite sprite) // Kollar om sprite rör till vänster
        {
            return this.Rectangle.Right + this.Velocity.X > sprite.Rectangle.Left &&
              this.Rectangle.Left < sprite.Rectangle.Left &&
              this.Rectangle.Bottom > sprite.Rectangle.Top &&
              this.Rectangle.Top < sprite.Rectangle.Bottom;
        }
        /// <summary>
        /// Gets position of Sprite and other object and checks if they will collide in next update
        /// </summary>
        /// <param name="sprite"></param>
        /// <returns>A bool value based on collision or not</returns>
        protected bool IsTouchingRight(Sprite sprite) /// Till höger
        {
            return this.Rectangle.Left + this.Velocity.X < sprite.Rectangle.Right &&
              this.Rectangle.Right > sprite.Rectangle.Right &&
              this.Rectangle.Bottom > sprite.Rectangle.Top &&
              this.Rectangle.Top < sprite.Rectangle.Bottom;
        }
        /// <summary>
        /// Gets position of Sprite and other object and checks if they will collide in next update
        /// </summary>
        /// <param name="sprite"></param>
        /// <returns>A bool value based on collision or not</returns>
        protected bool IsTouchingTop(Sprite sprite) //Kollar om rör över
        {
            return this.Rectangle.Bottom + this.Velocity.Y > sprite.Rectangle.Top &&
              this.Rectangle.Top < sprite.Rectangle.Top &&
              this.Rectangle.Right > sprite.Rectangle.Left &&
              this.Rectangle.Left < sprite.Rectangle.Right;
        }
        /// <summary>
        /// Gets position of Sprite and other object and checks if they will collide in next update
        /// </summary>
        /// <param name="sprite"></param>
        /// <returns>A bool value based on collision or not</returns>
        protected bool IsTouchingBottom(Sprite sprite) // Under
        {
            return this.Rectangle.Top + this.Velocity.Y < sprite.Rectangle.Bottom &&
              this.Rectangle.Bottom > sprite.Rectangle.Bottom &&
              this.Rectangle.Right > sprite.Rectangle.Left &&
              this.Rectangle.Left < sprite.Rectangle.Right;
        }

    }
        
    }
    

