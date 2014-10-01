namespace CMPE2300BrandonFooteICA3
{
    partial class Form1
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
            this.trkbrScroll = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trkbrScroll)).BeginInit();
            this.SuspendLayout();
            // 
            // trkbrScroll
            // 
            this.trkbrScroll.Location = new System.Drawing.Point(12, 12);
            this.trkbrScroll.Maximum = 100;
            this.trkbrScroll.Minimum = -100;
            this.trkbrScroll.Name = "trkbrScroll";
            this.trkbrScroll.Size = new System.Drawing.Size(260, 45);
            this.trkbrScroll.TabIndex = 0;
            this.trkbrScroll.Scroll += new System.EventHandler(this.trkbrScroll_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 59);
            this.Controls.Add(this.trkbrScroll);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trkbrScroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkbrScroll;
    }
}

