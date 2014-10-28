namespace CMEP2300BrandonFooteICA5
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdbtnSize = new System.Windows.Forms.RadioButton();
            this.rdbtnDistance = new System.Windows.Forms.RadioButton();
            this.rdbtnColor = new System.Windows.Forms.RadioButton();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(271, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(184, 61);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(22, 13);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "PH";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(57, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Exlcusive";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(167, 105);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rdbtnSize
            // 
            this.rdbtnSize.AutoSize = true;
            this.rdbtnSize.Location = new System.Drawing.Point(16, 151);
            this.rdbtnSize.Name = "rdbtnSize";
            this.rdbtnSize.Size = new System.Drawing.Size(45, 17);
            this.rdbtnSize.TabIndex = 5;
            this.rdbtnSize.TabStop = true;
            this.rdbtnSize.Text = "Size";
            this.rdbtnSize.UseVisualStyleBackColor = true;
            this.rdbtnSize.Click += new System.EventHandler(this.rdbtnSize_Click);
            // 
            // rdbtnDistance
            // 
            this.rdbtnDistance.AutoSize = true;
            this.rdbtnDistance.Location = new System.Drawing.Point(107, 151);
            this.rdbtnDistance.Name = "rdbtnDistance";
            this.rdbtnDistance.Size = new System.Drawing.Size(67, 17);
            this.rdbtnDistance.TabIndex = 6;
            this.rdbtnDistance.TabStop = true;
            this.rdbtnDistance.Text = "Distance";
            this.rdbtnDistance.UseVisualStyleBackColor = true;
            this.rdbtnDistance.Click += new System.EventHandler(this.rdbtnDistance_Click);
            // 
            // rdbtnColor
            // 
            this.rdbtnColor.AutoSize = true;
            this.rdbtnColor.Location = new System.Drawing.Point(198, 151);
            this.rdbtnColor.Name = "rdbtnColor";
            this.rdbtnColor.Size = new System.Drawing.Size(49, 17);
            this.rdbtnColor.TabIndex = 7;
            this.rdbtnColor.TabStop = true;
            this.rdbtnColor.Text = "Color";
            this.rdbtnColor.UseVisualStyleBackColor = true;
            this.rdbtnColor.Click += new System.EventHandler(this.rdbtnColor_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(0, 207);
            this.ProgressBar1.Maximum = 1000;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(309, 23);
            this.ProgressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 230);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.rdbtnColor);
            this.Controls.Add(this.rdbtnDistance);
            this.Controls.Add(this.rdbtnSize);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdbtnSize;
        private System.Windows.Forms.RadioButton rdbtnDistance;
        private System.Windows.Forms.RadioButton rdbtnColor;
        private System.Windows.Forms.ProgressBar ProgressBar1;
    }
}

