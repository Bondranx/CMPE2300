using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace CMPE2300BrandonFooteICA6
{
    class Ball
    {
        public static Random newRandom = new Random();
        public Point newPoint;
        public int ballXVelocity;
        public int ballYVelocity;
        public int ballRadius;
        public Color ballColor { get; set; }
        public Ball(Point tempPoint, Color tempColor)
        {
            newPoint = tempPoint;
            ballColor = tempColor;
            ballXVelocity = newRandom.Next(-5, 6);
            ballYVelocity = newRandom.Next(-5, 6);
            ballRadius = newRandom.Next(20, 51);
        }
        public override int GetHashCode()
        {
            return 1;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Ball))
                return false;
            Ball temp = (Ball)obj;
            int X = temp.newPoint.X - this.newPoint.X;
            int Y = temp.newPoint.Y - this.newPoint.Y;
            return (Math.Sqrt((X * X) + (Y * Y)) < (temp.ballRadius + this.ballRadius));
        }

        public void Move(CDrawer Canvas)
        {
            newPoint.X += ballXVelocity;
            newPoint.Y += ballYVelocity;
            if (newPoint.X - ballRadius < 0)
            {
                newPoint.X = ballRadius;
                ballXVelocity *= -1;
            }
            if (newPoint.X + ballRadius > Canvas.ScaledWidth)
            {
                newPoint.X = Canvas.ScaledWidth-ballRadius;
                ballXVelocity *= -1;
            }
            if (newPoint.Y - ballRadius < 0)
            {
                newPoint.Y = ballRadius;
                ballYVelocity *= -1;
            }
            if (newPoint.Y + ballRadius > Canvas.ScaledHeight)
            {
                newPoint.Y = Canvas.ScaledHeight-ballRadius;
                ballYVelocity *= -1;
            }
            
        }
        public void Show(CDrawer Canvas, int num)
        {
            Canvas.AddCenteredEllipse(newPoint.X, newPoint.Y, ballRadius * 2, ballRadius * 2, ballColor);
            Canvas.AddText(num.ToString(), 14, newPoint.X - ballRadius, newPoint.Y - ballRadius, ballRadius * 2, ballRadius * 2, Color.FromArgb(ballColor.ToArgb() ^ 0x00FFFFFF));
            Canvas.Render();
        }
    }
}
