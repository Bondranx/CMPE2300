using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace CMPE2300BrandonFooteICA7 
{
    class Block : IComparable
    {
        public static CDrawer _Canvas { get; private set;}
        public static int _height { get; private set; }
        public static int _highlightWidth;
        private static Random _newRandom = new Random(1);
        public int _width { get; private set; }
        public bool _highlight { get; set; }
        private Color _newColor;

        static Block()
        {
            _height = 20;
            _highlightWidth = 0;
            _Canvas = new CDrawer();
            _Canvas.BBColour = Color.White;
            _Canvas.ContinuousUpdate = false;
        }
        public Block()
        {
            int tempWidth = _newRandom.Next(10, 190);
            if (tempWidth % 10 != 0)
            {
                tempWidth = _newRandom.Next(10, 190);
            }
            _width = tempWidth;
            _highlight = false;
            _newColor = Color.FromArgb(_newRandom.Next(2, 8) * 32, _newRandom.Next(2, 8) * 16, _newRandom.Next(2, 8) * 16);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Block))
                return false;
            Block temp = (Block)obj;
            return (this._width == temp._width && this._newColor == temp._newColor);
        }
        public void ShowBlock(Point newPoint)
        {
            _Canvas.AddRectangle(newPoint.X, newPoint.Y, _width, _height, _newColor, 1, Color.Black);
            if(_highlight==true)
                _Canvas.AddRectangle(newPoint.X, newPoint.Y, _width, _height, _newColor, 2, Color.Yellow);

        }

        public int CompareTo(object obj)
        {
            if (!(obj is Block))
                throw new ArgumentException("Incorrect type in CompareTo()");
            Block temp = (Block)obj;
            if (this._newColor.ToArgb() < temp._newColor.ToArgb())
                return -1;
            else if (this._newColor.ToArgb() > temp._newColor.ToArgb())
                return 1;
            else
                return 0;
        }
        internal static int SortWidth(Block A, Block B)
        {
            if (A._width < B._width)
                return -1;
            else if (A._width > B._width)
                return 1;
            else
                return 0;
        }

        internal static int SortWidthColor(Block A, Block B)
        {
            if (A._newColor.ToArgb() > B._newColor.ToArgb())
                return 1;
            else if (A._newColor.ToArgb() < B._newColor.ToArgb())
                return -1;
            else
                if (A._width < B._width)
                    return -1;
                else if (A._width > B._width)
                    return 1;
                else
                    return 0;
        }
        internal static bool isBright(Block A)
        {
            return (A._newColor.GetBrightness() > .5);
        }
        internal static bool isLong(Block A)
        {
            return (A._width > 100);
        }
        internal static bool isHighlighted(Block A)
        {
            return (A._width<= _highlightWidth+10 && A._width >= _highlightWidth-10);
        }
    }
}
