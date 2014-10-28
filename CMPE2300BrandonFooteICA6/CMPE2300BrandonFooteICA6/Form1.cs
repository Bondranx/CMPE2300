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

namespace CMPE2300BrandonFooteICA6
{
    public partial class Form1 : Form
    {
        List<Ball> blue;
        List<Ball> green;
        List<Ball> red;
        CDrawer Canvas1 = new CDrawer(600, 300);
        CDrawer Canvas2 = new CDrawer(600, 300);

        public Form1()
        {
            InitializeComponent();
            Canvas1.ContinuousUpdate = false;
            Canvas2.ContinuousUpdate = false;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            blue = new List<Ball>();
            green = new List<Ball>();
            red = new List<Ball>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            List<Ball> tempCollided = new List<Ball>();
            
            Point temp=new Point();
            if (Canvas1.GetLastMouseLeftClick(out temp))
            {
                Ball newGreenBall = new Ball(temp, Color.Green);
                if (!green.Contains(newGreenBall))
                {
                    green.Add(newGreenBall);
                }
            }
            if (Canvas1.GetLastMouseRightClick(out temp))
            {
                Ball newBlueBall = new Ball(temp, Color.Blue);
                if(blue.IndexOf(newBlueBall) == -1)
                {
                    blue.Insert(0, newBlueBall);
                }
            }
            foreach (Ball i in green)
            {
                i.Move(Canvas1);
            }
            foreach (Ball i in blue)
            {
                i.Move(Canvas1);
            }
            foreach (Ball i in red)
            {
                i.Move(Canvas2);
            }
            
            tempCollided = green.Intersect(blue).ToList();
            //if (tempCollided.Count > 0)
            //{
              //  Console.WriteLine("Collision");
            //}

            foreach (Ball i in tempCollided)
            {
                if (blue.Contains(i))
                {
                    blue.Remove(i);
                    i.ballColor = Color.Red;
                }
                if (green.Contains(i))
                {
                    i.ballColor = Color.Red;
                    green.Remove(i);
                }
            }

            red = new List<Ball>(red.Concat(tempCollided));

            Canvas1.Clear();
            Canvas2.Clear();

            Canvas1.AddText("Blue : " + blue.Count.ToString() + " Green : " + green.Count.ToString(), 20, Color.Gray);
            Canvas2.AddText(red.Count.ToString(), 20, Color.Gray);

            for (int count = 0; count < blue.Count; count++)
            {
                blue[count].Show(Canvas1, count);
            }
            for (int count = 0; count < green.Count; count++)
            {
                green[count].Show(Canvas1, count);
            }
            for (int count = 0; count < red.Count; count++)
            {
                red[count].Show(Canvas2, count);
            }
        }
    }
}
