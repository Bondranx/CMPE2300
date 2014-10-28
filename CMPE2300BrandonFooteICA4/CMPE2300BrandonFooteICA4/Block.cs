using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace CMPE2300BrandonFooteICA4
{
    class Block
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
            while (_newRectangle.X < 0 || _newRectangle.X + _blockSize > _Canvas.ScaledWidth || _newRectangle.Y< 0 || _newRectangle.Y + _blockSize > _Canvas.ScaledHeight);
        }
        public void AddBlock()
        {
            _Canvas.AddRectangle(_newRectangle.X,_newRectangle.Y,_blockSize,_blockSize,_blockColor);
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
        public override bool Equals(object obj)
        {
            if(!(obj is Block))
                return false;
            Block temp = (Block)obj;
            return temp._newRectangle.IntersectsWith(this._newRectangle);
        }
    }
}
