using Devcade;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader
{
    /// <summary>
    /// Determines what input buttons are pressed each frame
    /// </summary>
    public class InputManager
    {
        #region Fields
        // Arrow keys
        public bool LeftArrow { get; set; }
        public bool RightArrow { get; set; }
        public bool UpArrow { get; set; }
        public bool DownArrow { get; set; }
        public bool Spacebar { get; set; }

        // WASD
        public bool WKey { get; set; }
        public bool AKey { get; set; }
        public bool SKey { get; set; }
        public bool DKey { get; set; }

        // Devcade Player 1
        public bool P1A1 { get; set; }
        public bool P1A2 { get; set; }
        public bool P1A3 { get; set; }
        public bool P1A4 { get; set; }

        public bool P1B1 { get; set; }
        public bool P1B2 { get; set; }
        public bool P1B3 { get; set; }
        public bool P1B4 { get; set; }

        public Vector2 P1Stick { get; set; }

        // Devcade Player 2
        public bool P2A1 { get; set; }
        public bool P2A2 { get; set; }
        public bool P2A3 { get; set; }
        public bool P2A4 { get; set; }

        public bool P2B1 { get; set; }
        public bool P2B2 { get; set; }
        public bool P2B3 { get; set; }
        public bool P2B4 { get; set; }

        public Vector2 P2Stick { get; set; }
        #endregion

        public InputManager()
        {
            Input.Initialize();
        }

        public void UpdateInputs()
        {
            // Arrow Keys
            LeftArrow = Keyboard.GetState().IsKeyDown(Keys.Left);
            RightArrow = Keyboard.GetState().IsKeyDown(Keys.Right);
            UpArrow = Keyboard.GetState().IsKeyDown(Keys.Up);
            DownArrow = Keyboard.GetState().IsKeyDown(Keys.Down);

            // WASD
            WKey = Keyboard.GetState().IsKeyDown(Keys.W);
            AKey = Keyboard.GetState().IsKeyDown(Keys.A);
            SKey = Keyboard.GetState().IsKeyDown(Keys.S);
            DKey = Keyboard.GetState().IsKeyDown(Keys.D);
            Spacebar = Keyboard.GetState().IsKeyDown(Keys.Space);
            // Devcade Player 1
            P1A1 = Input.GetButton(0, Input.ArcadeButtons.A1);
            P1A2 = Input.GetButton(0, Input.ArcadeButtons.A2);
            P1A3 = Input.GetButton(0, Input.ArcadeButtons.A3);
            P1A4 = Input.GetButton(0, Input.ArcadeButtons.A4);

            P1B1 = Input.GetButton(0, Input.ArcadeButtons.B1);
            P1B2 = Input.GetButton(0, Input.ArcadeButtons.B2);
            P1B3 = Input.GetButton(0, Input.ArcadeButtons.B3);
            P1B4 = Input.GetButton(0, Input.ArcadeButtons.B4);

            P1Stick = Input.GetStick(0);

            // Devcade Player 2
            P2A1 = Input.GetButton(1, Input.ArcadeButtons.A1);
            P2A2 = Input.GetButton(1, Input.ArcadeButtons.A2);
            P2A3 = Input.GetButton(1, Input.ArcadeButtons.A3);
            P2A4 = Input.GetButton(1, Input.ArcadeButtons.A4);

            P2B1 = Input.GetButton(1, Input.ArcadeButtons.B1);
            P2B2 = Input.GetButton(1, Input.ArcadeButtons.B2);
            P2B3 = Input.GetButton(1, Input.ArcadeButtons.B3);
            P2B4 = Input.GetButton(1, Input.ArcadeButtons.B4);

            P2Stick = Input.GetStick(1);
        }
    }
}
