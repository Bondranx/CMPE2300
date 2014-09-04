namespace CMPE2300BrandonFooteLab1
{
    partial class ImageDecoder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageDecoder));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LoadImageTSB = new System.Windows.Forms.ToolStripButton();
            this.ComboBoxTSB1 = new System.Windows.Forms.ToolStripComboBox();
            this.DecodeImageTSB = new System.Windows.Forms.ToolStripButton();
            this.OpenFileDLG = new System.Windows.Forms.OpenFileDialog();
            this.PicBoxNew = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxNew)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadImageTSB,
            this.ComboBoxTSB1,
            this.DecodeImageTSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(478, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LoadImageTSB
            // 
            this.LoadImageTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoadImageTSB.Image = ((System.Drawing.Image)(resources.GetObject("LoadImageTSB.Image")));
            this.LoadImageTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadImageTSB.Name = "LoadImageTSB";
            this.LoadImageTSB.Size = new System.Drawing.Size(73, 22);
            this.LoadImageTSB.Text = "Load Image";
            this.LoadImageTSB.Click += new System.EventHandler(this.LoadImageTSB_Click);
            // 
            // ComboBoxTSB1
            // 
            this.ComboBoxTSB1.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "All"});
            this.ComboBoxTSB1.Name = "ComboBoxTSB1";
            this.ComboBoxTSB1.Size = new System.Drawing.Size(121, 25);
            // 
            // DecodeImageTSB
            // 
            this.DecodeImageTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DecodeImageTSB.Image = ((System.Drawing.Image)(resources.GetObject("DecodeImageTSB.Image")));
            this.DecodeImageTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DecodeImageTSB.Name = "DecodeImageTSB";
            this.DecodeImageTSB.Size = new System.Drawing.Size(87, 22);
            this.DecodeImageTSB.Text = "Decode Image";
            this.DecodeImageTSB.Click += new System.EventHandler(this.DecodeImageTSB_Click);
            // 
            // OpenFileDLG
            // 
            this.OpenFileDLG.Filter = "Bmp files|*.bmp|All Files|*.*";
            // 
            // PicBoxNew
            // 
            this.PicBoxNew.Location = new System.Drawing.Point(12, 28);
            this.PicBoxNew.Name = "PicBoxNew";
            this.PicBoxNew.Size = new System.Drawing.Size(454, 366);
            this.PicBoxNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxNew.TabIndex = 1;
            this.PicBoxNew.TabStop = false;
            // 
            // ImageDecoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 406);
            this.Controls.Add(this.PicBoxNew);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ImageDecoder";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton LoadImageTSB;
        private System.Windows.Forms.OpenFileDialog OpenFileDLG;
        private System.Windows.Forms.ToolStripComboBox ComboBoxTSB1;
        private System.Windows.Forms.PictureBox PicBoxNew;
        private System.Windows.Forms.ToolStripButton DecodeImageTSB;
    }
}

