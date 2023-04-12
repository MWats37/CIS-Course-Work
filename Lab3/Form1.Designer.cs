namespace Lab3
{
    partial class Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab3));
            this.radiusLabel = new System.Windows.Forms.Label();
            this.radiusOsSphereTextBox = new System.Windows.Forms.TextBox();
            this.calulcateButton = new System.Windows.Forms.Button();
            this.diameterLabel = new System.Windows.Forms.Label();
            this.surfaceAreaLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.diameterOutLabel = new System.Windows.Forms.Label();
            this.surfaceAreaOutLabel = new System.Windows.Forms.Label();
            this.volumeOutLabel = new System.Windows.Forms.Label();
            this.spherePictureTop = new System.Windows.Forms.PictureBox();
            this.spherePictureBottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spherePictureTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spherePictureBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(169, 80);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(90, 13);
            this.radiusLabel.TabIndex = 0;
            this.radiusLabel.Text = "Radius of sphere:";
            // 
            // radiusOsSphereTextBox
            // 
            this.radiusOsSphereTextBox.Location = new System.Drawing.Point(265, 77);
            this.radiusOsSphereTextBox.Name = "radiusOsSphereTextBox";
            this.radiusOsSphereTextBox.Size = new System.Drawing.Size(100, 20);
            this.radiusOsSphereTextBox.TabIndex = 1;
            // 
            // calulcateButton
            // 
            this.calulcateButton.Location = new System.Drawing.Point(277, 113);
            this.calulcateButton.Name = "calulcateButton";
            this.calulcateButton.Size = new System.Drawing.Size(75, 23);
            this.calulcateButton.TabIndex = 2;
            this.calulcateButton.Text = "Calculate";
            this.calulcateButton.UseVisualStyleBackColor = true;
            this.calulcateButton.Click += new System.EventHandler(this.calulcateButton_Click);
            // 
            // diameterLabel
            // 
            this.diameterLabel.AutoSize = true;
            this.diameterLabel.Location = new System.Drawing.Point(38, 199);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(49, 13);
            this.diameterLabel.TabIndex = 3;
            this.diameterLabel.Text = "Diameter";
            // 
            // surfaceAreaLabel
            // 
            this.surfaceAreaLabel.AutoSize = true;
            this.surfaceAreaLabel.Location = new System.Drawing.Point(18, 247);
            this.surfaceAreaLabel.Name = "surfaceAreaLabel";
            this.surfaceAreaLabel.Size = new System.Drawing.Size(69, 13);
            this.surfaceAreaLabel.TabIndex = 4;
            this.surfaceAreaLabel.Text = "Surface Area";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(45, 304);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(42, 13);
            this.volumeLabel.TabIndex = 5;
            this.volumeLabel.Text = "Volume";
            // 
            // diameterOutLabel
            // 
            this.diameterOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameterOutLabel.Location = new System.Drawing.Point(93, 198);
            this.diameterOutLabel.Name = "diameterOutLabel";
            this.diameterOutLabel.Size = new System.Drawing.Size(100, 23);
            this.diameterOutLabel.TabIndex = 6;
            // 
            // surfaceAreaOutLabel
            // 
            this.surfaceAreaOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surfaceAreaOutLabel.Location = new System.Drawing.Point(93, 247);
            this.surfaceAreaOutLabel.Name = "surfaceAreaOutLabel";
            this.surfaceAreaOutLabel.Size = new System.Drawing.Size(100, 23);
            this.surfaceAreaOutLabel.TabIndex = 7;
            // 
            // volumeOutLabel
            // 
            this.volumeOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeOutLabel.Location = new System.Drawing.Point(93, 294);
            this.volumeOutLabel.Name = "volumeOutLabel";
            this.volumeOutLabel.Size = new System.Drawing.Size(100, 23);
            this.volumeOutLabel.TabIndex = 8;
            // 
            // spherePictureTop
            // 
            this.spherePictureTop.Image = ((System.Drawing.Image)(resources.GetObject("spherePictureTop.Image")));
            this.spherePictureTop.Location = new System.Drawing.Point(0, 0);
            this.spherePictureTop.Name = "spherePictureTop";
            this.spherePictureTop.Size = new System.Drawing.Size(150, 150);
            this.spherePictureTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spherePictureTop.TabIndex = 9;
            this.spherePictureTop.TabStop = false;
            // 
            // spherePictureBottom
            // 
            this.spherePictureBottom.Image = ((System.Drawing.Image)(resources.GetObject("spherePictureBottom.Image")));
            this.spherePictureBottom.Location = new System.Drawing.Point(234, 211);
            this.spherePictureBottom.Name = "spherePictureBottom";
            this.spherePictureBottom.Size = new System.Drawing.Size(150, 150);
            this.spherePictureBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spherePictureBottom.TabIndex = 10;
            this.spherePictureBottom.TabStop = false;
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.spherePictureBottom);
            this.Controls.Add(this.spherePictureTop);
            this.Controls.Add(this.volumeOutLabel);
            this.Controls.Add(this.surfaceAreaOutLabel);
            this.Controls.Add(this.diameterOutLabel);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.surfaceAreaLabel);
            this.Controls.Add(this.diameterLabel);
            this.Controls.Add(this.calulcateButton);
            this.Controls.Add(this.radiusOsSphereTextBox);
            this.Controls.Add(this.radiusLabel);
            this.Name = "Lab3";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.spherePictureTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spherePictureBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.TextBox radiusOsSphereTextBox;
        private System.Windows.Forms.Button calulcateButton;
        private System.Windows.Forms.Label diameterLabel;
        private System.Windows.Forms.Label surfaceAreaLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label diameterOutLabel;
        private System.Windows.Forms.Label surfaceAreaOutLabel;
        private System.Windows.Forms.Label volumeOutLabel;
        private System.Windows.Forms.PictureBox spherePictureTop;
        private System.Windows.Forms.PictureBox spherePictureBottom;
    }
}

