using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.Sprites
{
    public class Player : Sprite
    {

        public Player(Texture2D texture)
          : base(texture)
        {

        }




        public override void Update(GameTime gameTime, List<Sprite> sprites)
        {
            KeyboardState kstate = Keyboard.GetState();

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            maxVelocityX = 15;

            if (isOnGround == true && isMaxSpeed == false) //Allows horizontal movement while on the ground
            {

                if (kstate.IsKeyDown(Keys.A) && isOnWallLeft == false)
                {
                    if (this.velocityX > 0)
                        this.velocityX += -10 * deltaTime;
                    this.velocityX += -5 * deltaTime;
                }

                if (kstate.IsKeyDown(Keys.D) && isOnWallRight == false)
                {
                    if (this.velocityX < 0)
                        this.velocityX += 10 * deltaTime;
                    this.velocityX += 5 * deltaTime;
                }
            }

            if (isOnGround == false) // Allows wall jumps
            {
                if (kstate.IsKeyDown(Keys.W) && isOnWallRight == true)
                {
                    this.velocityY = -5.5f;
                    this.velocityX = -3.5f;
                }
                if (kstate.IsKeyDown(Keys.W) && isOnWallLeft == true)
                {
                    this.velocityY = -5.5f;
                    this.velocityX = 3.5f;
                }
            }

            if (this.isOnGround == false) // Falling physics
            {
                this.oldvelocityY = this.velocityY;
                this.velocityY = this.oldvelocityY + 10 * deltaTime;
            }

            if (isOnGround == true) //Slows player down if no keys are held
            {
                if (kstate.IsKeyUp(Keys.A) && kstate.IsKeyUp(Keys.D) && velocityX < 0)
                    velocityX += 10 * deltaTime;

                if (kstate.IsKeyUp(Keys.A) && kstate.IsKeyUp(Keys.D) && velocityX > 0)
                    velocityX += -10 * deltaTime;
            }
            if (this.isOnGround == true) //Allows jumping while on the ground
            {
                if (kstate.IsKeyDown(Keys.W)) 
                {
                    this.velocityY = (float)-5.5;
                    //this.isOnGround = false;
                }
            }

            if (this.velocityX > 0)
                isOnWallLeft = false;
            if (this.velocityX < 0)
                isOnWallRight = false;



            Velocity = new Vector2(this.velocityX, this.velocityY); //Updates position based on velocity
            Position += Velocity;
            Velocity = Vector2.Zero;

            if (this.velocityX == maxVelocityX)
                isMaxSpeed = true;

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if (this.velocityX > 0 && this.IsTouchingLeft(sprite)) //Stops player X speed if colliding to the right
                {
                    this.velocityX = 0;
                    this.Position.X = sprite.Rectangle.Left - this._texture.Width; // prevents clipping into sprites
                    this.isOnWallRight = true;
                    sprite.playerIsAgainstLeft = true;
                    sprite.Colour = Color.Crimson;
                }
               
                if (this.velocityX < 0 && this.IsTouchingRight(sprite)) //Stops player X speed if colliding to the left
                {
                    this.velocityX = 0;
                    this.isOnWallLeft = true;
                    sprite.playerIsAgainstRight = true;
                    this.Position.X = sprite.Rectangle.Right;
                    sprite.Colour = Color.Crimson;
                    
                }
                if (this.velocityY > 0 && this.IsTouchingTop(sprite)) //Stops player Y speed if colliding with sprite below
                {
                    this.velocityY = 0;
                    this.Position.Y = sprite.Rectangle.Top - this._texture.Height;
                    this.isOnGround = true;
                    sprite.playerIsOn = true;
                    sprite.Colour = Color.Red;

                }


                if (this.velocityY < 0 && this.IsTouchingBottom(sprite)) //Stops players Y speed if colliding with sprite above
                {
                    this.velocityY = 0;
                    this.isOnGround = false;
                    this.Position.Y = sprite.Rectangle.Bottom;


                    //this.Position.Y = sprite.Rectangle.Top - this._texture.Height;

                }

                if (sprite.playerIsOn == true)
                {
                    if (this.Rectangle.X > (sprite.Rectangle.X + sprite.Rectangle.Width) && sprite.playerIsOn==true|| 
                        (this.Rectangle.X + this.Rectangle.Width) <sprite.Rectangle.X && sprite.playerIsOn == true)
                    {
                        isOnGround = false;
                        sprite.Colour = Color.White;
                        //sprite.playerIsOn = false;

                    }
                   
                }

                if (sprite.playerIsAgainstLeft == true) //Checks if player has stopped coliding with wall to the left
                {
                    if (this.Rectangle.Y > (sprite.Rectangle.Y+sprite.Rectangle.Height) ||
                        (this.Rectangle.Y + this.Rectangle.Height) < (sprite.Rectangle.Y))
                    {
                        sprite.Colour = Color.White;
                        this.isOnWallRight = false;
                        sprite.playerIsAgainstLeft = false;
                    }
                }
                if (sprite.playerIsAgainstRight == true) //Checks if player has stopped coliding with wall to the right
                {
                    if (this.Rectangle.Y > (sprite.Rectangle.Y + sprite.Rectangle.Height) ||
                        (this.Rectangle.Y+this.Rectangle.Height) < (sprite.Rectangle.Y))
                    {
                        sprite.Colour = Color.White;
                        this.isOnWallLeft = false;
                        sprite.playerIsAgainstRight = false;
                    }
                }

                if (this.velocityY != 0)
                {
                    this.isOnGround = false;
                    sprite.playerIsOn = false;
                    if (sprite.Colour == Color.Red)
                        sprite.Colour = Color.White;
                }
                    


            }







        }
    }
}
