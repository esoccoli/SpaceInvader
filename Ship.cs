using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devcade;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvader
{
    /// <summary>
    /// Manages the ship in the game
    /// </summary>
    internal class Ship
    {
        private Vector2 position;
        private Texture2D texture;
        private int laserCooldown;
        private Vector2 stickP1;
        private Vector2 stickP2;

        /// <summary>
        /// Current position of the ship
        /// </summary>
        public Vector2 Position { get { return position; } set { position = value; } }

        /// <summary>
        /// Texture of the ship
        /// </summary>
        public Texture2D Texture { get { return texture; } set { texture = value;} }

        /// <summary>
        /// The cooldown of the ship's lasers, in frames
        /// </summary>
        public int Cooldown { get { return laserCooldown; } set { laserCooldown = value; } }

        /// <summary>
        /// The current direction of player 1's joystick
        /// </summary>
        public Vector2 StickP1 { get { return stickP1; } set { stickP1 = value; } }

        /// <summary>
        /// The current position of player 2's joystick
        /// </summary>
        public Vector2 StickP2 { get { return stickP2; } set { stickP2 = value; } }

        /// <summary>
        /// Creates a ship with specified position, texture, and cooldown
        /// </summary>
        /// <param name="position">Start position of the ship</param>
        /// <param name="texture">Texture file of the ship</param>
        /// <param name="laserCooldown">Number of frames required to wait between lasers</param>
        public Ship (Vector2 position, Texture2D texture, int laserCooldown)
        {
            this.position = position;
            this.texture = texture;
            this.laserCooldown = laserCooldown;
        }

        /// <summary>
        /// Creates a ship with specifed position and texture
        /// </summary>
        /// <param name="position">Start position of the ship</param>
        /// <param name="texture">Texture file of the ship</param>
        public Ship(Vector2 position, Texture2D texture)
        {
            Input.Initialize();
            this.position = position;
            this.texture = texture;
            laserCooldown = 20;
        }

        public void Update(GameTime gameTime, SpriteBatch _spriteBatch)
        {
            Input.Update();

            // Gets the current position of each joystick

            if ((Game1.game.inputMan.LeftArrow == true || Game1.game.inputMan.AKey == true) &&
                position.X + 32 >= 0)
            {
                position.X -= 5;
            }
            else if ((Game1.game.inputMan.RightArrow == true || Game1.game.inputMan.DKey == true) && 
                position.X < Game1.game.GraphicsDevice.Viewport.Width - 96)
            {
                position.X += 5;
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
