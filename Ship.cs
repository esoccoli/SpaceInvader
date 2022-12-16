using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Vector2 Position { get { return position; } set { position = value; } }

        public Texture2D Texture { get { return texture; } set { texture = value;} }

        public int Cooldown { get { return laserCooldown; } set { laserCooldown = value; } }

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
            this.position = position;
            this.texture = texture;
            laserCooldown = 20;
        }


    }
}
