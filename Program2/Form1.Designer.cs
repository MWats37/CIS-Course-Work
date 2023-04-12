namespace Program2
{
    partial class Program2
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
            this.passengersLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.passengerTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.carTypeComboBox = new System.Windows.Forms.ComboBox();
            this.calculateCostButton = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.companyALabel = new System.Windows.Forms.Label();
            this.companyBLabel = new System.Windows.Forms.Label();
            this.companyCLabel = new System.Windows.Forms.Label();
            this.companyACostOutLabel = new System.Windows.Forms.Label();
            this.companyBCostOutLabel = new System.Windows.Forms.Label();
            this.companyCCostOutLabel = new System.Windows.Forms.Label();
            this.lowestCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passengersLabel
            // 
            this.passengersLabel.AutoSize = true;
            this.passengersLabel.Location = new System.Drawing.Point(60, 57);
            this.passengersLabel.Name = "passengersLabel";
            this.passengersLabel.Size = new System.Drawing.Size(92, 13);
            this.passengersLabel.TabIndex = 0;
            this.passengersLabel.Text = "Passengers (1-12)";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(63, 117);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(82, 13);
            this.distanceLabel.TabIndex = 1;
            this.distanceLabel.Text = "Distance (Miles)";
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Location = new System.Drawing.Point(67, 175);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(53, 13);
            this.carTypeLabel.TabIndex = 2;
            this.carTypeLabel.Text = "Car Type:";
            // 
            // passengerTextBox
            // 
            this.passengerTextBox.Location = new System.Drawing.Point(169, 54);
            this.passengerTextBox.Name = "passengerTextBox";
            this.passengerTextBox.Size = new System.Drawing.Size(100, 20);
            this.passengerTextBox.TabIndex = 3;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(169, 117);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 4;
            // 
            // carTypeComboBox
            // 
            this.carTypeComboBox.FormattingEnabled = true;
            this.carTypeComboBox.Items.AddRange(new object[] {
            "Limo",
            "Luxury",
            "Mid-Tier",
            "Green",
            "Economy"});
            this.carTypeComboBox.Location = new System.Drawing.Point(169, 175);
            this.carTypeComboBox.Name = "carTypeComboBox";
            this.carTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.carTypeComboBox.TabIndex = 5;
            this.carTypeComboBox.Text = "Car Type";
            // 
            // calculateCostButton
            // 
            this.calculateCostButton.Location = new System.Drawing.Point(130, 271);
            this.calculateCostButton.Name = "calculateCostButton";
            this.calculateCostButton.Size = new System.Drawing.Size(115, 23);
            this.calculateCostButton.TabIndex = 6;
            this.calculateCostButton.Text = "Calculate Cost";
            this.calculateCostButton.UseVisualStyleBackColor = true;
            this.calculateCostButton.Click += new System.EventHandler(this.calculateCostButton_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(480, 63);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(42, 13);
            this.resultsLabel.TabIndex = 7;
            this.resultsLabel.Text = "Results";
            // 
            // companyALabel
            // 
            this.companyALabel.AutoSize = true;
            this.companyALabel.Location = new System.Drawing.Point(480, 117);
            this.companyALabel.Name = "companyALabel";
            this.companyALabel.Size = new System.Drawing.Size(85, 13);
            this.companyALabel.TabIndex = 8;
            this.companyALabel.Text = "Company A Cost";
            // 
            // companyBLabel
            // 
            this.companyBLabel.AutoSize = true;
            this.companyBLabel.Location = new System.Drawing.Point(480, 160);
            this.companyBLabel.Name = "companyBLabel";
            this.companyBLabel.Size = new System.Drawing.Size(85, 13);
            this.companyBLabel.TabIndex = 9;
            this.companyBLabel.Text = "Company B Cost";
            // 
            // companyCLabel
            // 
            this.companyCLabel.AutoSize = true;
            this.companyCLabel.Location = new System.Drawing.Point(480, 205);
            this.companyCLabel.Name = "companyCLabel";
            this.companyCLabel.Size = new System.Drawing.Size(85, 13);
            this.companyCLabel.TabIndex = 10;
            this.companyCLabel.Text = "Company C Cost";
            // 
            // companyACostOutLabel
            // 
            this.companyACostOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyACostOutLabel.Location = new System.Drawing.Point(594, 116);
            this.companyACostOutLabel.Name = "companyACostOutLabel";
            this.companyACostOutLabel.Size = new System.Drawing.Size(100, 23);
            this.companyACostOutLabel.TabIndex = 11;
            // 
            // companyBCostOutLabel
            // 
            this.companyBCostOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyBCostOutLabel.Location = new System.Drawing.Point(594, 159);
            this.companyBCostOutLabel.Name = "companyBCostOutLabel";
            this.companyBCostOutLabel.Size = new System.Drawing.Size(100, 23);
            this.companyBCostOutLabel.TabIndex = 12;
            // 
            // companyCCostOutLabel
            // 
            this.companyCCostOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyCCostOutLabel.Location = new System.Drawing.Point(594, 204);
            this.companyCCostOutLabel.Name = "companyCCostOutLabel";
            this.companyCCostOutLabel.Size = new System.Drawing.Size(100, 23);
            this.companyCCostOutLabel.TabIndex = 13;
            // 
            // lowestCostLabel
            // 
            this.lowestCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestCostLabel.Location = new System.Drawing.Point(483, 271);
            this.lowestCostLabel.Name = "lowestCostLabel";
            this.lowestCostLabel.Size = new System.Drawing.Size(229, 23);
            this.lowestCostLabel.TabIndex = 14;
            // 
            // Program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lowestCostLabel);
            this.Controls.Add(this.companyCCostOutLabel);
            this.Controls.Add(this.companyBCostOutLabel);
            this.Controls.Add(this.companyACostOutLabel);
            this.Controls.Add(this.companyCLabel);
            this.Controls.Add(this.companyBLabel);
            this.Controls.Add(this.companyALabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.calculateCostButton);
            this.Controls.Add(this.carTypeComboBox);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.passengerTextBox);
            this.Controls.Add(this.carTypeLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.passengersLabel);
            this.Name = "Program2";
            this.Text = "IRydeShare Cost Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passengersLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label carTypeLabel;
        private System.Windows.Forms.TextBox passengerTextBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.ComboBox carTypeComboBox;
        private System.Windows.Forms.Button calculateCostButton;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label companyALabel;
        private System.Windows.Forms.Label companyBLabel;
        private System.Windows.Forms.Label companyCLabel;
        private System.Windows.Forms.Label companyACostOutLabel;
        private System.Windows.Forms.Label companyBCostOutLabel;
        private System.Windows.Forms.Label companyCCostOutLabel;
        private System.Windows.Forms.Label lowestCostLabel;
    }
}

