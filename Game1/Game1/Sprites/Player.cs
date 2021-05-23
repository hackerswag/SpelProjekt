using System;
using System.Collections.Generic;
using System.Text;
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

            if (isOnGround == true && isMaxSpeed == false)
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

            if (isOnGround == false)
            {
                if(kstate.IsKeyDown(Keys.W) && isOnWallRight == true)
                {
                    this.velocityY = -5.5f;
                    this.velocityX = -3.5f;
                }
                if (kstate.IsKeyDown(Keys.W) && isOnWallLeft == true)
                {
                    this.velocityY = -5.5f;
                    this.velocityX = -3.5f;
                }
            }

            if (this.isOnGround == false)
            {
                this.oldvelocityY = this.velocityY;
                this.velocityY = this.oldvelocityY + 10 * deltaTime;
            }

            if (isOnGround == true)
            {
                if (kstate.IsKeyUp(Keys.A) && kstate.IsKeyUp(Keys.D) && velocityX < 0)
                    velocityX += 10 * deltaTime;

                if (kstate.IsKeyUp(Keys.A) && kstate.IsKeyUp(Keys.D) && velocityX > 0)
                    velocityX += -10 * deltaTime;
            }
            if (this.isOnGround == true)
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



                Velocity = new Vector2(this.velocityX, this.velocityY);
                Position += Velocity;
                Velocity = Vector2.Zero;

                if (this.velocityX == maxVelocityX)
                    isMaxSpeed = true;

                foreach (var sprite in sprites)
                {
                    if (sprite == this)
                        continue;

                    if (this.velocityX > 0 && this.IsTouchingLeft(sprite))
                    {
                        this.velocityX = 0;
                        this.isOnWallRight = true;
                    }
                    if (this.velocityX < 0 && this.IsTouchingRight(sprite))
                    {
                        this.velocityX = 0;
                        this.isOnWallLeft = true;
                    }
                    if (this.velocityY > 0 && this.IsTouchingTop(sprite))
                    {

                        this.velocityY = 0;
                    }


                    if (this.velocityY < 0 && this.IsTouchingBottom(sprite))
                    {
                        this.velocityY = 0;

                    }

                    if (this.velocityY == 0)
                    {
                        isOnGround = true;
                    }
                    else
                        isOnGround = false;

                }

            





        }
    }
}
