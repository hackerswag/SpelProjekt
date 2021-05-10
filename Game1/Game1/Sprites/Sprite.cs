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
        protected Texture2D _texture;
        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, _texture.Width, _texture.Height); //skapar rektangel på spriten (hitbox)
            }
        }
        public Sprite(Texture2D texture)
        {
            _texture = texture;
        }




        public float maxvelocityX;
        public float velocityX;
        public float maxVelocityX;
        public float velocityY;
        public float oldvelocityX;
        public float oldvelocityY;
        public Vector2 Position;
        public Vector2 Velocity;
       



        protected bool IsTouchingLeft(Sprite sprite) // Kollar om sprite rör till vänster
        {
            return this.Rectangle.Right + this.Velocity.X > sprite.Rectangle.Left &&
              this.Rectangle.Left < sprite.Rectangle.Left &&
              this.Rectangle.Bottom > sprite.Rectangle.Top &&
              this.Rectangle.Top < sprite.Rectangle.Bottom;
        }

        protected bool IsTouchingRight(Sprite sprite) // Till höger
        {
            return this.Rectangle.Left + this.Velocity.X < sprite.Rectangle.Right &&
              this.Rectangle.Right > sprite.Rectangle.Right &&
              this.Rectangle.Bottom > sprite.Rectangle.Top &&
              this.Rectangle.Top < sprite.Rectangle.Bottom;
        }

        protected bool IsTouchingTop(Sprite sprite) //Kollar om rör över
        {
            return this.Rectangle.Bottom + this.Velocity.Y > sprite.Rectangle.Top &&
              this.Rectangle.Top < sprite.Rectangle.Top &&
              this.Rectangle.Right > sprite.Rectangle.Left &&
              this.Rectangle.Left < sprite.Rectangle.Right;
        }

        protected bool IsTouchingBottom(Sprite sprite) // Under
        {
            return this.Rectangle.Top + this.Velocity.Y < sprite.Rectangle.Bottom &&
              this.Rectangle.Bottom > sprite.Rectangle.Bottom &&
              this.Rectangle.Right > sprite.Rectangle.Left &&
              this.Rectangle.Left < sprite.Rectangle.Right;
        }

    }
}
