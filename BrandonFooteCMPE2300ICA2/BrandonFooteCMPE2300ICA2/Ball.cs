using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace BrandonFooteCMPE2300ICA2
{
    public class Ball
    {
        public static Random newRandom = new Random();
        private Point _LocationCenter;
        public Point Location
        {
            get { return _LocationCenter; }
        }
        public int _xVelocity;
        public int _yVelocity;
        public int X
        {
            set { _xVelocity = value; }
        }
        public int Y
        {
            set { _yVelocity = (value); }
        }
        public Color _BallColor;
        public int _BallOpacity {get; set; }
        public const int _BallRadius = 40;

        public Ball(Point CPoint)
        {
            _LocationCenter = CPoint;
            _BallColor = GDIDrawer.RandColor.GetColor();
            _xVelocity = newRandom.Next(-6, 5);
            _yVelocity = newRandom.Next(-6, 5);
            _BallOpacity = 128;
        }

        public void MoveBall(CDrawer Canvas)
        {
            int tempX = _LocationCenter.X;
            int tempY = _LocationCenter.Y;
            if (tempX < 0 || tempX > Canvas.ScaledWidth)
            {
                _xVelocity = _xVelocity * -1;
            }
            if (tempY < 0 || tempY > Canvas.ScaledHeight)
            {
                _yVelocity = _yVelocity * -1;
            }
            _LocationCenter.X = _LocationCenter.X + _xVelocity;
            _LocationCenter.Y = _LocationCenter.Y + _yVelocity;
        }
        public void ShowBall(CDrawer Canvas)
        {
            Canvas.AddCenteredEllipse(_LocationCenter.X,_LocationCenter.Y,_BallRadius,_BallRadius,Color.FromArgb(_BallOpacity,_BallColor.R,_BallColor.G,_BallColor.B));
        }
    }
}
