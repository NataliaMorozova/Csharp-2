using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Asteroid
{
    class Star : BaseObject
    {
        public Star(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawLine(Pens.Pink, Pos.X, Pos.Y, Pos.X + Size.Width,
            Pos.Y + Size.Height);
            Game.Buffer.Graphics.DrawLine(Pens.Pink, Pos.X + Size.Width, Pos.Y, Pos.X,
            Pos.Y + Size.Height);
            Game.Buffer.Graphics.DrawLine(Pens.Purple, Pos.X + Size.Width/2, Pos.Y, Pos.X + Size.Width / 2,
            Pos.Y + Size.Height);
            Game.Buffer.Graphics.DrawLine(Pens.Purple, Pos.X, Pos.Y + Size.Height/2, Pos.X + Size.Width,
            Pos.Y + Size.Height/2);
        }

        public override void Update()
        {
                        Pos.X = Pos.X + Dir.X;
            Pos.Y = Pos.Y + Dir.Y;
            if (Pos.X < 0) Dir.X = -Dir.X;
            if (Pos.X > Game.Width) Dir.X = -Dir.X;
            if (Pos.Y < 0) Dir.Y = -Dir.Y;
            if (Pos.Y > Game.Height) Dir.Y = -Dir.Y;
            //Pos.X = Pos.X + Dir.X;
            //if (Pos.X < 0) Pos.X = Game.Width + Size.Width;
        }

    }
}
