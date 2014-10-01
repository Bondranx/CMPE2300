using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CMPE2300BrandonFooteICA3
{
    public partial class Form1 : Form
    {
        public static List<Ball> ballList = new List<Ball>();
        public Form1()
        {
            InitializeComponent();
            Thread NewThread = new Thread(new ThreadStart(ThreadMethod));
            NewThread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Scroll = " + trkbrScroll.Value.ToString();
        }

        private void trkbrScroll_Scroll(object sender, EventArgs e)
        {
            this.Text = "Scroll = " + trkbrScroll.Value.ToString();
            Ball.Radius = trkbrScroll.Value;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                for (int Count = 0; Count < 5; Count++)
                {
                    ballList.Add(new Ball());
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                ballList.Clear();
            }
        }

        public static void ThreadMethod()
        {
            int count = 0;
            while (count < 1)
            {
                Ball._Loading = true;
                foreach (Ball var in ballList)
                {
                    var.MoveBall();
                    var.ShowBall();
                }
                Ball._Loading = false;
                Thread.Sleep(25);
            }
        }
    }
}
