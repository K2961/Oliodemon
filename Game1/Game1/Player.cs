using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    class Player
    {
        public Texture2D PlayerTexture;
        public Vector2 Position;
        public bool Active;
        public int Healt;

        public int Width
        {
            get { return PlayerTexture.Width; }
        }

        public int Heigth
        {
            get { return PlayerTexture.Height; }
        }

        public void Initialize(Texture2D texture,Vector2 position)
        {
            //Player picture
            PlayerTexture = texture;

            Position = position;

            Active = true;

            Healt = 100;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}
