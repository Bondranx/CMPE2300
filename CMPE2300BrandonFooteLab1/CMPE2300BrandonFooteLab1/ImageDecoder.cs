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
        Bitmap original = null;         //Original loaded bitmap
        Bitmap decoded = null;          //Bitmap to hold the decoded image
        
        public ImageDecoder()           
        {
            InitializeComponent();
            ComboBoxTSB1.SelectedIndex = 0;
        }

        private void LoadImageTSB_Click(object sender, EventArgs e)
        {
            //Opens an open file dialog to select an image file to decode and displays that image in the form
            if (OpenFileDLG.ShowDialog() == DialogResult.OK)
            {
                original = new Bitmap(OpenFileDLG.FileName);
                PicBoxNew.Image = original;
            }
        }
            
            private void DecodeImageTSB_Click(object sender, EventArgs e)
            {
                int width = original.Width;             //width of original bitmap image
                int height = original.Height;           //Height of original bitmap image
                decoded = new Bitmap(original);         //makes decoded image the same as the original

                //Runs if selected decode color is red
                if (ComboBoxTSB1.SelectedIndex == 0)
                {
                    //Loop to go from top to bottom of bitmap
                    for (int count1 = 0; count1 < height; count1++)
                    { 
                        //Loop to go from left to right of bitmap
                        for (int count2 = 0; count2 < width; count2++)
                        {
                            //determines if the red color of the pixel has a 1 in the 
                            //least signifigant bit and saturates the red if true
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
                //Runs if color selected is green
                if (ComboBoxTSB1.SelectedIndex == 1)
                {
                    //Loop to go from top to bottom of bitmap
                    for (int count1 = 0; count1 < height; count1++)
                    {
                        //Loop to go from left to right of bitmap
                        for (int count2 = 0; count2 < width; count2++)
                        {
                            //determines if the green color of the pixel has a 1 in the 
                            //least signifigant bit and saturates the green if true
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
                //Runs of decode color is blue
                if (ComboBoxTSB1.SelectedIndex == 2)
                {
                    //Loop to go from top to bottom of bitmap
                    for (int count1 = 0; count1 < height; count1++)
                    {
                        //Loop to go from left to right of bitmap
                        for (int count2 = 0; count2 < width; count2++)
                        {
                            //determines if the blue color of the pixel has a 1 in the 
                            //least signifigant bit and saturates the blue if true
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
                //Runs if decoded Color is all
                if (ComboBoxTSB1.SelectedIndex == 3)
                {
                    //Loop to go from top to bottom of bitmap
                    for (int count1 = 0; count1 < height; count1++)
                    {
                        //Loop to go from left to right of bitmap
                        for (int count2 = 0; count2 < width; count2++)
                        {
                            //determines if the blue color of the pixel has a 1 in the 
                            //least signifigant bit and saturates the blue if true
                            if (original.GetPixel(count2, count1).B % 2 == 1)
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(original.GetPixel(count2, count1).R, original.GetPixel(count2, count1).G, 255));
                            }

                            else
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(decoded.GetPixel(count2, count1).R, decoded.GetPixel(count2, count1).G, 0));
                            }
                            //determines if the green color of the pixel has a 1 in the 
                            //least signifigant bit and saturates the green if true
                            if (original.GetPixel(count2, count1).G % 2 == 1)
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(decoded.GetPixel(count2, count1).R, 255, decoded.GetPixel(count2, count1).B));
                            }
                            else
                            {
                                decoded.SetPixel(count2, count1, Color.FromArgb(decoded.GetPixel(count2, count1).R, 0, decoded.GetPixel(count2, count1).B));
                            }
                            //determines if the red color of the pixel has a 1 in the 
                            //least signifigant bit and saturates the red if true
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
                PicBoxNew.Image = decoded;      //displays the decoded image to the picture box
                decoded = null;                 //makes the decoded bitmap null
        }

            private void tsbtnASCII_Click(object sender, EventArgs e)
            {
                int width = original.Width;         //original bitmap width
                int height = original.Height;       //Original bitmap height
                int count3 = 0;                     //counting variable
                byte newByte = 0;                   //storage byte
                int result = 0;                     //result variable
                string newString ="";               //string to hold results

                //Loops through the bitmap from top to bottom
                for (int count = 0; count < height; count++)
                {
                    //Loops through the bitmap from left to right
                    for (int count2 = 0; count2 < width; count2++)
                    {
                        //determines if the least signifigant bit of the blue color is 1 or zero for each pixel
                        result = original.GetPixel(count2, count).B % 2;

                        //adds the result (1 or zero) to a storage byte
                        newByte += (byte)result;
                        //increases the count variable
                        count3++;
                        
                        //Checks if count has reached 8
                        if(count3==8)
                        {
                            count3 = 0; //sets count to zero
                            //determines if current byte is null and end of bitmap
                            //If not null
                            if(newByte!=0xFF)
                            {
                                newString += (char)newByte; //adds the current 8 bit byte to the character array as ascii
                                newByte = 0;                //resets byte to zero
                            }
                                //if null
                            else if(newByte==0xFF)
                            {             
                                //displays final string to a amessage box
                                MessageBox.Show(newString,"Decoded ASCII",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            }
                            
                        }
                        //shifts byte left 1
                        newByte = (byte)(newByte<<1);
                    }
                }
                
            }

            private void ImageDecoder_Load(object sender, EventArgs e)
            {

            }
    }
}
