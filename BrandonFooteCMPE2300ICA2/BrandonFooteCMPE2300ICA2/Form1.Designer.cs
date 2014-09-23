namespace BrandonFooteCMPE2300ICA2
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
            this.components = new System.ComponentModel.Container();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.trkbrOpacity = new System.Windows.Forms.TrackBar();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.trkbrX = new System.Windows.Forms.TrackBar();
            this.trkbrY = new System.Windows.Forms.TrackBar();
            this.lblOpacityDisplay = new System.Windows.Forms.Label();
            this.lblXDisplay = new System.Windows.Forms.Label();
            this.lblYDisplay = new System.Windows.Forms.Label();
            this.BallTimer = new System.Windows.Forms.Timer(this.components);
            this.chkbxAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trkbrOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbrX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbrY)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(11, 13);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(52, 13);
            this.lblOpacity.TabIndex = 0;
            this.lblOpacity.Text = "Opacity : ";
            // 
            // trkbrOpacity
            // 
            this.trkbrOpacity.Location = new System.Drawing.Point(100, 9);
            this.trkbrOpacity.Maximum = 255;
            this.trkbrOpacity.Name = "trkbrOpacity";
            this.trkbrOpacity.Size = new System.Drawing.Size(312, 45);
            this.trkbrOpacity.TabIndex = 1;
            this.trkbrOpacity.TickFrequency = 10;
            this.trkbrOpacity.Scroll += new System.EventHandler(this.trkbrOpacity_Scroll);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(12, 99);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(23, 13);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y : ";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(12, 54);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(23, 13);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X : ";
            // 
            // trkbrX
            // 
            this.trkbrX.Location = new System.Drawing.Point(100, 54);
            this.trkbrX.Maximum = 15;
            this.trkbrX.Minimum = -15;
            this.trkbrX.Name = "trkbrX";
            this.trkbrX.Size = new System.Drawing.Size(312, 45);
            this.trkbrX.TabIndex = 4;
            this.trkbrX.Scroll += new System.EventHandler(this.trkbrX_Scroll);
            // 
            // trkbrY
            // 
            this.trkbrY.Location = new System.Drawing.Point(100, 99);
            this.trkbrY.Maximum = 15;
            this.trkbrY.Minimum = -15;
            this.trkbrY.Name = "trkbrY";
            this.trkbrY.Size = new System.Drawing.Size(312, 45);
            this.trkbrY.TabIndex = 5;
            this.trkbrY.Scroll += new System.EventHandler(this.trkbrY_Scroll);
            // 
            // lblOpacityDisplay
            // 
            this.lblOpacityDisplay.AutoSize = true;
            this.lblOpacityDisplay.Location = new System.Drawing.Point(69, 13);
            this.lblOpacityDisplay.Name = "lblOpacityDisplay";
            this.lblOpacityDisplay.Size = new System.Drawing.Size(22, 13);
            this.lblOpacityDisplay.TabIndex = 6;
            this.lblOpacityDisplay.Text = "PH";
            this.lblOpacityDisplay.Visible = false;
            // 
            // lblXDisplay
            // 
            this.lblXDisplay.AutoSize = true;
            this.lblXDisplay.Location = new System.Drawing.Point(41, 54);
            this.lblXDisplay.Name = "lblXDisplay";
            this.lblXDisplay.Size = new System.Drawing.Size(22, 13);
            this.lblXDisplay.TabIndex = 7;
            this.lblXDisplay.Text = "PH";
            this.lblXDisplay.Visible = false;
            // 
            // lblYDisplay
            // 
            this.lblYDisplay.AutoSize = true;
            this.lblYDisplay.Location = new System.Drawing.Point(41, 99);
            this.lblYDisplay.Name = "lblYDisplay";
            this.lblYDisplay.Size = new System.Drawing.Size(22, 13);
            this.lblYDisplay.TabIndex = 8;
            this.lblYDisplay.Text = "PH";
            this.lblYDisplay.Visible = false;
            // 
            // BallTimer
            // 
            this.BallTimer.Enabled = true;
            this.BallTimer.Interval = 20;
            this.BallTimer.Tick += new System.EventHandler(this.BallTimer_Tick);
            // 
            // chkbxAll
            // 
            this.chkbxAll.AutoSize = true;
            this.chkbxAll.Location = new System.Drawing.Point(194, 137);
            this.chkbxAll.Name = "chkbxAll";
            this.chkbxAll.Size = new System.Drawing.Size(37, 17);
            this.chkbxAll.TabIndex = 9;
            this.chkbxAll.Text = "All";
            this.chkbxAll.UseVisualStyleBackColor = true;
            this.chkbxAll.CheckedChanged += new System.EventHandler(this.chkbxAll_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 166);
            this.Controls.Add(this.chkbxAll);
            this.Controls.Add(this.lblYDisplay);
            this.Controls.Add(this.lblXDisplay);
            this.Controls.Add(this.lblOpacityDisplay);
            this.Controls.Add(this.trkbrY);
            this.Controls.Add(this.trkbrX);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.trkbrOpacity);
            this.Controls.Add(this.lblOpacity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkbrOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbrX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbrY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.TrackBar trkbrOpacity;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TrackBar trkbrX;
        private System.Windows.Forms.TrackBar trkbrY;
        private System.Windows.Forms.Label lblOpacityDisplay;
        private System.Windows.Forms.Label lblXDisplay;
        private System.Windows.Forms.Label lblYDisplay;
        private System.Windows.Forms.Timer BallTimer;
        private System.Windows.Forms.CheckBox chkbxAll;
    }
}

