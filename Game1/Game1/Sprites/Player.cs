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

        KeyboardState kstate = Keyboard.GetState();

        public void Update(GameTime gameTime, List<Sprite> sprites)
        {
            Move();

            foreach (var sprite in sprites)
            {
                if (sprite == this)
                    continue;

                if ((this.Velocity.X > 0 && this.IsTouchingLeft(sprite)) ||
                    (this.Velocity.X < 0 & this.IsTouchingRight(sprite)))
                    this.Velocity.X = 0;

                if ((this.Velocity.Y > 0 && this.IsTouchingTop(sprite)) ||
                    (this.Velocity.Y < 0 & this.IsTouchingBottom(sprite)))
                    this.Velocity.Y = 0;
            }

        }


        private void Move()
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kstate.IsKeyUp(Keys.A) && kstate.IsKeyUp(Keys.D) && velocityX < 0)
                velocityX += 10 * deltaTime;

            if (kstate.IsKeyUp(Keys.A) && kstate.IsKeyUp(Keys.D) && velocityX > 0)
                velocityX += -10 * deltaTime;

            if (kstate.IsKeyDown(Keys.W))
                velocityY = (float)-5.5;

        }

            Velocity = new Vector2(this.velocityX, this.velocityY);
            Position += Velocity;
        }

     
    }
}
