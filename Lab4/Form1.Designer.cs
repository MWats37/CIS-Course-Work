namespace Lab4
{
    partial class Lab4Form
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
            this.gradePointAverageLabel = new System.Windows.Forms.Label();
            this.gradePointAverageTextBox = new System.Windows.Forms.TextBox();
            this.admissionsTestScoreLabel = new System.Windows.Forms.Label();
            this.admissionsTestScoreTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.applicationsAcceptedLabel = new System.Windows.Forms.Label();
            this.acceptedApplicationsOutLabel = new System.Windows.Forms.Label();
            this.applicationsRejectedLabel = new System.Windows.Forms.Label();
            this.rejectedApplicationOutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gradePointAverageLabel
            // 
            this.gradePointAverageLabel.AutoSize = true;
            this.gradePointAverageLabel.Location = new System.Drawing.Point(61, 43);
            this.gradePointAverageLabel.Name = "gradePointAverageLabel";
            this.gradePointAverageLabel.Size = new System.Drawing.Size(140, 13);
            this.gradePointAverageLabel.TabIndex = 0;
            this.gradePointAverageLabel.Text = "Enter your high school GPA:";
            // 
            // gradePointAverageTextBox
            // 
            this.gradePointAverageTextBox.Location = new System.Drawing.Point(211, 43);
            this.gradePointAverageTextBox.Name = "gradePointAverageTextBox";
            this.gradePointAverageTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradePointAverageTextBox.TabIndex = 1;
            // 
            // admissionsTestScoreLabel
            // 
            this.admissionsTestScoreLabel.AutoSize = true;
            this.admissionsTestScoreLabel.Location = new System.Drawing.Point(44, 85);
            this.admissionsTestScoreLabel.Name = "admissionsTestScoreLabel";
            this.admissionsTestScoreLabel.Size = new System.Drawing.Size(161, 13);
            this.admissionsTestScoreLabel.TabIndex = 2;
            this.admissionsTestScoreLabel.Text = "Enter your admissions test score:";
            // 
            // admissionsTestScoreTextBox
            // 
            this.admissionsTestScoreTextBox.Location = new System.Drawing.Point(211, 78);
            this.admissionsTestScoreTextBox.Name = "admissionsTestScoreTextBox";
            this.admissionsTestScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.admissionsTestScoreTextBox.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(222, 127);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // applicationsAcceptedLabel
            // 
            this.applicationsAcceptedLabel.AutoSize = true;
            this.applicationsAcceptedLabel.Location = new System.Drawing.Point(31, 243);
            this.applicationsAcceptedLabel.Name = "applicationsAcceptedLabel";
            this.applicationsAcceptedLabel.Size = new System.Drawing.Size(83, 13);
            this.applicationsAcceptedLabel.TabIndex = 5;
            this.applicationsAcceptedLabel.Text = "Total Accepted:";
            // 
            // acceptedApplicationsOutLabel
            // 
            this.acceptedApplicationsOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptedApplicationsOutLabel.Location = new System.Drawing.Point(120, 233);
            this.acceptedApplicationsOutLabel.Name = "acceptedApplicationsOutLabel";
            this.acceptedApplicationsOutLabel.Size = new System.Drawing.Size(100, 23);
            this.acceptedApplicationsOutLabel.TabIndex = 6;
            // 
            // applicationsRejectedLabel
            // 
            this.applicationsRejectedLabel.AutoSize = true;
            this.applicationsRejectedLabel.Location = new System.Drawing.Point(292, 243);
            this.applicationsRejectedLabel.Name = "applicationsRejectedLabel";
            this.applicationsRejectedLabel.Size = new System.Drawing.Size(80, 13);
            this.applicationsRejectedLabel.TabIndex = 7;
            this.applicationsRejectedLabel.Text = "Total Rejected:";
            // 
            // rejectedApplicationOutLabel
            // 
            this.rejectedApplicationOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectedApplicationOutLabel.Location = new System.Drawing.Point(375, 233);
            this.rejectedApplicationOutLabel.Name = "rejectedApplicationOutLabel";
            this.rejectedApplicationOutLabel.Size = new System.Drawing.Size(100, 23);
            this.rejectedApplicationOutLabel.TabIndex = 8;
            // 
            // Lab4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.rejectedApplicationOutLabel);
            this.Controls.Add(this.applicationsRejectedLabel);
            this.Controls.Add(this.acceptedApplicationsOutLabel);
            this.Controls.Add(this.applicationsAcceptedLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.admissionsTestScoreTextBox);
            this.Controls.Add(this.admissionsTestScoreLabel);
            this.Controls.Add(this.gradePointAverageTextBox);
            this.Controls.Add(this.gradePointAverageLabel);
            this.Name = "Lab4Form";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gradePointAverageLabel;
        private System.Windows.Forms.TextBox gradePointAverageTextBox;
        private System.Windows.Forms.Label admissionsTestScoreLabel;
        private System.Windows.Forms.TextBox admissionsTestScoreTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label applicationsAcceptedLabel;
        private System.Windows.Forms.Label acceptedApplicationsOutLabel;
        private System.Windows.Forms.Label applicationsRejectedLabel;
        private System.Windows.Forms.Label rejectedApplicationOutLabel;
    }
}

