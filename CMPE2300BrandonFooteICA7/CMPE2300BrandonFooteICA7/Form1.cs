using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE2300BrandonFooteICA7
{
    public partial class Form1 : Form
    {
        List<Block> blockList;
        void ShowBlock()
        {
            
            int tempX=0;
            int tempY=0;
            Point tempPoint;
            Block._Canvas.Clear();
            foreach (Block i in blockList)
            {
                tempPoint = new Point(tempX, tempY);
                i.ShowBlock(tempPoint);
                
                if (tempX < Block._Canvas.ScaledWidth)
                {
                    tempX = tempX + i._width;
                }
                else if (tempX > Block._Canvas.ScaledWidth)
                {
                    tempX = 0;
                    tempY = tempY + Block._height;
                }
                if (Block._Canvas.ScaledWidth < i._width + tempX)
                {
                    tempX = 0;
                    tempY = tempY + Block._height;
                }
            }
            Block._Canvas.Render();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            int runningTotal = 0;
            blockList = new List<Block>();
            while (runningTotal < (((Block._Canvas.ScaledWidth * Block._Canvas.ScaledHeight) / Block._height) * .8))
            {
                Block newBlock = new Block();
                if (!blockList.Contains(newBlock))
                {
                    blockList.Add(newBlock);
                    runningTotal += newBlock._width;
                }
            }
            ShowBlock();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            blockList.Sort();
            ShowBlock();
        }

        private void btnWidth_Click(object sender, EventArgs e)
        {
            blockList.Sort(Block.SortWidth);
            ShowBlock();
        }

        private void btnWidthColor_Click(object sender, EventArgs e)
        {
            blockList.Sort(Block.SortWidthColor);
            ShowBlock();
        }

        private void btnBright_Click(object sender, EventArgs e)
        {
            blockList.RemoveAll(Block.isBright);
            ShowBlock();
        }

        private void btnLonger_Click(object sender, EventArgs e)
        {
            blockList.RemoveAll(Block.isLong);
            ShowBlock();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (blockList != null)
            {
                Point XP = new Point();
                foreach (Block i in blockList)
                {
                    i._highlight = false;
                }
                if (Block._Canvas.GetLastMousePosition(out XP))
                {
                    int X = XP.X;
                    Block._highlightWidth = X;
                    foreach (Block i in blockList.FindAll(Block.isHighlighted))
                    {
                        i._highlight = true;
                    }
                    ShowBlock();
                }
            }
            
        }
    }
}
