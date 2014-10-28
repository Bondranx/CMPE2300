using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GDIDrawer;

namespace CMPE2300BrandonFooteICA1
{
    public partial class frmTrekLight : Form
    {
        List<TrekLight> TrekLightList = new List<TrekLight>();
        CDrawer newCanvas = new CDrawer();
        public frmTrekLight()
        {
            InitializeComponent();
        }

        private void frmTrekLight_Load(object sender, EventArgs e)
        {
            newCanvas.Scale = 50;
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            //newCanvas.Clear();
            foreach(TrekLight newLight in TrekLightList)
            { 
                newLight.Tick();
                newLight.Render(newCanvas, TrekLightList.IndexOf(newLight));
            }
        }

        private void frmTrekLight_KeyDown(object sender, KeyEventArgs e)
        {
            Random newRandom = new Random();

            if(e.KeyCode == Keys.D)
            {
                TrekLightList.Add(new TrekLight());
            }
            else if(e.KeyCode == Keys.F)
            {
                TrekLightList.Add(new TrekLight(Color.Red,127,0));
            }
            else if(e.KeyCode == Keys.G)
            {
                TrekLightList.Add(new TrekLight(Color.FromArgb(newRandom.Next(0,255),
                    newRandom.Next(0,255),newRandom.Next(0,255)),
                    (byte)newRandom.Next(40,200),4));
            }
            else if (e.KeyCode == Keys.C && TrekLightList.Count > 0)
            {
                TrekLightList.RemoveAt(TrekLightList.Count-1);
                newCanvas.AddRectangle(TrekLightList.Count % 
                    newCanvas.ScaledWidth, TrekLightList.Count 
                    / newCanvas.ScaledWidth, 1, 1, Color.Black, 
                    5, Color.Black);
            }
        }
    }
}
