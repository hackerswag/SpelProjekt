using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class PhysicsObject
    {
        public float velocityX;
        public float maxVelocityX;
        public float velocityY;
        public float oldvelocityX;
        public float oldvelocityY;
        public Vector2 position = new Vector2();
        public bool isOnGround;
        public bool isMaxSpeed;
    }
}
