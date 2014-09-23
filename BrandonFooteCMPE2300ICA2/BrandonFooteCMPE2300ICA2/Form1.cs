using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace BrandonFooteCMPE2300ICA2
{
    public partial class Form1 : Form
    {
        CDrawer Canvas;
        List<Ball> BallList = new List<Ball>();
        bool all = false;
        public Form1()
        {
            InitializeComponent();
            Canvas = new CDrawer();
            Canvas.ContinuousUpdate = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOpacityDisplay.Text = trkbrOpacity.Value.ToString();
            lblXDisplay.Text = trkbrX.Value.ToString();
            lblYDisplay.Text = trkbrY.Value.ToString();
            lblOpacityDisplay.Visible = true;
            lblXDisplay.Visible = true;
            lblYDisplay.Visible = true;
        }

        private void trkbrOpacity_Scroll(object sender, EventArgs e)
        {
            lblOpacityDisplay.Text = trkbrOpacity.Value.ToString();
            if (BallList.Count != 0)
            {
                if (all == true)
                {
                    foreach (Ball value in BallList)
                    {
                        value._BallOpacity = trkbrOpacity.Value;
                    }
                }
                else
                {
                    Ball temp = BallList.Last<Ball>();
                    temp._BallOpacity = trkbrOpacity.Value;
                }
            }
        }

        private void trkbrX_Scroll(object sender, EventArgs e)
        {
            lblXDisplay.Text = trkbrX.Value.ToString();
            if (BallList.Count != 0)
            {
                if (all == true)
                {
                    foreach (Ball value in BallList)
                    {
                        value._xVelocity = trkbrX.Value;
                    }
                }
                else
                {
                    Ball temp = BallList.Last<Ball>();
                    temp._xVelocity = trkbrX.Value;
                }
            }
        }

        private void trkbrY_Scroll(object sender, EventArgs e)
        {
            lblYDisplay.Text = trkbrY.Value.ToString();
            if (BallList.Count != 0)
            {
                if (all == true)
                {
                    foreach (Ball value in BallList)
                    {
                        value._yVelocity = trkbrY.Value;
                    }
                }
                else
                {
                    Ball temp = BallList.Last<Ball>();
                    temp._yVelocity = trkbrY.Value;
                }
            }
        }

        private void BallTimer_Tick(object sender, EventArgs e)
        {
            Point newPoint = new Point();
            if (Canvas.GetLastMouseLeftClick(out newPoint))
            {
                BallList.Add(new Ball(newPoint));
            }
            if (Canvas.GetLastMouseRightClick(out newPoint))
            {
                BallList.Clear();
                Canvas.Clear();
                Canvas.Render();
            }
            Canvas.Clear();
            foreach (Ball value in BallList)
            {
                value.MoveBall(Canvas);
                value.ShowBall(Canvas);
                Canvas.Render();
            }
        }

        private void chkbxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxAll.Checked == true)
            {
                all = true;
            }
            else
            {
                all = false;
            }
        }
    }
}
