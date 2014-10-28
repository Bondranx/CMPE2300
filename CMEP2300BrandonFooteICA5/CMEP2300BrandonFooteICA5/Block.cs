using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace CMEP2300BrandonFooteICA5
{
    public enum ESortType
    {
        eSize,
        eDistance,
        eColor
    }
    class Block : IComparable
    {
        public static CDrawer _Canvas = new CDrawer();
        public static Random _newRandom = new Random();
        private int _blockSize;
        public int blockSize
        {
            set
            {
                _blockSize = Math.Abs(value);
            }
        }
        public Color _blockColor;
        public Rectangle _newRectangle;

        static Block()
        {
            _Canvas.ContinuousUpdate = false;
        }
        public Block(int blockSizerecieved)
        {
            _blockColor = RandColor.GetColor();
            blockSize = blockSizerecieved;
            _newRectangle.Height = _blockSize;
            _newRectangle.Width = _blockSize;
            do
            {
                _newRectangle.X = _newRandom.Next(0, _Canvas.ScaledWidth);
                _newRectangle.Y = _newRandom.Next(0, _Canvas.ScaledHeight);
            }
            while (_newRectangle.X < 0 || _newRectangle.X + _blockSize > _Canvas.ScaledWidth || _newRectangle.Y < 0 || _newRectangle.Y + _blockSize > _Canvas.ScaledHeight);
        }
        public void AddBlock()
        {
            _Canvas.AddRectangle(_newRectangle.X, _newRectangle.Y, _blockSize, _blockSize, _blockColor);
        }

        public static bool blockSwitch
        {
            set
            {
                if (value == true)
                {
                    _Canvas.Clear();
                }
                else if (value == false)
                {
                    _Canvas.Render();
                }
            }
        }
        public static ESortType newSort;

        public int CompareTo(object obj)
        {
            int result = 0;
            if (!(obj is Block))
                throw new ArgumentException("Invalid object type");
            Block temp = obj as Block;

            if (newSort == ESortType.eColor)
            {
                if (this._blockColor.ToArgb() < temp._blockColor.ToArgb())
                    result = 1;
                else if (this._blockColor.ToArgb() > temp._blockColor.ToArgb())
                    result = -1;
                else if (this._blockColor.ToArgb() == temp._blockColor.ToArgb())
                    result = 0;
            }
            else if (newSort == ESortType.eDistance)
            {
                Point tempPoint = new Point(0,0);
                if (GetDistance(tempPoint, this._newRectangle.Location) < GetDistance(tempPoint, temp._newRectangle.Location))
                    result = -1;
                else if (GetDistance(tempPoint, this._newRectangle.Location) > GetDistance(tempPoint, temp._newRectangle.Location))
                    result = 1;
                else if (GetDistance(tempPoint, this._newRectangle.Location) == GetDistance(tempPoint, temp._newRectangle.Location))
                    result = 0;
            }
            else if (newSort == ESortType.eSize)
            {
                if (this._blockSize < temp._blockSize)
                    result = -1;
                else if (this._blockSize > temp._blockSize)
                    result = 1;
                else if (this._blockSize == temp._blockSize)
                    result = 0;
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Block))
                return false;
            Block temp = (Block)obj;
            return temp._newRectangle.IntersectsWith(this._newRectangle);
        }

        public static double GetDistance(Point p, Point q)
        {
            double a = p.X - q.X;
            double b = p.Y - q.Y;
            double distance = Math.Sqrt(a * a + b * b);
            return distance;
        }
    }
}
