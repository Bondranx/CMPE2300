namespace CMPE2300BrandonFooteICA7
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
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnWidth = new System.Windows.Forms.Button();
            this.btnWidthColor = new System.Windows.Forms.Button();
            this.btnBright = new System.Windows.Forms.Button();
            this.btnLonger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(12, 13);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(135, 23);
            this.btnPopulate.TabIndex = 0;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(12, 36);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(135, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnWidth
            // 
            this.btnWidth.Location = new System.Drawing.Point(12, 59);
            this.btnWidth.Name = "btnWidth";
            this.btnWidth.Size = new System.Drawing.Size(135, 23);
            this.btnWidth.TabIndex = 2;
            this.btnWidth.Text = "Width";
            this.btnWidth.UseVisualStyleBackColor = true;
            this.btnWidth.Click += new System.EventHandler(this.btnWidth_Click);
            // 
            // btnWidthColor
            // 
            this.btnWidthColor.Location = new System.Drawing.Point(12, 82);
            this.btnWidthColor.Name = "btnWidthColor";
            this.btnWidthColor.Size = new System.Drawing.Size(135, 23);
            this.btnWidthColor.TabIndex = 3;
            this.btnWidthColor.Text = "Width, Color";
            this.btnWidthColor.UseVisualStyleBackColor = true;
            this.btnWidthColor.Click += new System.EventHandler(this.btnWidthColor_Click);
            // 
            // btnBright
            // 
            this.btnBright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBright.Location = new System.Drawing.Point(12, 105);
            this.btnBright.Name = "btnBright";
            this.btnBright.Size = new System.Drawing.Size(135, 23);
            this.btnBright.TabIndex = 4;
            this.btnBright.Text = "Bright";
            this.btnBright.UseVisualStyleBackColor = true;
            this.btnBright.Click += new System.EventHandler(this.btnBright_Click);
            // 
            // btnLonger
            // 
            this.btnLonger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLonger.Location = new System.Drawing.Point(12, 128);
            this.btnLonger.Name = "btnLonger";
            this.btnLonger.Size = new System.Drawing.Size(135, 23);
            this.btnLonger.TabIndex = 5;
            this.btnLonger.Text = "Longer";
            this.btnLonger.UseVisualStyleBackColor = true;
            this.btnLonger.Click += new System.EventHandler(this.btnLonger_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 170);
            this.Controls.Add(this.btnLonger);
            this.Controls.Add(this.btnBright);
            this.Controls.Add(this.btnWidthColor);
            this.Controls.Add(this.btnWidth);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnPopulate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnWidth;
        private System.Windows.Forms.Button btnWidthColor;
        private System.Windows.Forms.Button btnBright;
        private System.Windows.Forms.Button btnLonger;
    }
}

