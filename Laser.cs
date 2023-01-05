using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader
{
    internal class Laser
    {
        private int X { get; set; }
        private int Y { get; set; }
        private int Width { get; set; }
        private int Height { get; set; }
        private Rectangle Beam { get; set; }
        private Color Color { get; set; }

        public Laser(int x, int y, int width, int height, Color color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Beam = new Rectangle(X, Y, Width, Height);
            Color = color;
        }

        public Laser(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Beam = new Rectangle(X, Y, Width, Height);
            Color = Color.Green;
        }

        public Laser(Rectangle beam, Color color)
        {
            Beam = beam;
            X = beam.X;
            Y = beam.Y;
            Width = beam.Width;
            Height = beam.Height;
            Color = color;
        }

        public Laser(Rectangle beam)
        {
            Beam = beam;
            X = beam.X;
            Y = beam.Y;
            Width = beam.Width;
            Height = beam.Height;
            Color = Color.Green;
        }
    }
}
