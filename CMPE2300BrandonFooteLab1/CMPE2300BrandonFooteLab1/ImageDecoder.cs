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
        Bitmap original = null;
        Bitmap decoded = null;
        public ImageDecoder()
        {
            InitializeComponent();
            ComboBoxTSB1.SelectedIndex = 0;
        }

        private void LoadImageTSB_Click(object sender, EventArgs e)
        {
            if (OpenFileDLG.ShowDialog() == DialogResult.OK)
            {
                original = new Bitmap(OpenFileDLG.FileName);
                PicBoxNew.Image = original;
            }
        }

            private void DecodeImageTSB_Click(object sender, EventArgs e)
            {
                int width = original.Width;
                int height = original.Height;
                decoded = new Bitmap(original);

                if (ComboBoxTSB1.SelectedIndex == 0)
                {
                    for (int count1 = 0; count1 < height; count1++)
                    { 
                        for (int count2 = 0; count2 < width; count2++)
                        {
                            if (original.GetPixel(count2, count1).R % 2 == 1)
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(255, original.GetPixel(count2, count1).G, original.GetPixel(count2, count1).B));
                            }
                            else
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(0, original.GetPixel(count2, count1).G, original.GetPixel(count2, count1).B));
                            }
                        }
                    }
                }
                if (ComboBoxTSB1.SelectedIndex == 1)
                {
                    for (int count1 = 0; count1 < height; count1++)
                    {
                        for (int count2 = 0; count2 < width; count2++)
                        {
                            if (original.GetPixel(count2, count1).G % 2 == 1)
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(original.GetPixel(count2,count1).R, 255, original.GetPixel(count2, count1).B));
                            }
                            else
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(original.GetPixel(count2,count1).R, 0, original.GetPixel(count2, count1).B));
                            }
                        }
                    }
                }
                if (ComboBoxTSB1.SelectedIndex == 2)
                {
                    for (int count1 = 0; count1 < height; count1++)
                    {
                        for (int count2 = 0; count2 < width; count2++)
                        {
                            if (original.GetPixel(count2, count1).G % 2 == 1)
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(original.GetPixel(count2, count1).R, original.GetPixel(count2,count1).G, 255));
                            }
                            else
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(original.GetPixel(count2, count1).R, original.GetPixel(count2, count1).G, 0));
                            }
                        }
                    }
                }
                if (ComboBoxTSB1.SelectedIndex == 3)
                {
                    for (int count1 = 0; count1 < height; count1++)
                    {
                        for (int count2 = 0; count2 < width; count2++)
                        {
                            if (original.GetPixel(count2, count1).B % 2 == 1)
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(original.GetPixel(count2, count1).R, original.GetPixel(count2, count1).G, 255));
                            }
                            else
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(decoded.GetPixel(count2, count1).R, decoded.GetPixel(count2, count1).G, 0));
                            }

                            if (original.GetPixel(count2, count1).G % 2 == 1)
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(decoded.GetPixel(count2, count1).R, 255, decoded.GetPixel(count2, count1).B));
                            }
                            else
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(decoded.GetPixel(count2, count1).R, 0, decoded.GetPixel(count2, count1).B));
                            }

                            if (original.GetPixel(count2, count1).R % 2 == 1)
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(255, decoded.GetPixel(count2, count1).G, decoded.GetPixel(count2, count1).B));
                            }
                            else
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(0, decoded.GetPixel(count2, count1).G, decoded.GetPixel(count2, count1).B));
                            }
                        }
                    }
                }
                PicBoxNew.Image = decoded;
                decoded = null;
        }

            private void tsbtnASCII_Click(object sender, EventArgs e)
            {
                int width = original.Width;
                int height = original.Height;
                int count3 = 0;
                byte newByte = 0;
                int result = 0;
                string newString ="";

                for (int count = 0; count < height; count++)
                {
                    for (int count2 = 0; count2 < width; count2++)
                    {
                        
                        result = original.GetPixel(count2, count).B % 2;

                        newByte += (byte)result;
                        count3++;
                        
                        
                        if(count3==8)
                        {
                            count3 = 0;
                            if(newByte!=0xFF)
                            {
                                newString += (char)newByte;
                                newByte = 0;
                            }
                            else if(newByte==0xFF)
                            {                                
                                MessageBox.Show(newString,"Decoded ASCII",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                            }
                            
                        }
                        newByte = (byte)(newByte<<1);
                    }
                }
                
            }
    }
}
