using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace CMPE2300BrandonFooteICA1
{
    public class TrekLight
    {
        private Color _LightColor;
        private byte _byThreshold;
        private byte _byTick;
        private int _Border;

        Random _newRandom = new Random();

        public TrekLight(Color LightColor, byte byThreshold,
            int Border=0)
        {
            _LightColor = LightColor;
            _byThreshold = byThreshold;
            _Border = Border;
        }
        public TrekLight()
        {
            _LightColor = Color.FromArgb(_newRandom.Next(0,255),
                _newRandom.Next(0,255), _newRandom.Next(0,255));
            _byThreshold = 64;
            _Border = 5;
            
        }

        public void Tick()
        {
            _byTick += 3;
        }
        public void Render(CDrawer Canvas, int LightNumber)
        {
            if(_byTick>_byThreshold)
            {
                _LightColor = Color.FromArgb(_newRandom.Next(0,255),
                    _newRandom.Next(0,255), _newRandom.Next(0,255));
                Canvas.AddRectangle(LightNumber % Canvas.ScaledWidth,
                    LightNumber / Canvas.ScaledWidth, 1, 1, _LightColor,
                    _Border, Color.Black);
                _byTick = 0;
            }

        }
    }
}
