using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE2300BrandonFooteLab1
{
    public partial class ImageDecoder : Form
    {
        public ImageDecoder()
        {
            InitializeComponent();
        }

        private void LoadImageTSB_Click(object sender, EventArgs e)
        {
            if (OpenFileDLG.ShowDialog() == DialogResult.OK)
            {
                PicBoxNew.Load(OpenFileDLG.FileName);
            }
        }

        private void DecodeImageTSB_Click(object sender, EventArgs e)
        {

        }


    }
}
