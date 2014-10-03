using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE2300BrandonFooteICA4
{
    public partial class trkbrSize : Form
    {
        List<Block> blockList = new List<Block>();
        public trkbrSize()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblSize.Text = trackBar1.Value.ToString();
            lblSize.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count=0;
            int discardCount=0;
            bool Good;
            Block newBlock;
            do
            {
                do
                {
                    newBlock = new Block(trackBar1.Value);
                    Good = true;
                    foreach (Block value in blockList)
                    {
                        if (newBlock.Equals(value)&&discardCount<1000)
                        {
                            Good = false;
                            discardCount++;
                            prgbrDiscarded.Value = discardCount;
                            prgbrDiscarded.Refresh();
                        }
                    }
                }
                while(!Good);
                if (discardCount < 1000)
                {
                    blockList.Add(newBlock);
                    newBlock.AddBlock();
                    count++;
                    Block.blockSwitch = false;
                }
            }
            while (count < 25 && discardCount <1000);
        }
    }
}
