using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace CMPE2300BrandonFooteICA3
{
    public class Ball
    {
        public static Random _newRandom = new Random();
        public static CDrawer _Canvas = null;
        private static int _Radius;
        public static int Radius
        {
            set
            {
                _Radius = Math.Abs(value);
            }
        }
        public Color _Color = new Color();
        public Point _Point = new Point();
        public int _xVelocity;
        public int _yVelocity;
        public int _iAlive = 3;

        static Ball()
        {
            _Canvas = new CDrawer(_newRandom.Next(599, 900), _newRandom.Next(499, 800), false);
            Radius = _newRandom.Next(9, 80);
        }

        public Ball()
        {
            _Color = GDIDrawer.RandColor.GetColor();
            _xVelocity = _newRandom.Next(-11, 10);
            _yVelocity = _newRandom.Next(-11, 10);
            _Point.X = _newRandom.Next(0, _Canvas.ScaledWidth);
            while (_Point.X - _Radius < 0 || _Point.X + _Radius > _Canvas.ScaledWidth)
            {
                _Point.X = _newRandom.Next(0, _Canvas.ScaledWidth);
            }
            _Point.Y = _newRandom.Next(0, _Canvas.ScaledHeight);
            while (_Point.Y - _Radius < 0 || _Point.Y + _Radius > _Canvas.ScaledHeight)
            {
                _Point.Y = _newRandom.Next(0, _Canvas.ScaledHeight);
            }
        }

        public void ShowBall()
        {
            _Canvas.AddCenteredEllipse(_Point.X, _Point.Y, _Radius, _Radius, Color.FromArgb(_iAlive, _Color));
        }

        public void MoveBall()
        {
            _iAlive--;
            if (_iAlive < 1)
            {
                _iAlive = _newRandom.Next(49, 127);
            }
            if (_Point.X - _Radius < 0 || _Point.X + _Radius > _Canvas.ScaledWidth)
            {
                _xVelocity = _xVelocity * -1;
            }
            if (_Point.Y - _Radius < 0 || _Point.Y + _Radius > _Canvas.ScaledHeight)
            {
                _yVelocity = _yVelocity * -1;
            }
        }
        public static bool _Loading
        {
            set
            {
                if (value == false)
                {
                    _Canvas.Render();                  
                }
                if (value == true)
                {
                    _Canvas.Clear(); 
                }
            }
        }
    }
}
