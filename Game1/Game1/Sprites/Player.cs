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
                if (kstate.IsKeyDown(Keys.A))
                {
                    if (this.velocityX > 0)
                        this.velocityX += -10 * deltaTime;
                    this.velocityX += -5 * deltaTime;
                }

                if (kstate.IsKeyDown(Keys.D))
                {
                    if (this.velocityX < 0)
                        this.velocityX += 10 * deltaTime;
                    this.velocityX += 5 * deltaTime;
                }
            }


            if (this.isOnGround == true)
            {
                if (kstate.IsKeyDown(Keys.W))
                {
                    this.velocityY = (float)-5.5;
                    //this.isOnGround = false;
                }
                    
                

            }


            if (this.isOnGround == false)
            {
                //this.oldvelocityY = this.velocityY;
                this.velocityY = 3;
            }
            

            Velocity = new Vector2(this.velocityX, this.velocityY);
            Position += Velocity;
            Velocity = Vector2.Zero;

            if (this.velocityX == maxVelocityX)
                isMaxSpeed = true;

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if ((this.velocityX > 0 && this.IsTouchingLeft(sprite)) ||
                    (this.velocityX < 0 & this.IsTouchingRight(sprite)))
                {
                    this.velocityX = 0;

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
                    
            }

        }


      

     
    }
}
